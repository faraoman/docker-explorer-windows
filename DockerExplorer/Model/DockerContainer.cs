using System;
using System.Collections.Generic;
using System.Linq;
using Docker.DotNet.Models;

namespace DockerExplorer.Model
{
   public class DockerContainer : DockerEntity
   {
      internal DockerContainer(ContainerListResponse wr)
      {
         Id = wr.ID;
         Image = wr.Image;
         ImageId = wr.ImageID;
         State = wr.State;
         Status = wr.Status;
         Name = wr.Names?.Count > 0
            ? wr.Names.First()
            : null;
         Command = wr.Command;
         Created = wr.Created;
         Labels = new Dictionary<string, string>(wr.Labels);
         Mounts = wr.Mounts == null ? new List<MountPoint>() : new List<MountPoint>(wr.Mounts);
      }

      public string Id { get; }

      public string ShortId => GetShortId(Id);

      public string Name { get; }

      public string Image { get; }

      public string ImageId { get; }

      public string State { get; }

      public string Status { get; }

      public string Command { get; }

      public DateTime Created { get; }

      public IDictionary<string, string> Labels { get; }

      public List<MountPoint> Mounts { get; }
   }
}
