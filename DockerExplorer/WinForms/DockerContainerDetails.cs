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
using Docker.DotNet.Models;
using System.Diagnostics;

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
            // set labels
            containerLabels.Items.Clear();
            foreach (KeyValuePair<string, string> label in value.Labels)
            {
               containerLabels.Items.Add(
                  new ListViewItem(new[] { label.Key, label.Value }, 0));
            }
            foreach(ColumnHeader column in containerLabels.Columns)
            {
               column.Width = -2;
            }

            //set mounts
            containerMounts.Items.Clear();
            foreach(MountPoint mount in value.Mounts)
            {
               containerMounts.Items.Add(
                  new ListViewItem(new[]
                  {
                     mount.Type,
                     mount.Name,
                     mount.Source,
                     mount.Destination,
                     mount.Driver,
                     mount.Mode,
                     mount.RW.ToString(),
                     mount.Propagation
                  }, 0)
                  { Tag = mount });
            }
            foreach(ColumnHeader column in containerMounts.Columns)
            {
               column.Width = -2;
            }
         }
      }

      private void containerMounts_MouseDoubleClick(object sender, MouseEventArgs e)
      {
         if (containerMounts.SelectedItems.Count == 0)
            return;

         MountPoint mountPoint = containerMounts.Items[containerMounts.SelectedIndices[0]].Tag as MountPoint;

         string path = mountPoint.Source;

         Process.Start(path);
      }
   }
}
