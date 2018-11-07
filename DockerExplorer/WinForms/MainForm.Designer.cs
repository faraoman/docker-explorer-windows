namespace DockerExplorer
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dockerServerControl1 = new DockerExplorer.DockerServerControl();
            this.SuspendLayout();
            // 
            // dockerServerControl1
            // 
            this.dockerServerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockerServerControl1.Location = new System.Drawing.Point(0, 0);
            this.dockerServerControl1.Name = "dockerServerControl1";
            this.dockerServerControl1.Size = new System.Drawing.Size(1605, 900);
            this.dockerServerControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 900);
            this.Controls.Add(this.dockerServerControl1);
            this.Name = "MainForm";
            this.Text = "Docker Explorer";
            this.ResumeLayout(false);

        }

      #endregion

      private DockerServerControl dockerServerControl1;
   }
}

