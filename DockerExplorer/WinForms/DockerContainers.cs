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
using DockerExplorer.Properties;

namespace DockerExplorer.WinForms
{
   public partial class DockerContainers : UserControl, IMainToolbarClient
   {
      private readonly DockerPresenter _presenter;
      private string _lastSubstring = null;

      public IMainToolbarServer ToolbarServer { get; set; }

      public DockerContainers()
      {
         InitializeComponent();

         _presenter = DockerPresenter.Instance;

         if (!this.IsInDesignMode())
         {
            ReloadContainersAsync();
         }
      }

      private async void ReloadContainersAsync(string substring = null)
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
         bool someSelected = containersList.SelectedItems.Count > 0;

         //deleteContainer.Enabled = true;
         dockerContainerDetails.Visible = someSelected;

         if (someSelected)
         {
            var container = containersList.SelectedItems[0].Tag as DockerContainer;

            dockerContainerDetails.Presenter = _presenter;
            dockerContainerDetails.DockerContainer = container;
         }

         UpdateCaps();
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

      public void ToolbarRefreshAll(string substring)
      {
         ReloadContainersAsync(substring);
      }

      public void ToolbarSearch(string substring)
      {
         ReloadContainersAsync(substring);

         _lastSubstring = substring;
      }

      public void ToolbarActivate()
      {
         UpdateCaps();
      }

      private void containersList_ItemChecked(object sender, ItemCheckedEventArgs e)
      {
         UpdateCaps();
      }

      private void UpdateCaps()
      {
         bool someCheckedOrSelected = containersList.CheckedItems.Count > 0 || containersList.SelectedItems.Count > 0;

         ToolbarServer.ReportCapabilities(someCheckedOrSelected);
      }

      public async Task ToolbarDeleteAsync()
      {
         IReadOnlyCollection<DockerContainer> containers = SelectedContainers;
         if (containers.Count == 0) return;

         string containerList = string.Join(Environment.NewLine, containers.Select(c => c.Name));

         if (DialogResult.Yes == MessageBox.Show(
            string.Format(Resources.Dialog_DeleteContainers_Text, containerList),
            Resources.Dialog_DeleteContainers_Title,
            MessageBoxButtons.YesNo))
         {
            try
            {
               foreach(DockerContainer container in containers)
               {
                  await _presenter.DeleteContainer(container);
               }
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.ToString());
            }

            ReloadContainersAsync(_lastSubstring);
         }
      }

      private IReadOnlyCollection<DockerContainer> SelectedContainers
      {
         get
         {
            var checkedContainers = containersList.CheckedItems
               .Cast<ListViewItem>()
               .Select(i => i.Tag as DockerContainer)
               .Where(i => i != null)
               .ToList();

            if(checkedContainers.Count == 0)
            {
               return containersList.SelectedItems
                  .Cast<ListViewItem>()
                  .Select(i => i.Tag as DockerContainer)
                  .Where(i => i != null)
                  .ToList();
            }

            return checkedContainers;
         }
      }
   }
}
