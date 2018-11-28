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
            System.Windows.Forms.TabPage Labels;
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
            this.containerLabels = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Logs = new System.Windows.Forms.TabPage();
            this.richLogs = new System.Windows.Forms.RichTextBox();
            this.Mounts = new System.Windows.Forms.TabPage();
            this.containerMounts = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCpuUsage = new System.Windows.Forms.Label();
            Labels = new System.Windows.Forms.TabPage();
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
            Labels.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Logs.SuspendLayout();
            this.Mounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // Labels
            // 
            Labels.Controls.Add(this.containerLabels);
            Labels.Location = new System.Drawing.Point(4, 33);
            Labels.Name = "Labels";
            Labels.Padding = new System.Windows.Forms.Padding(3);
            Labels.Size = new System.Drawing.Size(966, 615);
            Labels.TabIndex = 0;
            Labels.Text = "Labels";
            Labels.UseVisualStyleBackColor = true;
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
            this.containerLabels.Size = new System.Drawing.Size(960, 609);
            this.containerLabels.TabIndex = 0;
            this.containerLabels.UseCompatibleStateImageBehavior = false;
            this.containerLabels.View = System.Windows.Forms.View.Details;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Logs);
            this.tabControl1.Controls.Add(Labels);
            this.tabControl1.Controls.Add(this.Mounts);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(974, 652);
            this.tabControl1.TabIndex = 0;
            // 
            // Logs
            // 
            this.Logs.Controls.Add(this.labelCpuUsage);
            this.Logs.Controls.Add(this.label1);
            this.Logs.Controls.Add(this.richLogs);
            this.Logs.Location = new System.Drawing.Point(4, 33);
            this.Logs.Name = "Logs";
            this.Logs.Size = new System.Drawing.Size(966, 615);
            this.Logs.TabIndex = 3;
            this.Logs.Text = "Logs";
            this.Logs.UseVisualStyleBackColor = true;
            // 
            // richLogs
            // 
            this.richLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richLogs.Location = new System.Drawing.Point(0, 116);
            this.richLogs.Name = "richLogs";
            this.richLogs.ReadOnly = true;
            this.richLogs.Size = new System.Drawing.Size(966, 499);
            this.richLogs.TabIndex = 0;
            this.richLogs.Text = "";
            // 
            // Mounts
            // 
            this.Mounts.Controls.Add(this.containerMounts);
            this.Mounts.Location = new System.Drawing.Point(4, 33);
            this.Mounts.Name = "Mounts";
            this.Mounts.Padding = new System.Windows.Forms.Padding(3);
            this.Mounts.Size = new System.Drawing.Size(966, 615);
            this.Mounts.TabIndex = 1;
            this.Mounts.Text = "Mounts";
            this.Mounts.UseVisualStyleBackColor = true;
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
            this.containerMounts.Size = new System.Drawing.Size(960, 609);
            this.containerMounts.TabIndex = 1;
            this.containerMounts.UseCompatibleStateImageBehavior = false;
            this.containerMounts.View = System.Windows.Forms.View.Details;
            this.containerMounts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.containerMounts_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPU:";
            // 
            // labelCpuUsage
            // 
            this.labelCpuUsage.AutoSize = true;
            this.labelCpuUsage.Location = new System.Drawing.Point(453, 295);
            this.labelCpuUsage.Name = "labelCpuUsage";
            this.labelCpuUsage.Size = new System.Drawing.Size(41, 25);
            this.labelCpuUsage.TabIndex = 2;
            this.labelCpuUsage.Text = "0%";
            // 
            // DockerContainerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "DockerContainerDetails";
            this.Size = new System.Drawing.Size(974, 652);
            Labels.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Logs.ResumeLayout(false);
            this.Logs.PerformLayout();
            this.Mounts.ResumeLayout(false);
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage Mounts;
      private System.Windows.Forms.ListView containerLabels;
      private System.Windows.Forms.ListView containerMounts;
      private System.Windows.Forms.TabPage Logs;
      private System.Windows.Forms.RichTextBox richLogs;
      private System.Windows.Forms.Label labelCpuUsage;
      private System.Windows.Forms.Label label1;
   }
}
