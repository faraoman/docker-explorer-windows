using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Squirrel;
using DockerExplorer.Presenters;
using LogMagic;
using LogMagic.Enrichers;
using NetBox.Extensions;

namespace DockerExplorer
{
   static class Program
   {
      private static readonly ILog log = L.G(typeof(Program));

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static async Task Main()
      {
         //init logging
         L.Config
            .WriteTo.Trace()
            .WriteTo.AzureApplicationInsights("bb403325-5d60-47c5-8dab-ce4783b5eb2a")
            .EnrichWith.Constant(KnownProperty.Version, typeof(Program).FileVersion().ToString());

         log.Event("AppStart");

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
            log.Event("DockerNotRunning");

            MessageBox.Show("Local Docker instance is not running, terminating", "Pointless to Start", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return;
         }

         Application.Run(new MainForm());
      }
   }
}
