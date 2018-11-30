using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using NetBox.Extensions;

namespace DockerExplorer.WinForms
{
   public partial class AboutForm : Form
   {
      public AboutForm()
      {
         InitializeComponent();

         lblVersion.Text = typeof(AboutForm).FileVersion().ToString();
      }

      private void linkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         Process.Start("https://github.com/aloneguid/docker-explorer-windows");
      }

      private void linkTwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         Process.Start("https://twitter.com/aloneguid");
      }
   }
}
