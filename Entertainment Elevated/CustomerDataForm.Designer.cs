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
            this.CustomerDataFormPanel = new System.Windows.Forms.Panel();
            this.DataPictureBox = new System.Windows.Forms.PictureBox();
            this.MenuButton = new System.Windows.Forms.Button();
            this.CustomerButton = new System.Windows.Forms.Button();
            this.CustomerDataFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerDataFormPanel
            // 
            this.CustomerDataFormPanel.Controls.Add(this.CustomerButton);
            this.CustomerDataFormPanel.Controls.Add(this.MenuButton);
            this.CustomerDataFormPanel.Controls.Add(this.DataPictureBox);
            this.CustomerDataFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerDataFormPanel.Location = new System.Drawing.Point(0, 0);
            this.CustomerDataFormPanel.Name = "CustomerDataFormPanel";
            this.CustomerDataFormPanel.Size = new System.Drawing.Size(584, 461);
            this.CustomerDataFormPanel.TabIndex = 0;
            // 
            // DataPictureBox
            // 
            this.DataPictureBox.Location = new System.Drawing.Point(7, 12);
            this.DataPictureBox.Name = "DataPictureBox";
            this.DataPictureBox.Size = new System.Drawing.Size(565, 216);
            this.DataPictureBox.TabIndex = 0;
            this.DataPictureBox.TabStop = false;
            this.DataPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DataPictureBox_Paint);
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(12, 426);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(75, 23);
            this.MenuButton.TabIndex = 1;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // CustomerButton
            // 
            this.CustomerButton.Location = new System.Drawing.Point(497, 426);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(75, 23);
            this.CustomerButton.TabIndex = 2;
            this.CustomerButton.Text = "Customer";
            this.CustomerButton.UseVisualStyleBackColor = true;
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.DataPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox DataPictureBox;
        public System.Windows.Forms.Panel CustomerDataFormPanel;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button CustomerButton;
    }
}