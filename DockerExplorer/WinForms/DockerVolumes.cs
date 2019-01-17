using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockerExplorer.WinForms
{
   public partial class DockerVolumes : UserControl, IMainToolbarClient
   {
      public DockerVolumes()
      {
         InitializeComponent();
      }

      public IMainToolbarServer ToolbarServer { get; set; }

      public void ToolbarActivate()
      {
         ToolbarServer.ReportCapabilities(false);
      }

      public async Task ToolbarDeleteAsync()
      {

      }

      public void ToolbarRefreshAll(string substring)
      {

      }

      public void ToolbarSearch(string substring)
      {

      }
   }
}
