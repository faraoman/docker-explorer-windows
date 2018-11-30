using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Squirrel;

namespace DockerExplorer
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static async Task Main()
      {
#if RELEASE
         using (var mgr = new UpdateManager("http://i.isolineltd.com/dockerexplorer"))
         {
            await mgr.UpdateApp();
         }
#endif

         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new MainForm());
      }
   }
}
