using System;
using System.Windows.Forms;

namespace DockerExplorer.WinForms
{
   internal static class ControlExtension
   {
      public static bool IsInDesignMode(this Control control)
      {
         while (control != null)
         {
            if (control.Site != null && control.Site.DesignMode)
               return true;
            control = control.Parent;
         }
         return false;
      }

      public static void Handle(this Control control, Exception ex)
      {
         if (control.IsInDesignMode())
            return;

         MessageBox.Show(control, "Docker Explorer", ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
   }
}
