namespace ProductivityApp
{
    partial class Form1
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
            this.settingsButton = new System.Windows.Forms.Button();
            this.addAppsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // settingsButton
            // 
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(23, 399);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(108, 39);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.Text = "Settings\r\n";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // addAppsButton
            // 
            this.addAppsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAppsButton.Location = new System.Drawing.Point(162, 399);
            this.addAppsButton.Name = "addAppsButton";
            this.addAppsButton.Size = new System.Drawing.Size(86, 39);
            this.addAppsButton.TabIndex = 1;
            this.addAppsButton.Text = "Add Apps";
            this.addAppsButton.UseVisualStyleBackColor = true;
            this.addAppsButton.Click += new System.EventHandler(this.addAppsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addAppsButton);
            this.Controls.Add(this.settingsButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button addAppsButton;
    }
}

