using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockerExplorer.Model
{
   public class DockerEntity
   {
      protected string GetShortId(string id)
      {
         if (string.IsNullOrEmpty(id))
            return id;
            
         if (id.StartsWith("sha256:"))
            id = id.Substring(7);

         if (id.Length < 12)
            return id;

         return id.Substring(0, 12);
      }
   }
}
