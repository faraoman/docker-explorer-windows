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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DockerServerControl));
            System.Windows.Forms.ColumnHeader ID;
            System.Windows.Forms.ColumnHeader Name;
            System.Windows.Forms.ColumnHeader Image;
            System.Windows.Forms.ColumnHeader Created;
            System.Windows.Forms.ColumnHeader State;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParentId = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.treeDockerImages = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.containersList = new System.Windows.Forms.ListView();
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dockerContainerDetails = new DockerExplorer.WinForms.DockerContainerDetails();
            ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Image = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1173, 756);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.splitter1);
            this.tabPage1.Controls.Add(this.treeDockerImages);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1165, 714);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Images";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTags);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSize);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtParentId);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(423, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 708);
            this.panel1.TabIndex = 2;
            // 
            // txtTags
            // 
            this.txtTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTags.Location = new System.Drawing.Point(133, 136);
            this.txtTags.Multiline = true;
            this.txtTags.Name = "txtTags";
            this.txtTags.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTags.Size = new System.Drawing.Size(587, 215);
            this.txtTags.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tags:";
            // 
            // txtSize
            // 
            this.txtSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSize.Location = new System.Drawing.Point(134, 94);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(587, 34);
            this.txtSize.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Size:";
            // 
            // txtParentId
            // 
            this.txtParentId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParentId.Location = new System.Drawing.Point(133, 52);
            this.txtParentId.Name = "txtParentId";
            this.txtParentId.Size = new System.Drawing.Size(587, 34);
            this.txtParentId.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.Location = new System.Drawing.Point(134, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(587, 34);
            this.txtId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parent ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(418, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 708);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // treeDockerImages
            // 
            this.treeDockerImages.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeDockerImages.HideSelection = false;
            this.treeDockerImages.Location = new System.Drawing.Point(3, 3);
            this.treeDockerImages.Name = "treeDockerImages";
            this.treeDockerImages.Size = new System.Drawing.Size(415, 708);
            this.treeDockerImages.TabIndex = 0;
            this.treeDockerImages.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeDockerImages_AfterSelect);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dockerContainerDetails);
            this.tabPage2.Controls.Add(this.splitter2);
            this.tabPage2.Controls.Add(this.containersList);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1165, 714);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Containers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(3, 306);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1159, 6);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1159, 35);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(32, 32);
            this.toolStripButton1.Text = "refreshContainersToolButton";
            // 
            // containersList
            // 
            this.containersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.containersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            ID,
            Name,
            Image,
            Created,
            State,
            this.Status});
            this.containersList.Dock = System.Windows.Forms.DockStyle.Top;
            this.containersList.FullRowSelect = true;
            this.containersList.GridLines = true;
            this.containersList.HideSelection = false;
            this.containersList.Location = new System.Drawing.Point(3, 38);
            this.containersList.Name = "containersList";
            this.containersList.Size = new System.Drawing.Size(1159, 268);
            this.containersList.TabIndex = 4;
            this.containersList.UseCompatibleStateImageBehavior = false;
            this.containersList.View = System.Windows.Forms.View.Details;
            this.containersList.SelectedIndexChanged += new System.EventHandler(this.containersList_SelectedIndexChanged);
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // Name
            // 
            Name.Text = "Name";
            // 
            // Image
            // 
            Image.Text = "Image";
            // 
            // Created
            // 
            Created.Text = "Created";
            // 
            // State
            // 
            State.Text = "State";
            // 
            // Status
            // 
            this.Status.Text = "Status";
            // 
            // dockerContainerDetails
            // 
            this.dockerContainerDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockerContainerDetails.Location = new System.Drawing.Point(3, 312);
            this.dockerContainerDetails.Name = "dockerContainerDetails";
            this.dockerContainerDetails.Size = new System.Drawing.Size(1159, 399);
            this.dockerContainerDetails.TabIndex = 3;
            // 
            // DockerServerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "DockerServerControl";
            this.Size = new System.Drawing.Size(1173, 756);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.TreeView treeDockerImages;
      private System.Windows.Forms.Splitter splitter1;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.TextBox txtParentId;
      private System.Windows.Forms.TextBox txtId;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtSize;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox txtTags;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Splitter splitter2;
      private System.Windows.Forms.ToolStrip toolStrip1;
      private System.Windows.Forms.ToolStripButton toolStripButton1;
      private WinForms.DockerContainerDetails dockerContainerDetails;
      private System.Windows.Forms.ListView containersList;
      private System.Windows.Forms.ColumnHeader Status;
   }
}
