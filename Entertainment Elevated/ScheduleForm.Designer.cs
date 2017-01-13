namespace Entertainment_Elevated
{
    partial class ScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleForm));
            this.ScheduleCalendar = new System.Windows.Forms.MonthCalendar();
            this.ScheduleFormPanel = new System.Windows.Forms.Panel();
            this.ScheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.MenuButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.PrintDocument = new System.Drawing.Printing.PrintDocument();
            this.PrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.ScheduleFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ScheduleCalendar
            // 
            this.ScheduleCalendar.Location = new System.Drawing.Point(9, 9);
            this.ScheduleCalendar.MaxSelectionCount = 1;
            this.ScheduleCalendar.Name = "ScheduleCalendar";
            this.ScheduleCalendar.TabIndex = 0;
            this.ScheduleCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.ScheduleCalendar_DateSelected);
            // 
            // ScheduleFormPanel
            // 
            this.ScheduleFormPanel.Controls.Add(this.ReportButton);
            this.ScheduleFormPanel.Controls.Add(this.ScheduleDataGridView);
            this.ScheduleFormPanel.Controls.Add(this.MenuButton);
            this.ScheduleFormPanel.Controls.Add(this.ScheduleCalendar);
            this.ScheduleFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScheduleFormPanel.Location = new System.Drawing.Point(0, 0);
            this.ScheduleFormPanel.Name = "ScheduleFormPanel";
            this.ScheduleFormPanel.Size = new System.Drawing.Size(484, 462);
            this.ScheduleFormPanel.TabIndex = 1;
            // 
            // ScheduleDataGridView
            // 
            this.ScheduleDataGridView.AllowUserToAddRows = false;
            this.ScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleDataGridView.Location = new System.Drawing.Point(0, 188);
            this.ScheduleDataGridView.Name = "ScheduleDataGridView";
            this.ScheduleDataGridView.RowHeadersVisible = false;
            this.ScheduleDataGridView.Size = new System.Drawing.Size(484, 150);
            this.ScheduleDataGridView.TabIndex = 2;
            this.ScheduleDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ScheduleDataGridView_CellEndEdit);
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(12, 427);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(75, 23);
            this.MenuButton.TabIndex = 1;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(348, 415);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(124, 35);
            this.ReportButton.TabIndex = 3;
            this.ReportButton.Text = "Generate Weekly Report";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // PrintDocument
            // 
            this.PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
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
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.ScheduleFormPanel);
            this.Name = "ScheduleForm";
            this.Text = "ScheduleForm";
            this.ScheduleFormPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar ScheduleCalendar;
        public System.Windows.Forms.Panel ScheduleFormPanel;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.DataGridView ScheduleDataGridView;
        private System.Windows.Forms.Button ReportButton;
        private System.Drawing.Printing.PrintDocument PrintDocument;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog;
    }
}