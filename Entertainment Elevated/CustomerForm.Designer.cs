namespace Entertainment_Elevated
{
    partial class CustomerForm
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
            this.CustomerFormPanel = new System.Windows.Forms.Panel();
            this.MenuButton = new System.Windows.Forms.Button();
            this.CustomerFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerFormPanel
            // 
            this.CustomerFormPanel.Controls.Add(this.MenuButton);
            this.CustomerFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerFormPanel.Location = new System.Drawing.Point(0, 0);
            this.CustomerFormPanel.Name = "CustomerFormPanel";
            this.CustomerFormPanel.Size = new System.Drawing.Size(484, 462);
            this.CustomerFormPanel.TabIndex = 0;
            // 
            // MenuButton
            // 
            this.MenuButton.Location = new System.Drawing.Point(12, 427);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(75, 23);
            this.MenuButton.TabIndex = 0;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.CustomerFormPanel);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.CustomerFormPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel CustomerFormPanel;
        private System.Windows.Forms.Button MenuButton;
    }
}