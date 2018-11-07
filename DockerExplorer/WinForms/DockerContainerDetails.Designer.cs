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
            System.Windows.Forms.TabPage tabPage1;
            System.Windows.Forms.ColumnHeader columnHeader1;
            System.Windows.Forms.ColumnHeader columnHeader2;
            this.containerLabels = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            tabPage1 = new System.Windows.Forms.TabPage();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(this.containerLabels);
            tabPage1.Location = new System.Drawing.Point(4, 33);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(966, 616);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Labels";
            tabPage1.UseVisualStyleBackColor = true;
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
            this.containerLabels.Size = new System.Drawing.Size(960, 610);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(974, 653);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(966, 616);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DockerContainerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "DockerContainerDetails";
            this.Size = new System.Drawing.Size(974, 653);
            tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.ListView containerLabels;
   }
}
