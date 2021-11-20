
namespace ProductivityApp
{
    partial class DesktopFrontEnd
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
            this.authorizedApp = new System.Windows.Forms.FlowLayoutPanel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorizedApp
            // 
            this.authorizedApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorizedApp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.authorizedApp.Location = new System.Drawing.Point(13, 13);
            this.authorizedApp.Name = "authorizedApp";
            this.authorizedApp.Size = new System.Drawing.Size(893, 767);
            this.authorizedApp.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.Location = new System.Drawing.Point(935, 13);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(200, 70);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit Desktop";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // DesktopFrontEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 792);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.authorizedApp);
            this.Name = "DesktopFrontEnd";
            this.Text = "DesktopFrontEnd";
            this.Load += new System.EventHandler(this.DesktopFrontEnd_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel authorizedApp;
        private System.Windows.Forms.Button exitBtn;
    }
}