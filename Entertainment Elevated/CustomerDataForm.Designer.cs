namespace Entertainment_Elevated
{
    partial class CustomerDataForm
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
            this.CustomerDataFormPanel = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DayOfWeekGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomerDataFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerDataFormPanel
            // 
            this.CustomerDataFormPanel.Controls.Add(this.DayOfWeekGroupBox);
            this.CustomerDataFormPanel.Controls.Add(this.chart1);
            this.CustomerDataFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerDataFormPanel.Location = new System.Drawing.Point(0, 0);
            this.CustomerDataFormPanel.Name = "CustomerDataFormPanel";
            this.CustomerDataFormPanel.Size = new System.Drawing.Size(584, 461);
            this.CustomerDataFormPanel.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(150, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(422, 437);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // DayOfWeekGroupBox
            // 
            this.DayOfWeekGroupBox.Location = new System.Drawing.Point(12, 12);
            this.DayOfWeekGroupBox.Name = "DayOfWeekGroupBox";
            this.DayOfWeekGroupBox.Size = new System.Drawing.Size(103, 100);
            this.DayOfWeekGroupBox.TabIndex = 1;
            this.DayOfWeekGroupBox.TabStop = false;
            this.DayOfWeekGroupBox.Text = "Day of Week";
            this.DayOfWeekGroupBox.Enter += new System.EventHandler(this.DayOfWeekGroupBox_Enter);
            // 
            // CustomerDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.CustomerDataFormPanel);
            this.Name = "CustomerDataForm";
            this.Text = "CustomerDataForm";
            this.CustomerDataFormPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CustomerDataFormPanel;
        private System.Windows.Forms.GroupBox DayOfWeekGroupBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}