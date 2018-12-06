using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Docker.DotNet.Models;

namespace DockerExplorer.WinForms
{
   public partial class NetworkDetails : UserControl
   {
      public NetworkDetails()
      {
         InitializeComponent();
      }

      public EndpointSettings EndpointSettings
      {
         set
         {
            txtNetworkID.Text = value.NetworkID;
            txtEndpointID.Text = value.EndpointID;
            txtIPAddress.Text = value.IPAddress;
         }
      }
   }
}
