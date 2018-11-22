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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.containerLabels = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Stats = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Logs = new System.Windows.Forms.TabPage();
            this.richLogs = new System.Windows.Forms.RichTextBox();
            this.Mounts = new System.Windows.Forms.TabPage();
            this.containerMounts = new System.Windows.Forms.ListView();
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
            this.Stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.Logs.SuspendLayout();
            this.Mounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // Labels
            // 
            Labels.Controls.Add(this.containerLabels);
            Labels.Location = new System.Drawing.Point(4, 25);
            Labels.Margin = new System.Windows.Forms.Padding(2);
            Labels.Name = "Labels";
            Labels.Padding = new System.Windows.Forms.Padding(2);
            Labels.Size = new System.Drawing.Size(700, 406);
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
            this.containerLabels.Location = new System.Drawing.Point(2, 2);
            this.containerLabels.Margin = new System.Windows.Forms.Padding(2);
            this.containerLabels.MultiSelect = false;
            this.containerLabels.Name = "containerLabels";
            this.containerLabels.ShowGroups = false;
            this.containerLabels.Size = new System.Drawing.Size(696, 402);
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
            this.tabControl1.Controls.Add(this.Stats);
            this.tabControl1.Controls.Add(this.Logs);
            this.tabControl1.Controls.Add(Labels);
            this.tabControl1.Controls.Add(this.Mounts);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(708, 435);
            this.tabControl1.TabIndex = 0;
            // 
            // Stats
            // 
            this.Stats.Controls.Add(this.chart1);
            this.Stats.Location = new System.Drawing.Point(4, 25);
            this.Stats.Margin = new System.Windows.Forms.Padding(2);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(700, 406);
            this.Stats.TabIndex = 2;
            this.Stats.Text = "Stats";
            this.Stats.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.BorderColor = System.Drawing.Color.Maroon;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.ForeColor = System.Drawing.Color.Gray;
            legend1.HeaderSeparatorColor = System.Drawing.Color.Gray;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.Maroon;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(700, 406);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Logs
            // 
            this.Logs.Controls.Add(this.richLogs);
            this.Logs.Location = new System.Drawing.Point(4, 25);
            this.Logs.Margin = new System.Windows.Forms.Padding(2);
            this.Logs.Name = "Logs";
            this.Logs.Size = new System.Drawing.Size(700, 406);
            this.Logs.TabIndex = 3;
            this.Logs.Text = "Logs";
            this.Logs.UseVisualStyleBackColor = true;
            // 
            // richLogs
            // 
            this.richLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richLogs.Location = new System.Drawing.Point(0, 0);
            this.richLogs.Margin = new System.Windows.Forms.Padding(2);
            this.richLogs.Name = "richLogs";
            this.richLogs.ReadOnly = true;
            this.richLogs.Size = new System.Drawing.Size(700, 406);
            this.richLogs.TabIndex = 0;
            this.richLogs.Text = "";
            // 
            // Mounts
            // 
            this.Mounts.Controls.Add(this.containerMounts);
            this.Mounts.Location = new System.Drawing.Point(4, 25);
            this.Mounts.Margin = new System.Windows.Forms.Padding(2);
            this.Mounts.Name = "Mounts";
            this.Mounts.Padding = new System.Windows.Forms.Padding(2);
            this.Mounts.Size = new System.Drawing.Size(700, 406);
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
            this.containerMounts.Location = new System.Drawing.Point(2, 2);
            this.containerMounts.Margin = new System.Windows.Forms.Padding(2);
            this.containerMounts.MultiSelect = false;
            this.containerMounts.Name = "containerMounts";
            this.containerMounts.ShowGroups = false;
            this.containerMounts.Size = new System.Drawing.Size(696, 402);
            this.containerMounts.TabIndex = 1;
            this.containerMounts.UseCompatibleStateImageBehavior = false;
            this.containerMounts.View = System.Windows.Forms.View.Details;
            this.containerMounts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.containerMounts_MouseDoubleClick);
            // 
            // DockerContainerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DockerContainerDetails";
            this.Size = new System.Drawing.Size(708, 435);
            Labels.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Stats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.Logs.ResumeLayout(false);
            this.Mounts.ResumeLayout(false);
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage Mounts;
      private System.Windows.Forms.ListView containerLabels;
      private System.Windows.Forms.ListView containerMounts;
      private System.Windows.Forms.TabPage Stats;
      private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
      private System.Windows.Forms.TabPage Logs;
      private System.Windows.Forms.RichTextBox richLogs;
   }
}
