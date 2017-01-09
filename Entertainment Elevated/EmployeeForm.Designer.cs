namespace Entertainment_Elevanted
{
    partial class EmployeeForm
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
            this.EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.EmployeeFormPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            this.EmployeeFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeDataGridView
            // 
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGridView.Location = new System.Drawing.Point(7, 9);
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.Size = new System.Drawing.Size(240, 150);
            this.EmployeeDataGridView.TabIndex = 0;
            // 
            // EmployeeFormPanel
            // 
            this.EmployeeFormPanel.Controls.Add(this.EmployeeDataGridView);
            this.EmployeeFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeFormPanel.Location = new System.Drawing.Point(0, 0);
            this.EmployeeFormPanel.Name = "EmployeeFormPanel";
            this.EmployeeFormPanel.Size = new System.Drawing.Size(484, 462);
            this.EmployeeFormPanel.TabIndex = 1;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.EmployeeFormPanel);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            this.EmployeeFormPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeDataGridView;
        public System.Windows.Forms.Panel EmployeeFormPanel;
    }
}