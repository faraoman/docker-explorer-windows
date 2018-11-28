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
      public DockerImage(string id, string parentId, string tag, long size)
      {
         Id = id;
         ParentId = parentId;
         Tag = tag;
         Size = size;

         int idx = tag.IndexOf(':');
         if(idx == -1)
         {
            Repository = Tag;
            Tag = "latest";
         }
         else
         {
            Repository = tag.Substring(0, idx);
            Tag = tag.Substring(idx + 1);
         }
      }

      internal static IEnumerable<DockerImage> CreateMany(ImagesListResponse wr)
      {
         foreach(string tag in wr.RepoTags)
         {
            var image = new DockerImage(wr.ID, wr.ParentID, tag, wr.Size);
            yield return image;
         }
      }

      public string Id { get; }

      public string Name => $"{Repository}:{Tag}";

      public string ParentId { get; }

      public string Repository { get; }

      public string Tag { get; }

      public long Size { get; }

      public IReadOnlyCollection<DockerImage> Children { get; set; }

      public override string ToString() => Tag;
   }
}
