namespace CapaPresentacion.Vistas.Informes
{
    partial class Fver_informes
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
            this.label10 = new System.Windows.Forms.Label();
            this.chartproductosporcategoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartmaselegidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartproductosporcategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartmaselegidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(555, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 37);
            this.label10.TabIndex = 84;
            this.label10.Text = "Informes";
            // 
            // chartproductosporcategoria
            // 
            this.chartproductosporcategoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chartproductosporcategoria.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartproductosporcategoria.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartproductosporcategoria.Legends.Add(legend1);
            this.chartproductosporcategoria.Location = new System.Drawing.Point(12, 292);
            this.chartproductosporcategoria.Name = "chartproductosporcategoria";
            this.chartproductosporcategoria.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartproductosporcategoria.Series.Add(series1);
            this.chartproductosporcategoria.Size = new System.Drawing.Size(379, 361);
            this.chartproductosporcategoria.TabIndex = 85;
            this.chartproductosporcategoria.Text = "chart1";
            // 
            // chartmaselegidos
            // 
            chartArea2.Name = "ChartArea1";
            this.chartmaselegidos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartmaselegidos.Legends.Add(legend2);
            this.chartmaselegidos.Location = new System.Drawing.Point(397, 292);
            this.chartmaselegidos.Name = "chartmaselegidos";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartmaselegidos.Series.Add(series2);
            this.chartmaselegidos.Size = new System.Drawing.Size(432, 361);
            this.chartmaselegidos.TabIndex = 86;
            this.chartmaselegidos.Text = "chart2";
            // 
            // Fver_informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1301, 983);
            this.Controls.Add(this.chartmaselegidos);
            this.Controls.Add(this.chartproductosporcategoria);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fver_informes";
            this.Text = "Fver_informes";
            this.Load += new System.EventHandler(this.Fver_informes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartproductosporcategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartmaselegidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartproductosporcategoria;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartmaselegidos;
    }
}