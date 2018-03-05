namespace Mart
{
    partial class USubSold
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdShowChart = new System.Windows.Forms.RadioButton();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.rdShowTable = new System.Windows.Forms.RadioButton();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.pContainer = new System.Windows.Forms.Panel();
            this.tlbChart = new System.Windows.Forms.TableLayoutPanel();
            this.chartSoldBar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSoldPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.pContainer.SuspendLayout();
            this.tlbChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSoldBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSoldPie)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pContainer, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(657, 469);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.rdShowChart);
            this.panel1.Controls.Add(this.pbRefresh);
            this.panel1.Controls.Add(this.rdShowTable);
            this.panel1.Controls.Add(this.pbBack);
            this.panel1.Controls.Add(this.cboYear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 30);
            this.panel1.TabIndex = 2;
            // 
            // rdShowChart
            // 
            this.rdShowChart.AutoSize = true;
            this.rdShowChart.Checked = true;
            this.rdShowChart.Location = new System.Drawing.Point(209, 7);
            this.rdShowChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdShowChart.Name = "rdShowChart";
            this.rdShowChart.Size = new System.Drawing.Size(50, 17);
            this.rdShowChart.TabIndex = 8;
            this.rdShowChart.TabStop = true;
            this.rdShowChart.Text = "Chart";
            this.rdShowChart.UseVisualStyleBackColor = true;
            // 
            // pbRefresh
            // 
            this.pbRefresh.Image = global::Mart.Properties.Resources.Restart_48;
            this.pbRefresh.Location = new System.Drawing.Point(34, 1);
            this.pbRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(32, 27);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefresh.TabIndex = 11;
            this.pbRefresh.TabStop = false;
            // 
            // rdShowTable
            // 
            this.rdShowTable.AutoSize = true;
            this.rdShowTable.Location = new System.Drawing.Point(269, 7);
            this.rdShowTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdShowTable.Name = "rdShowTable";
            this.rdShowTable.Size = new System.Drawing.Size(52, 17);
            this.rdShowTable.TabIndex = 7;
            this.rdShowTable.Text = "Table";
            this.rdShowTable.UseVisualStyleBackColor = true;
            // 
            // pbBack
            // 
            this.pbBack.Image = global::Mart.Properties.Resources.GoBack_48;
            this.pbBack.Location = new System.Drawing.Point(2, 1);
            this.pbBack.Margin = new System.Windows.Forms.Padding(0);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(32, 27);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 10;
            this.pbBack.TabStop = false;
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(69, 5);
            this.cboYear.Margin = new System.Windows.Forms.Padding(0);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(130, 21);
            this.cboYear.TabIndex = 9;
            // 
            // pContainer
            // 
            this.pContainer.Controls.Add(this.tlbChart);
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(0, 30);
            this.pContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(657, 439);
            this.pContainer.TabIndex = 3;
            // 
            // tlbChart
            // 
            this.tlbChart.ColumnCount = 1;
            this.tlbChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbChart.Controls.Add(this.chartSoldBar, 0, 0);
            this.tlbChart.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tlbChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbChart.Location = new System.Drawing.Point(0, 0);
            this.tlbChart.Margin = new System.Windows.Forms.Padding(0);
            this.tlbChart.Name = "tlbChart";
            this.tlbChart.RowCount = 2;
            this.tlbChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlbChart.Size = new System.Drawing.Size(657, 439);
            this.tlbChart.TabIndex = 2;
            // 
            // chartSoldBar
            // 
            this.chartSoldBar.BorderlineWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chartSoldBar.ChartAreas.Add(chartArea1);
            this.chartSoldBar.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartSoldBar.Legends.Add(legend1);
            this.chartSoldBar.Location = new System.Drawing.Point(0, 0);
            this.chartSoldBar.Margin = new System.Windows.Forms.Padding(0);
            this.chartSoldBar.Name = "chartSoldBar";
            this.chartSoldBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.CustomProperties = "DrawSideBySide=True, PointWidth=0.5";
            series1.Label = "#VALY";
            series1.LabelToolTip = "#VALX (#PERCENT)";
            series1.Legend = "Legend1";
            series1.Name = "SoldYear";
            series1.ShadowColor = System.Drawing.Color.Transparent;
            series1.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.Red;
            series1.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Transparent;
            series1.ToolTip = "#VALX (#PERCENT)";
            this.chartSoldBar.Series.Add(series1);
            this.chartSoldBar.Size = new System.Drawing.Size(657, 219);
            this.chartSoldBar.TabIndex = 2;
            this.chartSoldBar.Text = "chart3";
            title1.Name = "SoldTitle";
            title1.Text = "Anually Sold Report";
            this.chartSoldBar.Titles.Add(title1);
            // 
            // chartSoldPie
            // 
            this.chartSoldPie.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartSoldPie.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chartSoldPie.BorderSkin.BorderWidth = 0;
            this.chartSoldPie.BorderSkin.PageColor = System.Drawing.Color.Gray;
            chartArea2.Name = "ChartArea1";
            this.chartSoldPie.ChartAreas.Add(chartArea2);
            this.chartSoldPie.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartSoldPie.Legends.Add(legend2);
            this.chartSoldPie.Location = new System.Drawing.Point(0, 0);
            this.chartSoldPie.Margin = new System.Windows.Forms.Padding(0);
            this.chartSoldPie.Name = "chartSoldPie";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.CustomProperties = "PieLineColor=Gray, CollectedColor=Transparent, LabelsHorizontalLineSize=2, PieLab" +
    "elStyle=Outside";
            series2.EmptyPointStyle.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series2.EmptyPointStyle.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            series2.Label = "#VALY (#PERCENT)";
            series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series2.LabelToolTip = "#VALX (#PERCENT)";
            series2.Legend = "Legend1";
            series2.LegendText = "#VALX";
            series2.LegendToolTip = "#VALY (#PERCENT)";
            series2.Name = "SoldYear";
            series2.ToolTip = "#VALX (#PERCENT)";
            this.chartSoldPie.Series.Add(series2);
            this.chartSoldPie.Size = new System.Drawing.Size(657, 220);
            this.chartSoldPie.TabIndex = 0;
            this.chartSoldPie.Text = "chart1";
            title2.Name = "Sold Year";
            title2.Text = "Anually Sold Report";
            this.chartSoldPie.Titles.Add(title2);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.chartSoldPie, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 219);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(657, 220);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // USubSold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "USubSold";
            this.Size = new System.Drawing.Size(657, 469);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.pContainer.ResumeLayout(false);
            this.tlbChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSoldBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSoldPie)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdShowChart;
        private System.Windows.Forms.PictureBox pbRefresh;
        private System.Windows.Forms.RadioButton rdShowTable;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.TableLayoutPanel tlbChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSoldBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSoldPie;
    }
}
