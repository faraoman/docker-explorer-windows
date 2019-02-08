using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DockerExplorer.WinForms;
using NetBox.Extensions;

namespace DockerExplorer
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();

         this.AutoScaleMode = AutoScaleMode.Dpi;
         this.Font = SystemFonts.MessageBoxFont;

         //set version number in title
         this.Text = $"{Text} v{typeof(MainForm).FileVersion()}";
      }

      private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
      {
         new AboutForm().ShowDialog(this);
      }

      private void exitToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private void reportAnIssueToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Process.Start("https://github.com/aloneguid/docker-explorer-windows/issues/new");
      }
   }
}
