namespace ProductivityApp
{
    partial class AllowedApps
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
            this.allowedAppsText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allowedAppsText
            // 
            this.allowedAppsText.AutoSize = true;
            this.allowedAppsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allowedAppsText.Location = new System.Drawing.Point(290, 30);
            this.allowedAppsText.Name = "allowedAppsText";
            this.allowedAppsText.Size = new System.Drawing.Size(263, 31);
            this.allowedAppsText.TabIndex = 0;
            this.allowedAppsText.Text = "Allowed Applications";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel1.Location = new System.Drawing.Point(35, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 411);
            this.panel1.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(47, 30);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AllowedApps
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(836, 501);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.allowedAppsText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllowedApps";
            this.Text = "AllowedApps";
            this.Load += new System.EventHandler(this.AllowedApps_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label allowedAppsText;
        private System.Windows.Forms.FlowLayoutPanel panel1;
        private System.Windows.Forms.Button backButton;
    }
}