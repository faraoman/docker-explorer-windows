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
            this.containersList = new System.Windows.Forms.ListView();
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dockerContainerDetails = new DockerExplorer.WinForms.DockerContainerDetails();
            ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Image = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // containersList
            // 
            this.containersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.containersList.CheckBoxes = true;
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
            this.containersList.Location = new System.Drawing.Point(0, 0);
            this.containersList.MultiSelect = false;
            this.containersList.Name = "containersList";
            this.containersList.ShowItemToolTips = true;
            this.containersList.Size = new System.Drawing.Size(1065, 268);
            this.containersList.TabIndex = 5;
            this.containersList.UseCompatibleStateImageBehavior = false;
            this.containersList.View = System.Windows.Forms.View.Details;
            this.containersList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.containersList_ItemChecked);
            this.containersList.SelectedIndexChanged += new System.EventHandler(this.containersList_SelectedIndexChanged);
            // 
            // Status
            // 
            this.Status.Text = "Status";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 268);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1065, 6);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // dockerContainerDetails
            // 
            this.dockerContainerDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockerContainerDetails.Location = new System.Drawing.Point(0, 268);
            this.dockerContainerDetails.Name = "dockerContainerDetails";
            this.dockerContainerDetails.Size = new System.Drawing.Size(1065, 569);
            this.dockerContainerDetails.TabIndex = 6;
            // 
            // DockerContainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dockerContainerDetails);
            this.Controls.Add(this.containersList);
            this.Name = "DockerContainers";
            this.Size = new System.Drawing.Size(1065, 837);
            this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.ListView containersList;
      private System.Windows.Forms.ColumnHeader Status;
      private DockerContainerDetails dockerContainerDetails;
      private System.Windows.Forms.Splitter splitter1;
   }
}
