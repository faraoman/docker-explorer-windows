using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Docker.DotNet;
using Docker.DotNet.Models;
using DockerExplorer.Model;

namespace DockerExplorer.Presenters
{
   class DockerPresenter : IProgress<ContainerStatsResponse>
   {
      private readonly DockerClient _client = new DockerClientConfiguration(LocalDockerUri()).CreateClient();

      public DockerPresenter()
      {

      }

      public async Task<IReadOnlyCollection<DockerImage>> GetAllImagesAsync()
      {
         IList<ImagesListResponse> responseImages = await _client.Images.ListImagesAsync(new ImagesListParameters { All = true });
         var images = responseImages.Select(r => new DockerImage(r)).ToList();

         List<DockerImage> roots = images.Where(i => string.IsNullOrEmpty(i.ParentId)).ToList();

         foreach(DockerImage image in roots)
         {
            AddChildren(images, image);
         }

         return roots;
      }

      public async Task<IReadOnlyCollection<DockerContainer>> GetAllContainersAsync()
      {
         IList<ContainerListResponse> containersResponse = await _client.Containers.ListContainersAsync(new ContainersListParameters { All = true });

         return containersResponse.Select(r => new DockerContainer(r)).ToList();
      }

      public async Task GetDetailsAsync(string containerId)
      {
         await _client.Containers.GetContainerStatsAsync(
            containerId,
            new ContainerStatsParameters
            {
               Stream = true
            },
            this);

         ContainerInspectResponse inspectInfo = await _client.Containers.InspectContainerAsync(containerId);
      }

      public void Report(ContainerStatsResponse value)
      {

      }

      private void AddChildren(IReadOnlyCollection<DockerImage> allImages, DockerImage parent)
      {
         var children = allImages.Where(i => i.ParentId == parent.Id).ToList();

         if(children.Count > 0)
         {
            parent.Children = children;

            foreach(DockerImage child in children)
            {
               AddChildren(allImages, child);
            }
         }
      }

      private static Uri LocalDockerUri()
      {
         bool isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

         return isWindows ? new Uri("npipe://./pipe/docker_engine") : new Uri("unix:/var/run/docker.sock");
      }
   }
}