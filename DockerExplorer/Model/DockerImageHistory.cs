using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Docker.DotNet.Models;

namespace DockerExplorer.Model
{
   public class DockerImageHistory : DockerEntity
   {
      public DockerImageHistory(string id, DateTime created, string createdBy, IList<string> tags, long size, string comment)
      {
         Id = id;
         Created = created;
         CreatedBy = createdBy;
         Tags = tags;
         Size = size;
         Comment = comment;
      }

      internal DockerImageHistory(ImageHistoryResponse ihr)
         : this(ihr.ID, ihr.Created, ihr.CreatedBy, ihr.Tags, ihr.Size, ihr.Comment)
      {

      }

      public string Id { get; }

      public string ShortId => GetShortId(Id);

      public DateTime Created { get; }
      public string CreatedBy { get; }
      public IList<string> Tags { get; }
      public long Size { get; }
      public string Comment { get; }
   }
}
