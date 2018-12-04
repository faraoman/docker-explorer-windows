using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Config.Net;

namespace DockerExplorer.Model
{
   public interface ISettings
   {
      TimeSpan AutoRefreshContainersInterval { get; set; }
   }

   static class Settings
   {
      private static ISettings _instance;

      static Settings()
      {
         _instance = new ConfigurationBuilder<ISettings>()
            .UseIniFile("settings.ini")
            .Build();
      }

      public static ISettings Instance => _instance;
   }
}
