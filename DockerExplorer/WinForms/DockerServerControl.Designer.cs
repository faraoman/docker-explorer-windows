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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.refreshToolButton = new System.Windows.Forms.ToolStripButton();
            this.comboUpdateInterval = new System.Windows.Forms.ToolStripComboBox();
            this.dockerContainers1 = new DockerExplorer.WinForms.DockerContainers();
            this.dockerImages1 = new DockerExplorer.WinForms.DockerImages();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 50);
            this.tabControl1.Location = new System.Drawing.Point(0, 47);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1173, 709);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dockerContainers1);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1165, 651);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Containers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dockerImages1);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1165, 651);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Images";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "image.png");
            this.imageList1.Images.SetKeyName(1, "container.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolButton,
            this.comboUpdateInterval});
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
            // dockerContainers1
            // 
            this.dockerContainers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockerContainers1.Location = new System.Drawing.Point(3, 3);
            this.dockerContainers1.Name = "dockerContainers1";
            this.dockerContainers1.Size = new System.Drawing.Size(1159, 645);
            this.dockerContainers1.TabIndex = 0;
            // 
            // dockerImages1
            // 
            this.dockerImages1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockerImages1.Location = new System.Drawing.Point(3, 3);
            this.dockerImages1.Name = "dockerImages1";
            this.dockerImages1.Size = new System.Drawing.Size(1159, 645);
            this.dockerImages1.TabIndex = 0;
            // 
            // DockerServerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DockerServerControl";
            this.Size = new System.Drawing.Size(1173, 756);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TabPage tabPage2;
      private WinForms.DockerContainers dockerContainers1;
      private WinForms.DockerImages dockerImages1;
      private System.Windows.Forms.ImageList imageList1;
      private System.Windows.Forms.ToolStrip toolStrip1;
      private System.Windows.Forms.ToolStripButton refreshToolButton;
      private System.Windows.Forms.ToolStripComboBox comboUpdateInterval;
   }
}
