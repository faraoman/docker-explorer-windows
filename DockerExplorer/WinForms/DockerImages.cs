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
      private string _lastSelectedImageId = null;

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

         if(_lastSelectedImageId == null)
         {
            _lastSelectedImageId = (treeDockerImages.Nodes.Cast<TreeNode>().FirstOrDefault()?.Tag as DockerImage)?.ShortId;
         }

         SelectImage(_lastSelectedImageId);
      }

      private void AddImages(IReadOnlyCollection<DockerImage> images, TreeNodeCollection nodes)
      {
         nodes.Clear();

         foreach (DockerImage image in images)
         {
            var node = new TreeNode(image.Name)
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


      private async void treeDockerImages_AfterSelect(object sender, TreeViewEventArgs e)
      {
         if (treeDockerImages.SelectedNode == null || !(treeDockerImages.SelectedNode.Tag is DockerImage image))
            return;

         txtId.Text = image.ShortId;
         if (string.IsNullOrEmpty(image.ParentId))
         {
            linkParentId.Enabled = false;
            linkParentId.Text = "none";
         }
         else
         {
            linkParentId.Enabled = true;
            linkParentId.Text = image.ShortParentId;
         }
         txtSize.Text = image.Size.ToFileSizeUiString();
         txtRepository.Text = image.Repository;
         txtTag.Text = image.Tag;

         //popular image history
         IReadOnlyCollection<DockerImageHistory> history = await _presenter.GetImageHistoryAsync(image.Id);

         listContainerHistory.Items.Clear();
         foreach(DockerImageHistory item in history)
         {
            listContainerHistory.Items.Add(
               new ListViewItem(new[]
               {
                  item.ShortId,
                  item.Created.ToString(),
                  item.CreatedBy,
                  item.Size.ToFileSizeUiString(),
                  item.Comment,
                  item.Tags == null ? string.Empty : string.Join(", ", item.Tags)
               }));
         }
         listContainerHistory.AutoAlign();

      }



      private void linkParentId_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         SelectImage(linkParentId.Text);
      }

      private void SelectImage(string imageShortId)
      {
         if (imageShortId == null)
            return;

         TreeNode node = FindNode(treeDockerImages.Nodes, i => i.ShortId == imageShortId);

         if (node != null)
         {
            treeDockerImages.SelectedNode = node;
            _lastSelectedImageId = ((DockerImage)node.Tag).ShortId;
         }
      }

      private TreeNode FindNode(TreeNodeCollection nodes, Func<DockerImage, bool> predicate)
      {
         foreach(TreeNode node in nodes)
         {
            if (node.Tag is DockerImage image)
            {
               if (predicate(image))
                  return node;

               if(node.Nodes.Count > 0)
               {
                  TreeNode cr = FindNode(node.Nodes, predicate);
                  if (cr != null)
                     return cr;
               }
            }
         }

         return null;
      }

      private void refreshImages_Click(object sender, EventArgs e)
      {
         ReloadImages();
      }
   }
}
