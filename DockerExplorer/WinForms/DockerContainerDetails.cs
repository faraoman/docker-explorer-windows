using System.Collections.Generic;
using System.Windows.Forms;
using DockerExplorer.Model;
using Docker.DotNet.Models;
using System.Diagnostics;
using DockerExplorer.Presenters;
using System;
using System.Threading;
using NetBox.Extensions;
using System.Linq;

namespace DockerExplorer.WinForms
{
   public partial class DockerContainerDetails : UserControl, IProgress<ContainerStatsResponse>, IProgress<string>
   {
      private CancellationTokenSource _cts = new CancellationTokenSource();
      private int _logLinesCount;

      public DockerContainerDetails()
      {
         InitializeComponent();
      }

      internal DockerPresenter Presenter { get; set; }

      public DockerContainer DockerContainer
      {
         set
         {
            // set labels
            containerLabels.Items.Clear();
            foreach (KeyValuePair<string, string> label in value.Labels)
            {
               containerLabels.Items.Add(
                  new ListViewItem(new[] { label.Key, label.Value }, 0));
            }
            containerLabels.AutoAlign();
            tabLabels.Text = $"Labels ({value.Labels.Count})";

            //set mounts
            containerMounts.Items.Clear();
            foreach(MountPoint mount in value.Mounts)
            {
               containerMounts.Items.Add(
                  new ListViewItem(new[]
                  {
                     mount.Type,
                     mount.Name,
                     mount.Source,
                     mount.Destination,
                     mount.Driver,
                     mount.Mode,
                     mount.RW.ToString(),
                     mount.Propagation
                  }, 0)
                  { Tag = mount });
            }
            containerMounts.AutoAlign();
            tabMounts.Text = $"Mounts ({value.Mounts.Count})";

            //set ports
            containerPorts.Items.Clear();
            foreach(Port port in value.Ports)
            {
               containerPorts.Items.Add(
                  new ListViewItem(new[]
                  {
                     port.IP,
                     port.PrivatePort.ToString(),
                     port.PublicPort.ToString(),
                     port.Type
                  }));
            }
            containerPorts.AutoAlign();
            tabPorts.Text = $"Ports ({value.Ports.Count})";

            //set network settings
            RenderNetworks(value);

            //clear the rest
            txtLogs.Clear();
            _logLinesCount = 0;

            //listen for updates
            if(_cts != null)
            {
               _cts.Cancel();
               _cts = new CancellationTokenSource();
            }
            Presenter.GetContainerDetailsAsync(value.Id, this, _cts.Token).Forget();
            Presenter.GetContainerLogs(value.Id, this, _cts.Token).Forget();
         }
      }

      private void RenderNetworks(DockerContainer container)
      {
         containerNetworks.Items.Clear();

         foreach (KeyValuePair<string, EndpointSettings> network in container.NetworkSettings)
         {
            containerNetworks.Items.Add(
               new ListViewItem(new[]
               {
                  network.Key,
                  $"{network.Value.IPAddress} ({network.Value.IPPrefixLen})",
                  network.Value.NetworkID,
                  network.Value.EndpointID,
                  network.Value.MacAddress
               }));
         }
         containerNetworks.AutoAlign();
         tabNetworks.Text = $"Networks ({container.NetworkSettings.Count})";
      }

      private void containerMounts_MouseDoubleClick(object sender, MouseEventArgs e)
      {
         if (containerMounts.SelectedItems.Count == 0)
            return;

         MountPoint mountPoint = containerMounts.Items[containerMounts.SelectedIndices[0]].Tag as MountPoint;

         string path = mountPoint.Source;

         Process.Start(path);
      }

      double _prevCpu = 0;
      double _prevSystem = 0;

      public void Report(ContainerStatsResponse value)
      {
         //see https://stackoverflow.com/questions/30271942/get-docker-container-cpu-usage-as-percentage

         double cpu = 0;
         //double cpu2 = 0;
         double cpuDelta = value.CPUStats.CPUUsage.TotalUsage - _prevCpu;
         double systemDelta = value.CPUStats.SystemUsage - _prevSystem;

         if(cpuDelta > 0 && systemDelta > 0)
         {
            cpu = (cpuDelta / systemDelta) * value.CPUStats.CPUUsage.PercpuUsage.Count * 100;
         }

         if(cpuDelta > 0)
         {
            //cpu2 = cpuDelta * value.CPUStats.CPUUsage.PercpuUsage.Count * 100.0;
         }

         _prevCpu = value.CPUStats.CPUUsage.TotalUsage;
         _prevSystem = value.CPUStats.SystemUsage;

         //lblCpu.Text = $"{cpu} %";

         //txtLogs.AppendText($"cpud: {cpuDelta}, sysd: {systemDelta}, cpu: {cpu}, cpu2: {cpu2}");
         //txtLogs.AppendText(Environment.NewLine);
      }

      public void Report(string value)
      {
         //convert to printable string
         char[] pChars = value.ToCharArray().Where(c => !char.IsControl(c) || char.IsWhiteSpace(c)).ToArray();
         string pValue = new string(pChars, 0, pChars.Length);
         pValue += Environment.NewLine;

         txtLogs.AppendText(pValue);
         _logLinesCount += 1;

         tabLogs.Text = $"Logs ({_logLinesCount})";
      }
   }
}
