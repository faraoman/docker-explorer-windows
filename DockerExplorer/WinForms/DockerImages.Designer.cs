namespace DockerExplorer.WinForms
{
   partial class DockerImages
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Splitter splitter2;
            this.treeDockerImages = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtParentId = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            splitter2 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(64, 136);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 25);
            label4.TabIndex = 6;
            label4.Text = "Tags:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(70, 94);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(57, 25);
            label3.TabIndex = 4;
            label3.Text = "Size:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(28, 52);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 25);
            label2.TabIndex = 1;
            label2.Text = "Parent ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(90, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(37, 25);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // splitter2
            // 
            splitter2.Location = new System.Drawing.Point(484, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new System.Drawing.Size(7, 1068);
            splitter2.TabIndex = 4;
            splitter2.TabStop = false;
            // 
            // treeDockerImages
            // 
            this.treeDockerImages.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeDockerImages.HideSelection = false;
            this.treeDockerImages.Location = new System.Drawing.Point(0, 0);
            this.treeDockerImages.Name = "treeDockerImages";
            this.treeDockerImages.Size = new System.Drawing.Size(484, 1068);
            this.treeDockerImages.TabIndex = 1;
            this.treeDockerImages.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeDockerImages_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.txtTags);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(this.txtSize);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.txtParentId);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(491, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 1068);
            this.panel1.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 1068);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // txtTags
            // 
            this.txtTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTags.Location = new System.Drawing.Point(133, 136);
            this.txtTags.Multiline = true;
            this.txtTags.Name = "txtTags";
            this.txtTags.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTags.Size = new System.Drawing.Size(764, 215);
            this.txtTags.TabIndex = 7;
            // 
            // txtSize
            // 
            this.txtSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSize.Location = new System.Drawing.Point(134, 94);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(764, 29);
            this.txtSize.TabIndex = 5;
            // 
            // txtParentId
            // 
            this.txtParentId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParentId.Location = new System.Drawing.Point(133, 52);
            this.txtParentId.Name = "txtParentId";
            this.txtParentId.Size = new System.Drawing.Size(764, 29);
            this.txtParentId.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.Location = new System.Drawing.Point(134, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(764, 29);
            this.txtId.TabIndex = 2;
            // 
            // DockerImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(splitter2);
            this.Controls.Add(this.treeDockerImages);
            this.Name = "DockerImages";
            this.Size = new System.Drawing.Size(1407, 1068);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TreeView treeDockerImages;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.TextBox txtTags;
      private System.Windows.Forms.TextBox txtSize;
      private System.Windows.Forms.TextBox txtParentId;
      private System.Windows.Forms.TextBox txtId;
      private System.Windows.Forms.Splitter splitter1;
   }
}
