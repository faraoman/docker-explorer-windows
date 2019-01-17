namespace DockerExplorer
{
   partial class DockerServerControl
   {
      /// <summary> 
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DockerServerControl));
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dockerContainersTab = new DockerExplorer.WinForms.DockerContainers();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dockerImagesTab = new DockerExplorer.WinForms.DockerImages();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.refreshToolButton = new System.Windows.Forms.ToolStripButton();
            this.comboUpdateInterval = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolButton = new System.Windows.Forms.ToolStripButton();
            this.dockerVolumesTab = new DockerExplorer.WinForms.DockerVolumes();
            this.tabs.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.ImageList = this.imageList1;
            this.tabs.ItemSize = new System.Drawing.Size(150, 50);
            this.tabs.Location = new System.Drawing.Point(0, 47);
            this.tabs.Multiline = true;
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1173, 709);
            this.tabs.TabIndex = 0;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dockerContainersTab);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1165, 651);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Containers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dockerContainersTab
            // 
            this.dockerContainersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockerContainersTab.Location = new System.Drawing.Point(3, 3);
            this.dockerContainersTab.Name = "dockerContainersTab";
            this.dockerContainersTab.Size = new System.Drawing.Size(1159, 645);
            this.dockerContainersTab.TabIndex = 0;
            this.dockerContainersTab.ToolbarServer = null;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dockerImagesTab);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1165, 651);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Images";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dockerImagesTab
            // 
            this.dockerImagesTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockerImagesTab.Location = new System.Drawing.Point(3, 3);
            this.dockerImagesTab.Name = "dockerImagesTab";
            this.dockerImagesTab.Size = new System.Drawing.Size(1159, 645);
            this.dockerImagesTab.TabIndex = 0;
            this.dockerImagesTab.ToolbarServer = null;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dockerVolumesTab);
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 54);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1165, 651);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Volumes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "image.png");
            this.imageList1.Images.SetKeyName(1, "container.png");
            this.imageList1.Images.SetKeyName(2, "mount.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolButton,
            this.comboUpdateInterval,
            this.toolStripLabel1,
            this.searchText,
            this.toolStripSeparator1,
            this.deleteToolButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1173, 47);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // refreshToolButton
            // 
            this.refreshToolButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.refreshToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshToolButton.Image = global::DockerExplorer.Properties.Resources.refresh;
            this.refreshToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshToolButton.Name = "refreshToolButton";
            this.refreshToolButton.Size = new System.Drawing.Size(44, 44);
            this.refreshToolButton.Text = "toolStripButton1";
            this.refreshToolButton.ToolTipText = "refresh now";
            this.refreshToolButton.Click += new System.EventHandler(this.refreshToolButton_Click);
            // 
            // comboUpdateInterval
            // 
            this.comboUpdateInterval.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.comboUpdateInterval.Name = "comboUpdateInterval";
            this.comboUpdateInterval.Size = new System.Drawing.Size(121, 47);
            this.comboUpdateInterval.ToolTipText = "autorefresh interval";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(78, 44);
            this.toolStripLabel1.Text = "search:";
            // 
            // searchText
            // 
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(200, 47);
            this.searchText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchText_KeyUp);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // deleteToolButton
            // 
            this.deleteToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteToolButton.Image = global::DockerExplorer.Properties.Resources.delete;
            this.deleteToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolButton.Name = "deleteToolButton";
            this.deleteToolButton.Size = new System.Drawing.Size(44, 44);
            this.deleteToolButton.Text = "toolStripButton1";
            this.deleteToolButton.ToolTipText = "delete selected";
            this.deleteToolButton.Click += new System.EventHandler(this.deleteToolButton_Click);
            // 
            // dockerVolumesTab
            // 
            this.dockerVolumesTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockerVolumesTab.Location = new System.Drawing.Point(3, 3);
            this.dockerVolumesTab.Name = "dockerVolumesTab";
            this.dockerVolumesTab.Size = new System.Drawing.Size(1159, 645);
            this.dockerVolumesTab.TabIndex = 0;
            this.dockerVolumesTab.ToolbarServer = null;
            // 
            // DockerServerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DockerServerControl";
            this.Size = new System.Drawing.Size(1173, 756);
            this.tabs.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TabControl tabs;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TabPage tabPage2;
      private WinForms.DockerContainers dockerContainersTab;
      private WinForms.DockerImages dockerImagesTab;
      private System.Windows.Forms.ImageList imageList1;
      private System.Windows.Forms.ToolStrip toolStrip1;
      private System.Windows.Forms.ToolStripButton refreshToolButton;
      private System.Windows.Forms.ToolStripComboBox comboUpdateInterval;
      private System.Windows.Forms.ToolStripTextBox searchText;
      private System.Windows.Forms.ToolStripLabel toolStripLabel1;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      private System.Windows.Forms.ToolStripButton deleteToolButton;
      private System.Windows.Forms.TabPage tabPage3;
      private WinForms.DockerVolumes dockerVolumesTab;
   }
}
