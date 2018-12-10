namespace DockerExplorer.WinForms
{
   partial class DockerContainerDetails
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
            System.Windows.Forms.ColumnHeader columnHeader1;
            System.Windows.Forms.ColumnHeader columnHeader2;
            System.Windows.Forms.ColumnHeader Name;
            System.Windows.Forms.ColumnHeader Type;
            System.Windows.Forms.ColumnHeader Source;
            System.Windows.Forms.ColumnHeader Destination;
            System.Windows.Forms.ColumnHeader Driver;
            System.Windows.Forms.ColumnHeader Mode;
            System.Windows.Forms.ColumnHeader RW;
            System.Windows.Forms.ColumnHeader Propagation;
            System.Windows.Forms.ColumnHeader IP;
            System.Windows.Forms.ColumnHeader PrivatePort;
            System.Windows.Forms.ColumnHeader PublicPort;
            System.Windows.Forms.ColumnHeader TypeString;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DockerContainerDetails));
            this.tabLabels = new System.Windows.Forms.TabPage();
            this.containerLabels = new System.Windows.Forms.ListView();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.tabMounts = new System.Windows.Forms.TabPage();
            this.containerMounts = new System.Windows.Forms.ListView();
            this.tabPorts = new System.Windows.Forms.TabPage();
            this.containerPorts = new System.Windows.Forms.ListView();
            this.tabNetworks = new System.Windows.Forms.TabPage();
            this.networksTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Source = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Destination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Driver = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Mode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            RW = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Propagation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            PrivatePort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            PublicPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            TypeString = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabLabels.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabLogs.SuspendLayout();
            this.tabMounts.SuspendLayout();
            this.tabPorts.SuspendLayout();
            this.tabNetworks.SuspendLayout();
            this.networksTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Value";
            columnHeader2.Width = 437;
            // 
            // Name
            // 
            Name.Text = "Name";
            // 
            // Type
            // 
            Type.Text = "Type";
            Type.Width = 437;
            // 
            // Source
            // 
            Source.Text = "Source";
            // 
            // Destination
            // 
            Destination.Text = "Destination";
            // 
            // Driver
            // 
            Driver.Text = "Driver";
            // 
            // Mode
            // 
            Mode.Text = "Mode";
            // 
            // RW
            // 
            RW.Text = "RW";
            // 
            // Propagation
            // 
            Propagation.Text = "Propagation";
            // 
            // IP
            // 
            IP.Text = "IP";
            // 
            // PrivatePort
            // 
            PrivatePort.Text = "Private Port";
            PrivatePort.Width = 437;
            // 
            // PublicPort
            // 
            PublicPort.Text = "Public Port";
            // 
            // TypeString
            // 
            TypeString.Text = "Type";
            // 
            // tabLabels
            // 
            this.tabLabels.Controls.Add(this.containerLabels);
            this.tabLabels.ImageIndex = 1;
            this.tabLabels.Location = new System.Drawing.Point(4, 49);
            this.tabLabels.Name = "tabLabels";
            this.tabLabels.Padding = new System.Windows.Forms.Padding(3);
            this.tabLabels.Size = new System.Drawing.Size(990, 583);
            this.tabLabels.TabIndex = 0;
            this.tabLabels.Text = "Labels";
            this.tabLabels.UseVisualStyleBackColor = true;
            // 
            // containerLabels
            // 
            this.containerLabels.AllowColumnReorder = true;
            this.containerLabels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.containerLabels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2});
            this.containerLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerLabels.FullRowSelect = true;
            this.containerLabels.GridLines = true;
            this.containerLabels.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.containerLabels.HideSelection = false;
            this.containerLabels.Location = new System.Drawing.Point(3, 3);
            this.containerLabels.MultiSelect = false;
            this.containerLabels.Name = "containerLabels";
            this.containerLabels.ShowGroups = false;
            this.containerLabels.Size = new System.Drawing.Size(984, 577);
            this.containerLabels.TabIndex = 0;
            this.containerLabels.UseCompatibleStateImageBehavior = false;
            this.containerLabels.View = System.Windows.Forms.View.Details;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabLogs);
            this.tabs.Controls.Add(this.tabLabels);
            this.tabs.Controls.Add(this.tabMounts);
            this.tabs.Controls.Add(this.tabPorts);
            this.tabs.Controls.Add(this.tabNetworks);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.ImageList = this.imageList1;
            this.tabs.ItemSize = new System.Drawing.Size(75, 45);
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(998, 636);
            this.tabs.TabIndex = 0;
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(this.txtLogs);
            this.tabLogs.ImageIndex = 0;
            this.tabLogs.Location = new System.Drawing.Point(4, 49);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Size = new System.Drawing.Size(990, 583);
            this.tabLogs.TabIndex = 3;
            this.tabLogs.Text = "Logs";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // txtLogs
            // 
            this.txtLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogs.Font = new System.Drawing.Font("Consolas", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogs.Location = new System.Drawing.Point(0, 0);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogs.Size = new System.Drawing.Size(990, 583);
            this.txtLogs.TabIndex = 3;
            // 
            // tabMounts
            // 
            this.tabMounts.Controls.Add(this.containerMounts);
            this.tabMounts.ImageIndex = 2;
            this.tabMounts.Location = new System.Drawing.Point(4, 49);
            this.tabMounts.Name = "tabMounts";
            this.tabMounts.Padding = new System.Windows.Forms.Padding(3);
            this.tabMounts.Size = new System.Drawing.Size(966, 599);
            this.tabMounts.TabIndex = 1;
            this.tabMounts.Text = "Mounts";
            this.tabMounts.UseVisualStyleBackColor = true;
            // 
            // containerMounts
            // 
            this.containerMounts.AllowColumnReorder = true;
            this.containerMounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.containerMounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            Type,
            Name,
            Source,
            Destination,
            Driver,
            Mode,
            RW,
            Propagation});
            this.containerMounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerMounts.FullRowSelect = true;
            this.containerMounts.GridLines = true;
            this.containerMounts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.containerMounts.HideSelection = false;
            this.containerMounts.Location = new System.Drawing.Point(3, 3);
            this.containerMounts.MultiSelect = false;
            this.containerMounts.Name = "containerMounts";
            this.containerMounts.ShowGroups = false;
            this.containerMounts.Size = new System.Drawing.Size(960, 593);
            this.containerMounts.TabIndex = 1;
            this.containerMounts.UseCompatibleStateImageBehavior = false;
            this.containerMounts.View = System.Windows.Forms.View.Details;
            this.containerMounts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.containerMounts_MouseDoubleClick);
            // 
            // tabPorts
            // 
            this.tabPorts.Controls.Add(this.containerPorts);
            this.tabPorts.ImageIndex = 3;
            this.tabPorts.Location = new System.Drawing.Point(4, 49);
            this.tabPorts.Name = "tabPorts";
            this.tabPorts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPorts.Size = new System.Drawing.Size(966, 599);
            this.tabPorts.TabIndex = 4;
            this.tabPorts.Text = "Ports";
            this.tabPorts.UseVisualStyleBackColor = true;
            // 
            // containerPorts
            // 
            this.containerPorts.AllowColumnReorder = true;
            this.containerPorts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.containerPorts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            IP,
            PrivatePort,
            PublicPort,
            TypeString});
            this.containerPorts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPorts.FullRowSelect = true;
            this.containerPorts.GridLines = true;
            this.containerPorts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.containerPorts.HideSelection = false;
            this.containerPorts.Location = new System.Drawing.Point(3, 3);
            this.containerPorts.MultiSelect = false;
            this.containerPorts.Name = "containerPorts";
            this.containerPorts.ShowGroups = false;
            this.containerPorts.Size = new System.Drawing.Size(960, 593);
            this.containerPorts.TabIndex = 1;
            this.containerPorts.UseCompatibleStateImageBehavior = false;
            this.containerPorts.View = System.Windows.Forms.View.Details;
            // 
            // tabNetworks
            // 
            this.tabNetworks.Controls.Add(this.networksTabs);
            this.tabNetworks.ImageIndex = 4;
            this.tabNetworks.Location = new System.Drawing.Point(4, 49);
            this.tabNetworks.Name = "tabNetworks";
            this.tabNetworks.Padding = new System.Windows.Forms.Padding(3);
            this.tabNetworks.Size = new System.Drawing.Size(990, 583);
            this.tabNetworks.TabIndex = 5;
            this.tabNetworks.Text = "Networks";
            this.tabNetworks.UseVisualStyleBackColor = true;
            // 
            // networksTabs
            // 
            this.networksTabs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.networksTabs.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.networksTabs.Controls.Add(this.tabPage1);
            this.networksTabs.Controls.Add(this.tabPage2);
            this.networksTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networksTabs.Location = new System.Drawing.Point(3, 3);
            this.networksTabs.Multiline = true;
            this.networksTabs.Name = "networksTabs";
            this.networksTabs.SelectedIndex = 0;
            this.networksTabs.Size = new System.Drawing.Size(984, 577);
            this.networksTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(952, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "logs.png");
            this.imageList1.Images.SetKeyName(1, "label.png");
            this.imageList1.Images.SetKeyName(2, "mount.png");
            this.imageList1.Images.SetKeyName(3, "port.png");
            this.imageList1.Images.SetKeyName(4, "network.png");
            // 
            // DockerContainerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabs);
            this.Name = "DockerContainerDetails";
            this.Size = new System.Drawing.Size(998, 636);
            this.tabLabels.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.tabLogs.ResumeLayout(false);
            this.tabLogs.PerformLayout();
            this.tabMounts.ResumeLayout(false);
            this.tabPorts.ResumeLayout(false);
            this.tabNetworks.ResumeLayout(false);
            this.networksTabs.ResumeLayout(false);
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TabControl tabs;
      private System.Windows.Forms.TabPage tabMounts;
      private System.Windows.Forms.ListView containerLabels;
      private System.Windows.Forms.ListView containerMounts;
      private System.Windows.Forms.TabPage tabLogs;
      private System.Windows.Forms.TextBox txtLogs;
      private System.Windows.Forms.TabPage tabPorts;
      private System.Windows.Forms.ListView containerPorts;
      private System.Windows.Forms.TabPage tabLabels;
      private System.Windows.Forms.ImageList imageList1;
      private System.Windows.Forms.TabPage tabNetworks;
      private System.Windows.Forms.TabControl networksTabs;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TabPage tabPage2;
   }
}
