namespace SMS
{
    partial class ModelingResultForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelingResultForm));
            this.frequencyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.countLabel = new System.Windows.Forms.Label();
            this.countMinLabel = new System.Windows.Forms.Label();
            this.avgLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.relativeFrequencyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.changeoverChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyChart)).BeginInit();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relativeFrequencyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeoverChart)).BeginInit();
            this.SuspendLayout();
            // 
            // frequencyChart
            // 
            chartArea1.Name = "ChartArea1";
            this.frequencyChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.frequencyChart.Legends.Add(legend1);
            this.frequencyChart.Location = new System.Drawing.Point(12, 189);
            this.frequencyChart.Name = "frequencyChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.frequencyChart.Series.Add(series1);
            this.frequencyChart.Size = new System.Drawing.Size(364, 246);
            this.frequencyChart.TabIndex = 0;
            this.frequencyChart.Text = "chart1";
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.countLabel);
            this.panelInfo.Controls.Add(this.countMinLabel);
            this.panelInfo.Controls.Add(this.avgLabel);
            this.panelInfo.Controls.Add(this.minLabel);
            this.panelInfo.Controls.Add(this.maxLabel);
            this.panelInfo.Location = new System.Drawing.Point(12, 12);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(364, 171);
            this.panelInfo.TabIndex = 1;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(15, 9);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(103, 13);
            this.countLabel.TabIndex = 4;
            this.countLabel.Text = "Число испытаний: ";
            // 
            // countMinLabel
            // 
            this.countMinLabel.AutoSize = true;
            this.countMinLabel.Location = new System.Drawing.Point(13, 102);
            this.countMinLabel.Name = "countMinLabel";
            this.countMinLabel.Size = new System.Drawing.Size(294, 13);
            this.countMinLabel.TabIndex = 3;
            this.countMinLabel.Text = "Число реализаций с минимальным количеством шагов:";
            // 
            // avgLabel
            // 
            this.avgLabel.AutoSize = true;
            this.avgLabel.Location = new System.Drawing.Point(15, 79);
            this.avgLabel.Name = "avgLabel";
            this.avgLabel.Size = new System.Drawing.Size(122, 13);
            this.avgLabel.TabIndex = 2;
            this.avgLabel.Text = "Среднее число шагов: ";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(15, 55);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(150, 13);
            this.minLabel.TabIndex = 1;
            this.minLabel.Text = "Минимальное число шагов: ";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(15, 32);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(156, 13);
            this.maxLabel.TabIndex = 0;
            this.maxLabel.Text = "Максимальное число шагов: ";
            // 
            // relativeFrequencyChart
            // 
            this.relativeFrequencyChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.relativeFrequencyChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.relativeFrequencyChart.Legends.Add(legend2);
            this.relativeFrequencyChart.Location = new System.Drawing.Point(382, 12);
            this.relativeFrequencyChart.Name = "relativeFrequencyChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.relativeFrequencyChart.Series.Add(series2);
            this.relativeFrequencyChart.Size = new System.Drawing.Size(406, 423);
            this.relativeFrequencyChart.TabIndex = 2;
            this.relativeFrequencyChart.Text = "chart1";
            // 
            // changeoverChart
            // 
            this.changeoverChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.changeoverChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.changeoverChart.Legends.Add(legend3);
            this.changeoverChart.Location = new System.Drawing.Point(12, 441);
            this.changeoverChart.Name = "changeoverChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.changeoverChart.Series.Add(series3);
            this.changeoverChart.Size = new System.Drawing.Size(776, 291);
            this.changeoverChart.TabIndex = 3;
            this.changeoverChart.Text = "chart1";
            // 
            // ModelingResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.changeoverChart);
            this.Controls.Add(this.relativeFrequencyChart);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.frequencyChart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModelingResultForm";
            this.Text = "Результат моделирования";
            ((System.ComponentModel.ISupportInitialize)(this.frequencyChart)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relativeFrequencyChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeoverChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart frequencyChart;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label countMinLabel;
        private System.Windows.Forms.Label avgLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart relativeFrequencyChart;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart changeoverChart;
    }
}