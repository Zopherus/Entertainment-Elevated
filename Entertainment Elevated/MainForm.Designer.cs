namespace Entertainment_Elevanted
{
    partial class MainForm
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
        public void InitializeComponent()
        {
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.CustomerButton = new System.Windows.Forms.Button();
            this.ScheduleButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.Location = new System.Drawing.Point(5, 12);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(163, 120);
            this.EmployeeButton.TabIndex = 0;
            this.EmployeeButton.Text = "Employees";
            this.EmployeeButton.UseVisualStyleBackColor = true;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // CustomerButton
            // 
            this.CustomerButton.Location = new System.Drawing.Point(309, 330);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(163, 120);
            this.CustomerButton.TabIndex = 2;
            this.CustomerButton.Text = "Customers";
            this.CustomerButton.UseVisualStyleBackColor = true;
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // ScheduleButton
            // 
            this.ScheduleButton.Location = new System.Drawing.Point(12, 333);
            this.ScheduleButton.Name = "ScheduleButton";
            this.ScheduleButton.Size = new System.Drawing.Size(163, 120);
            this.ScheduleButton.TabIndex = 1;
            this.ScheduleButton.Text = "Schedule";
            this.ScheduleButton.UseVisualStyleBackColor = true;
            this.ScheduleButton.Click += new System.EventHandler(this.ScheduleButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(13, 477);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 512);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.ScheduleButton);
            this.Controls.Add(this.CustomerButton);
            this.Name = "MainForm";
            this.Text = "Entertainment Elevated";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EmployeeButton;
        private System.Windows.Forms.Button CustomerButton;
        private System.Windows.Forms.Button ScheduleButton;
        private System.Windows.Forms.Button BackButton;
    }
}

