using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockerExplorer.WinForms.Custom
{
   public class StyledTextBox : TextBox
   {
      public StyledTextBox()
      {
         this.BorderStyle = BorderStyle.None;
      }
   }
}
