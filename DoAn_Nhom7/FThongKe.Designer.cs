namespace DoAn_Nhom7
{
    partial class FThongKe
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
            this.chartTyLeNamNu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTyLeNamNu)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTyLeNamNu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTyLeNamNu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTyLeNamNu.Legends.Add(legend1);
            this.chartTyLeNamNu.Location = new System.Drawing.Point(123, 39);
            this.chartTyLeNamNu.Name = "chartTyLeNamNu";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Tỷ Lệ Nam Nữ";
            this.chartTyLeNamNu.Series.Add(series1);
            this.chartTyLeNamNu.Size = new System.Drawing.Size(438, 300);
            this.chartTyLeNamNu.TabIndex = 0;
            this.chartTyLeNamNu.Text = "Tỷ lệ nam nữ";
            // 
            // FThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartTyLeNamNu);
            this.Name = "FThongKe";
            this.Text = "FThongKe";
            this.Load += new System.EventHandler(this.FThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTyLeNamNu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTyLeNamNu;
    }
}