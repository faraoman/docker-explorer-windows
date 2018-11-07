using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DockerExplorer.Model;

namespace DockerExplorer.WinForms
{
   public partial class DockerContainerDetails : UserControl
   {
      public DockerContainerDetails()
      {
         InitializeComponent();
      }

      public DockerContainer DockerContainer
      {
         set
         {
            containerLabels.Items.Clear();
            foreach (KeyValuePair<string, string> label in value.Labels)
            {
               containerLabels.Items.Add(new ListViewItem(new[] { label.Key, label.Value }, 0));
            }
            foreach(ColumnHeader column in containerLabels.Columns)
            {
               column.Width = -2;
            }
         }
      }
   }
}
