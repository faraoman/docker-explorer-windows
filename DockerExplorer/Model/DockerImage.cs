using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Docker.DotNet.Models;

namespace DockerExplorer.Model
{
   public class DockerImage
   {
      internal DockerImage(ImagesListResponse wr)
      {
         Id = wr.ID;
         ParentId = wr.ParentID;
         RepoTags = wr.RepoTags.ToArray();
         Size = wr.Size;
      }

      public string Id { get; }

      public string ParentId { get; }

      public string[] RepoTags { get; }

      public long Size { get; }

      public IReadOnlyCollection<DockerImage> Children { get; set; }
   }
}
