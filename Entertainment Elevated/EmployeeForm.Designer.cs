namespace Entertainment_Elevated
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
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            this.EmployeeFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeDataGridView
            // 
            this.EmployeeDataGridView.AllowUserToOrderColumns = true;
            this.EmployeeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.RowHeadersVisible = false;
            this.EmployeeDataGridView.Size = new System.Drawing.Size(484, 150);
            this.EmployeeDataGridView.TabIndex = 0;
            // 
            // EmployeeFormPanel
            // 
            this.EmployeeFormPanel.Controls.Add(this.AddEmployeeButton);
            this.EmployeeFormPanel.Controls.Add(this.MenuButton);
            this.EmployeeFormPanel.Controls.Add(this.EmployeeDataGridView);
            this.EmployeeFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeFormPanel.Location = new System.Drawing.Point(0, 0);
            this.EmployeeFormPanel.Name = "EmployeeFormPanel";
            this.EmployeeFormPanel.Size = new System.Drawing.Size(484, 462);
            this.EmployeeFormPanel.TabIndex = 1;
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(12, 194);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(84, 23);
            this.AddEmployeeButton.TabIndex = 2;
            this.AddEmployeeButton.Text = "Add Employee";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
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
        public System.Windows.Forms.Panel EmployeeFormPanel;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button AddEmployeeButton;
        public System.Windows.Forms.DataGridView EmployeeDataGridView;
    }
}