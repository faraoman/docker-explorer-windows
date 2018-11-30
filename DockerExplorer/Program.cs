using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Squirrel;
using DockerExplorer.Presenters;

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
         //runs Squirrel update
#if RELEASE
         using (var mgr = new UpdateManager("http://i.isolineltd.com/dockerexplorer"))
         {
            await mgr.UpdateApp();
         }
#endif

         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);

         //check if docker is running
         if (!(await DockerPresenter.Instance.IsRunningAsync()))
         {
            MessageBox.Show("Local Docker instance is not running, terminating", "Pointless to Start", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return;
         }

         Application.Run(new MainForm());
      }
   }
}
