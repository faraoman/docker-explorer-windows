namespace DockerExplorer.WinForms
{
   partial class DockerContainers
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
            System.Windows.Forms.ColumnHeader ID;
            System.Windows.Forms.ColumnHeader Name;
            System.Windows.Forms.ColumnHeader Image;
            System.Windows.Forms.ColumnHeader Created;
            System.Windows.Forms.ColumnHeader State;
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.refreshContainers = new System.Windows.Forms.ToolStripButton();
            this.deleteContainer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.comboUpdateInterval = new System.Windows.Forms.ToolStripComboBox();
            this.containersList = new System.Windows.Forms.ListView();
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dockerContainerDetails = new DockerExplorer.WinForms.DockerContainerDetails();
            ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Image = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshContainers,
            this.deleteContainer,
            this.toolStripSeparator1,
            this.comboUpdateInterval});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1065, 47);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // refreshContainers
            // 
            this.refreshContainers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshContainers.Image = global::DockerExplorer.Properties.Resources.refresh;
            this.refreshContainers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshContainers.Name = "refreshContainers";
            this.refreshContainers.Size = new System.Drawing.Size(44, 44);
            this.refreshContainers.Text = "refreshContainersToolButton";
            this.refreshContainers.ToolTipText = "refresh the list of containers";
            this.refreshContainers.Click += new System.EventHandler(this.refreshContainers_Click);
            // 
            // deleteContainer
            // 
            this.deleteContainer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteContainer.Enabled = false;
            this.deleteContainer.Image = global::DockerExplorer.Properties.Resources.delete;
            this.deleteContainer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteContainer.Name = "deleteContainer";
            this.deleteContainer.Size = new System.Drawing.Size(44, 44);
            this.deleteContainer.Text = "toolStripButton2";
            this.deleteContainer.ToolTipText = "delete container";
            this.deleteContainer.Click += new System.EventHandler(this.deleteContainer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // comboUpdateInterval
            // 
            this.comboUpdateInterval.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.comboUpdateInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUpdateInterval.DropDownWidth = 140;
            this.comboUpdateInterval.Items.AddRange(new object[] {
            "no refresh",
            "1 second",
            "5 seconds",
            "10 seconds",
            "1 minute"});
            this.comboUpdateInterval.Name = "comboUpdateInterval";
            this.comboUpdateInterval.Size = new System.Drawing.Size(140, 47);
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
            this.containersList.Location = new System.Drawing.Point(0, 47);
            this.containersList.MultiSelect = false;
            this.containersList.Name = "containersList";
            this.containersList.ShowItemToolTips = true;
            this.containersList.Size = new System.Drawing.Size(1065, 268);
            this.containersList.TabIndex = 5;
            this.containersList.UseCompatibleStateImageBehavior = false;
            this.containersList.View = System.Windows.Forms.View.Details;
            this.containersList.SelectedIndexChanged += new System.EventHandler(this.containersList_SelectedIndexChanged);
            // 
            // Status
            // 
            this.Status.Text = "Status";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 315);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1065, 6);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // dockerContainerDetails
            // 
            this.dockerContainerDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockerContainerDetails.Location = new System.Drawing.Point(0, 315);
            this.dockerContainerDetails.Name = "dockerContainerDetails";
            this.dockerContainerDetails.Size = new System.Drawing.Size(1065, 522);
            this.dockerContainerDetails.TabIndex = 6;
            // 
            // DockerContainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dockerContainerDetails);
            this.Controls.Add(this.containersList);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DockerContainers";
            this.Size = new System.Drawing.Size(1065, 837);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ToolStrip toolStrip1;
      private System.Windows.Forms.ToolStripButton refreshContainers;
      private System.Windows.Forms.ListView containersList;
      private System.Windows.Forms.ColumnHeader Status;
      private DockerContainerDetails dockerContainerDetails;
      private System.Windows.Forms.Splitter splitter1;
      private System.Windows.Forms.ToolStripButton deleteContainer;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      private System.Windows.Forms.ToolStripComboBox comboUpdateInterval;
   }
}
