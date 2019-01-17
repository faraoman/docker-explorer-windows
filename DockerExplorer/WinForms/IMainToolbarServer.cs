using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockerExplorer.WinForms
{
   public interface IMainToolbarServer
   {
      void ReportCapabilities(bool canDelete);
   }
}
