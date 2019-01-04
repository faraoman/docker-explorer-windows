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
using Humanizer;

namespace DockerExplorer.WinForms
{
   public partial class DockerContainers : UserControl, IMainToolbarClient
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


      private async void ReloadContainers(string substring = null)
      {
         try
         {
            IReadOnlyCollection<DockerContainer> containers = await _presenter.GetAllContainersAsync();

            if (!string.IsNullOrEmpty(substring))
            {
               containers = containers
                  .Where(c => c.Name.IndexOf(substring, StringComparison.OrdinalIgnoreCase) != -1)
                  .ToList();
            }

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
         catch (Exception ex)
         {
            this.Handle(ex);
         }
      }

      private void containersList_SelectedIndexChanged(object sender, EventArgs e)
      {
         //deleteContainer.Enabled = true;
         dockerContainerDetails.Visible = true;

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

      public void RefreshAll(string substring)
      {
         ReloadContainers(substring);
      }

      public void Search(string substring)
      {
         ReloadContainers(substring);
      }
   }
}
