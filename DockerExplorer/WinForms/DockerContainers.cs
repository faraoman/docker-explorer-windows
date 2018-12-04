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
   public partial class DockerContainers : UserControl
   {
      private readonly DockerPresenter _presenter;
      private DateTime _lastUpdated = DateTime.MinValue;

      private static readonly Dictionary<string, TimeSpan> _updateTextToValue = new Dictionary<string, TimeSpan>
      {
         ["no refresh"] = TimeSpan.MaxValue,
         ["1 second"] = TimeSpan.FromSeconds(1),
         ["1 minute"] = TimeSpan.FromMinutes(1)
      };

      public DockerContainers()
      {
         InitializeComponent();

         comboUpdateInterval.ComboBox.DataSource = 
            _updateTextToValue.Select(i => new TaggedString<TimeSpan>(i.Key, i.Value)).ToArray();
         comboUpdateInterval.ComboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
         UpdateInterval = Settings.Instance.AutoRefreshContainersInterval;

         _presenter = DockerPresenter.Instance;

         if (!this.IsInDesignMode())
         {
            ReloadContainers();
         }
      }

      private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         TaggedString<TimeSpan> selected = (TaggedString<TimeSpan>)comboUpdateInterval.ComboBox.SelectedValue;

         Settings.Instance.AutoRefreshContainersInterval = selected.Value;
      }

      private TimeSpan UpdateInterval
      {
         get
         {
            try
            {
               var selected = (TaggedString<TimeSpan>)comboUpdateInterval.ComboBox.SelectedValue;

               return selected.Value;
            }
            catch(Exception)
            {
               return TimeSpan.MaxValue;
            }
         }
         set
         {
            int selected = -1;

            //find item
            int i = 0;
            foreach(TaggedString<TimeSpan> item in comboUpdateInterval.ComboBox.Items)
            {
               if(item.Value == value)
               {
                  selected = i;
                  break;
               }
               i++;
            }

            if(selected == -1)
            {
               selected = 0;
            }

            comboUpdateInterval.ComboBox.SelectedIndex = selected;
         }
      }

      private async void ReloadContainers()
      {
         if (DateTime.UtcNow - _lastUpdated > UpdateInterval)
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

               _lastUpdated = DateTime.UtcNow;
            }
            catch (Exception ex)
            {
               this.Handle(ex);
            }
         }

         UpdateLastUpdatedLabel();
         await Task.Delay(TimeSpan.FromSeconds(1));
         ReloadContainers();
      }

      private void UpdateLastUpdatedLabel()
      {
         TimeSpan ago = DateTime.UtcNow - _lastUpdated;

         //txtLastUpdated.Text = $"updated: {ago.Humanize()} ago";
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
