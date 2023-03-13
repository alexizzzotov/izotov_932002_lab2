
namespace lab2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LblDollar = new System.Windows.Forms.Label();
            this.EdDollar = new System.Windows.Forms.NumericUpDown();
            this.EdEuro = new System.Windows.Forms.NumericUpDown();
            this.LblEuro = new System.Windows.Forms.Label();
            this.BtnStartStop = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EdDollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblDollar
            // 
            this.LblDollar.AutoSize = true;
            this.LblDollar.Location = new System.Drawing.Point(132, 21);
            this.LblDollar.Name = "LblDollar";
            this.LblDollar.Size = new System.Drawing.Size(45, 17);
            this.LblDollar.TabIndex = 0;
            this.LblDollar.Text = "Dollar";
            // 
            // EdDollar
            // 
            this.EdDollar.DecimalPlaces = 4;
            this.EdDollar.Location = new System.Drawing.Point(191, 19);
            this.EdDollar.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.EdDollar.Name = "EdDollar";
            this.EdDollar.Size = new System.Drawing.Size(120, 22);
            this.EdDollar.TabIndex = 1;
            this.EdDollar.Value = new decimal(new int[] {
            76,
            0,
            0,
            0});
            // 
            // EdEuro
            // 
            this.EdEuro.DecimalPlaces = 4;
            this.EdEuro.Location = new System.Drawing.Point(191, 61);
            this.EdEuro.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.EdEuro.Name = "EdEuro";
            this.EdEuro.Size = new System.Drawing.Size(120, 22);
            this.EdEuro.TabIndex = 3;
            this.EdEuro.Value = new decimal(new int[] {
            81,
            0,
            0,
            0});
            // 
            // LblEuro
            // 
            this.LblEuro.AutoSize = true;
            this.LblEuro.Location = new System.Drawing.Point(132, 63);
            this.LblEuro.Name = "LblEuro";
            this.LblEuro.Size = new System.Drawing.Size(38, 17);
            this.LblEuro.TabIndex = 2;
            this.LblEuro.Text = "Euro";
            // 
            // BtnStartStop
            // 
            this.BtnStartStop.Location = new System.Drawing.Point(386, 10);
            this.BtnStartStop.Name = "BtnStartStop";
            this.BtnStartStop.Size = new System.Drawing.Size(162, 38);
            this.BtnStartStop.TabIndex = 5;
            this.BtnStartStop.Text = "Start/Stop";
            this.BtnStartStop.UseVisualStyleBackColor = true;
            this.BtnStartStop.Click += new System.EventHandler(this.BtnStartStop_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(42, 103);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Dollar";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Euro";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(988, 602);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "Chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(386, 54);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(162, 35);
            this.BtnClear.TabIndex = 7;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.BtnStartStop);
            this.Controls.Add(this.EdEuro);
            this.Controls.Add(this.LblEuro);
            this.Controls.Add(this.EdDollar);
            this.Controls.Add(this.LblDollar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.EdDollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDollar;
        private System.Windows.Forms.NumericUpDown EdDollar;
        private System.Windows.Forms.NumericUpDown EdEuro;
        private System.Windows.Forms.Label LblEuro;
        private System.Windows.Forms.Button BtnStartStop;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnClear;
    }
}

