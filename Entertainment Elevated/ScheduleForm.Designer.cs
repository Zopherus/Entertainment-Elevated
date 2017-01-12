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
            this.ScheduleCalendar = new System.Windows.Forms.MonthCalendar();
            this.ScheduleFormPanel = new System.Windows.Forms.Panel();
            this.ScheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.MenuButton = new System.Windows.Forms.Button();
            this.ScheduleFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ScheduleCalendar
            // 
            this.ScheduleCalendar.Location = new System.Drawing.Point(9, 9);
            this.ScheduleCalendar.Name = "ScheduleCalendar";
            this.ScheduleCalendar.TabIndex = 0;
            // 
            // ScheduleFormPanel
            // 
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
            this.ScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleDataGridView.Location = new System.Drawing.Point(0, 188);
            this.ScheduleDataGridView.Name = "ScheduleDataGridView";
            this.ScheduleDataGridView.RowHeadersVisible = false;
            this.ScheduleDataGridView.Size = new System.Drawing.Size(484, 150);
            this.ScheduleDataGridView.TabIndex = 2;
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
    }
}