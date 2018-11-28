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

namespace DockerExplorer.WinForms
{
   public partial class DockerImages : UserControl
   {
      private readonly DockerPresenter _presenter;

      public DockerImages()
      {
         InitializeComponent();

         _presenter = new DockerPresenter();

         if (!this.IsInDesignMode())
         {
            ReloadImages();
         }
      }

      private async void ReloadImages()
      {
         try
         {
            IReadOnlyCollection<DockerImage> images = await _presenter.GetAllImagesAsync();

            AddImages(images, treeDockerImages.Nodes);
         }
         catch (Exception ex)
         {
            this.Handle(ex);
         }
      }

      private void AddImages(IReadOnlyCollection<DockerImage> images, TreeNodeCollection nodes)
      {
         nodes.Clear();

         foreach (DockerImage image in images)
         {
            var node = new TreeNode(image.Tag)
            {
               Tag = image
            };

            nodes.Add(node);

            if (image.Children?.Count > 0)
            {
               AddImages(image.Children, node.Nodes);
            }

            node.Expand();
         }
      }


      private void treeDockerImages_AfterSelect(object sender, TreeViewEventArgs e)
      {
         if (treeDockerImages.SelectedNode == null || !(treeDockerImages.SelectedNode.Tag is DockerImage image))
            return;

         txtId.Text = image.Id;
         txtParentId.Text = image.ParentId;
         txtSize.Text = image.Size.ToFileSizeUiString();
         txtTags.Text = string.Join(Environment.NewLine, image.Tag);
      }
   }
}
