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
   public partial class DockerImages : UserControl, IMainToolbarClient
   {
      private readonly DockerPresenter _presenter;
      private string _lastSelectedImageId = null;
      private string _lastSubstring = null;

      public IMainToolbarServer ToolbarServer { get; set; }

      public DockerImages()
      {
         InitializeComponent();

         _presenter = DockerPresenter.Instance;

         if (!this.IsInDesignMode())
         {
            ReloadImages();
         }
      }

      private async void ReloadImages(string substring = null)
      {
         try
         {
            IReadOnlyCollection<DockerImage> images = await _presenter.GetAllImagesAsync();

            AddImages(images, treeDockerImages.Nodes);
            AddAllImages(images, substring);
         }
         catch (Exception ex)
         {
            this.Handle(ex);
         }

         if(_lastSelectedImageId == null)
         {
            _lastSelectedImageId = treeDockerImages.SelectedNode == null
               ? null
               : (treeDockerImages.SelectedNode.Tag as DockerImage)?.ShortId;
         }

         SelectImage(_lastSelectedImageId);
      }

      private void AddAllImages(IReadOnlyCollection<DockerImage> images, string substring)
      {
         listDockerImages.Items.Clear();

         AddSubImages(images, substring);

         listDockerImages.AutoAlign();
      }

      private void AddSubImages(IReadOnlyCollection<DockerImage> images, string substring)
      {
         if(!string.IsNullOrEmpty(substring))
         {
            images = images
               .Where(i => i.Name.IndexOf(substring, StringComparison.OrdinalIgnoreCase) != -1)
               .ToList();
         }


         foreach(DockerImage image in images)
         {
            if (!(checkHideUntagged.Checked && image.Tag == "<none>"))
            {
               listDockerImages.Items.Add(
                  new ListViewItem(new[]
                  {
                  image.Name
                  })
                  {
                     Tag = image
                  });
            }

            if(image.Children?.Count > 0)
            {
               AddSubImages(image.Children, substring);
            }
         }
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


      private void treeDockerImages_AfterSelect(object sender, TreeViewEventArgs e)
      {
         if (treeDockerImages.SelectedNode == null || !(treeDockerImages.SelectedNode.Tag is DockerImage image))
            return;

         RenderImage(image);
      }

      private void listDockerImages_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (listDockerImages.SelectedItems.Count == 0 || !(listDockerImages.SelectedItems[0].Tag is DockerImage image))
            return;

         RenderImage(image);
      }

      private async void RenderImage(DockerImage image)
      {
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
         foreach (DockerImageHistory item in history)
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

      public void ToolbarRefreshAll(string substring)
      {
         ReloadImages(substring);

         _lastSubstring = substring;
      }

      public void ToolbarSearch(string substring)
      {
         ReloadImages(substring);

         _lastSubstring = substring;
      }

      private void checkHideUntagged_CheckedChanged(object sender, EventArgs e)
      {
         ReloadImages(_lastSubstring);
      }

      public void ToolbarActivate()
      {
         ToolbarServer.ReportCapabilities(false);
      }

      public async Task ToolbarDeleteAsync()
      {
         
      }
   }
}
