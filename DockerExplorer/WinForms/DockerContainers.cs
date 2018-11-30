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
using DockerExplorer.Presenters;

namespace DockerExplorer.WinForms
{
   public partial class DockerContainers : UserControl
   {
      private readonly DockerPresenter _presenter;

      public DockerContainers()
      {
         InitializeComponent();

         _presenter = DockerPresenter.Instance;

         if (!this.IsInDesignMode())
         {
            ReloadContainers();
         }
      }

      private async void ReloadContainers()
      {
         try
         {
            IReadOnlyCollection<DockerContainer> containers = await _presenter.GetAllContainersAsync();

            containersList.Items.Clear();
            foreach (DockerContainer container in containers)
            {
               containersList.Items.Add(
                  new ListViewItem(new string[]
                  {
                  container.ShortId,
                  container.Name,
                  container.Image,
                  container.Created.ToString(),
                  container.State,
                  container.Status
                  })
                  {
                     Tag = container,
                     BackColor = GetContainerStateColor(container)
                  });
            }

            foreach (ColumnHeader header in containersList.Columns)
            {
               header.Width = -2;
            }
         }
         catch(Exception ex)
         {
            this.Handle(ex);
         }
      }

      private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
      {
         ReloadContainers();
      }

      private void containersList_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (containersList.SelectedItems.Count == 0)
         {
            deleteContainer.Enabled = false;
            return;
         }

         //deleteContainer.Enabled = true;

         var container = containersList.SelectedItems[0].Tag as DockerContainer;

         dockerContainerDetails.Presenter = _presenter;
         dockerContainerDetails.DockerContainer = container;
      }

      private Color GetContainerStateColor(DockerContainer container)
      {
         switch (container.State)
         {
            case "exited":
               return Color.LightPink;

            default:
               return Color.White;
         }
      }

      private void deleteContainer_Click(object sender, EventArgs e)
      {

      }
   }
}
