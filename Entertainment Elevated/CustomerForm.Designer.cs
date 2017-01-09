namespace Entertainment_Elevanted
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
            this.SuspendLayout();
            // 
            // CustomerFormPanel
            // 
            this.CustomerFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerFormPanel.Location = new System.Drawing.Point(0, 0);
            this.CustomerFormPanel.Name = "CustomerFormPanel";
            this.CustomerFormPanel.Size = new System.Drawing.Size(484, 462);
            this.CustomerFormPanel.TabIndex = 0;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.CustomerFormPanel);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel CustomerFormPanel;
    }
}