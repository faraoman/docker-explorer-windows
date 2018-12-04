using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockerExplorer.Model
{
   public class TaggedString<T>
   {
      public TaggedString(string display, T value)
      {
         Display = display;
         Value = value;
      }

      public string Display { get; }
      public T Value { get; }

      public override string ToString() => Display;
   }
}
