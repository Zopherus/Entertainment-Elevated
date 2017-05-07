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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDataForm));
            this.CustomerDataFormPanel = new System.Windows.Forms.Panel();
            this.CustomerDataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DayOfWeekComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.PrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.PrintDocument = new System.Drawing.Printing.PrintDocument();
            this.CustomerDataFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataChart)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerDataFormPanel
            // 
            this.CustomerDataFormPanel.Controls.Add(this.PrintButton);
            this.CustomerDataFormPanel.Controls.Add(this.CustomerDataChart);
            this.CustomerDataFormPanel.Controls.Add(this.DayOfWeekComboBox);
            this.CustomerDataFormPanel.Controls.Add(this.CustomerButton);
            this.CustomerDataFormPanel.Controls.Add(this.MenuButton);
            this.CustomerDataFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerDataFormPanel.Location = new System.Drawing.Point(0, 0);
            this.CustomerDataFormPanel.Name = "CustomerDataFormPanel";
            this.CustomerDataFormPanel.Size = new System.Drawing.Size(584, 461);
            this.CustomerDataFormPanel.TabIndex = 0;
            // 
            // CustomerDataChart
            // 
            chartArea1.Name = "ChartArea1";
            this.CustomerDataChart.ChartAreas.Add(chartArea1);
            this.CustomerDataChart.Location = new System.Drawing.Point(12, 51);
            this.CustomerDataChart.Name = "CustomerDataChart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.CustomerDataChart.Series.Add(series1);
            this.CustomerDataChart.Size = new System.Drawing.Size(560, 378);
            this.CustomerDataChart.TabIndex = 10;
            // 
            // DayOfWeekComboBox
            // 
            this.DayOfWeekComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayOfWeekComboBox.FormattingEnabled = true;
            this.DayOfWeekComboBox.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.DayOfWeekComboBox.Location = new System.Drawing.Point(12, 12);
            this.DayOfWeekComboBox.Name = "DayOfWeekComboBox";
            this.DayOfWeekComboBox.Size = new System.Drawing.Size(121, 21);
            this.DayOfWeekComboBox.TabIndex = 9;
            this.DayOfWeekComboBox.SelectedIndexChanged += new System.EventHandler(this.DayOfWeekComboBox_SelectedIndexChanged);
            // 
            // CustomerButton
            // 
            this.CustomerButton.Location = new System.Drawing.Point(12, 435);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(75, 23);
            this.CustomerButton.TabIndex = 7;
            this.CustomerButton.Text = "Customers";
            this.CustomerButton.UseVisualStyleBackColor = true;
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(497, 435);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(75, 23);
            this.MenuButton.TabIndex = 8;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(497, 10);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 1;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // PrintPreviewDialog
            // 
            this.PrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog.Enabled = true;
            this.PrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog.Icon")));
            this.PrintPreviewDialog.Name = "PrintPreviewDialog";
            this.PrintPreviewDialog.Visible = false;
            // 
            // PrintDocument
            // 
            this.PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
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
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CustomerDataFormPanel;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button CustomerButton;
        private System.Windows.Forms.ComboBox DayOfWeekComboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart CustomerDataChart;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument PrintDocument;
    }
}