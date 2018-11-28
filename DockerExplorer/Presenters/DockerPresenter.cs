using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Docker.DotNet;
using Docker.DotNet.Models;
using DockerExplorer.Model;

namespace DockerExplorer.Presenters
{
   class DockerPresenter
   {
      private DockerClient _client;

      public DockerPresenter()
      {

      }

      private DockerClient Client
      {
         get
         {
            if(_client == null)
            {
               _client = new DockerClientConfiguration(LocalDockerUri()).CreateClient();
            }

            return _client;
         }
      }

      public async Task<IReadOnlyCollection<DockerImage>> GetAllImagesAsync()
      {
         IList<ImagesListResponse> responseImages = await Client.Images.ListImagesAsync(new ImagesListParameters { All = true });
         var images = responseImages.SelectMany(DockerImage.CreateMany).ToList();

         List<DockerImage> roots = images.Where(i => string.IsNullOrEmpty(i.ParentId)).ToList();

         foreach(DockerImage image in roots)
         {
            AddChildren(images, image);
         }

         return roots;
      }

      public async Task<IReadOnlyCollection<DockerImageHistory>> GetImageHistoryAsync(string imageName)
      {
         IList<ImageHistoryResponse> response = await Client.Images.GetImageHistoryAsync(imageName);

         return response.Select(r => new DockerImageHistory(r)).ToList();
      }

      public async Task<IReadOnlyCollection<DockerContainer>> GetAllContainersAsync()
      {
         IList<ContainerListResponse> containersResponse = await Client.Containers.ListContainersAsync(new ContainersListParameters { All = true });

         return containersResponse.Select(r => new DockerContainer(r)).ToList();
      }

      public async Task GetContainerDetailsAsync(string containerId,
         IProgress<ContainerStatsResponse> progressCallback,
         CancellationToken cancellationToken = default)
      {
         await Client.Containers.GetContainerStatsAsync(
            containerId,
            new ContainerStatsParameters
            {
               Stream = true
            },
            progressCallback,
            cancellationToken);
      }

      public async Task GetContainerLogs(string containerId, IProgress<string> progressCallback,
         CancellationToken cancellationToken = default)
      {
         await Client.Containers.GetContainerLogsAsync(containerId,
            new ContainerLogsParameters
            {
               Follow = true,
               ShowStdout = true,
               ShowStderr = true,
            },
            CancellationToken.None,
            progressCallback);
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