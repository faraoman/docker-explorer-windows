using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DockerExplorer.Presenters;
using DockerExplorer.Model;
using NetBox.Extensions;
using DockerExplorer.WinForms;

namespace DockerExplorer
{
   public partial class DockerServerControl : UserControl
   {
      private readonly DockerPresenter _presenter;

      public DockerServerControl()
      {

         InitializeComponent();

         _presenter = new DockerPresenter();

         if (!this.IsInDesignMode())
         {
            ReloadImages();
            ReloadContainers();
         }
      }

      private async void ReloadImages()
      {
         IReadOnlyCollection<DockerImage> images = await _presenter.GetAllImagesAsync();

         AddImages(images, treeDockerImages.Nodes);
      }

      private async void ReloadContainers()
      {
         IReadOnlyCollection<DockerContainer> containers = await _presenter.GetAllContainersAsync();

         containersList.Items.Clear();
         foreach(DockerContainer container in containers)
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
                  Tag = container
               });
         }

         foreach(ColumnHeader header in containersList.Columns)
         {
            header.Width = -2;
         }
      }

      private void AddImages(IReadOnlyCollection<DockerImage> images, TreeNodeCollection nodes)
      {
         nodes.Clear();

         foreach (DockerImage image in images)
         {
            var node = new TreeNode(image.RepoTags[0])
            {
               Tag = image
            };

            nodes.Add(node);

            if(image.Children?.Count > 0)
            {
               AddImages(image.Children, node.Nodes);
            }

            node.Expand();
         }
      }

      private async void treeDockerImages_AfterSelect(object sender, TreeViewEventArgs e)
      {
         if (treeDockerImages.SelectedNode == null || !(treeDockerImages.SelectedNode.Tag is DockerImage image))
            return;

         txtId.Text = image.Id;
         txtParentId.Text = image.ParentId;
         txtSize.Text = image.Size.ToFileSizeUiString();
         txtTags.Text = string.Join(Environment.NewLine, image.RepoTags);
      }

      private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
      {
         ReloadContainers();
      }

      private void containersList_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (containersList.SelectedItems.Count == 0)
         {
            return;
         }

         var container = containersList.SelectedItems[0].Tag as DockerContainer;

         dockerContainerDetails.DockerContainer = container;

         //await _presenter.GetDetailsAsync(container.Id);
      }
   }
}
