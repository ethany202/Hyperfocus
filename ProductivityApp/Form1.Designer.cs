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
            this.newAgendaButton = new System.Windows.Forms.Button();
            this.addAppsButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.seeAllowedApps = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newAgendaButton
            // 
            this.newAgendaButton.Location = new System.Drawing.Point(375, 138);
            this.newAgendaButton.Name = "newAgendaButton";
            this.newAgendaButton.Size = new System.Drawing.Size(142, 34);
            this.newAgendaButton.TabIndex = 2;
            this.newAgendaButton.Text = "+ New Agenda";
            this.newAgendaButton.UseVisualStyleBackColor = true;
            this.newAgendaButton.Click += new System.EventHandler(this.newAgendaButton_Click);
            // 
            // addAppsButton
            // 
            this.addAppsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAppsButton.Location = new System.Drawing.Point(2, 411);
            this.addAppsButton.Name = "addAppsButton";
            this.addAppsButton.Size = new System.Drawing.Size(81, 39);
            this.addAppsButton.TabIndex = 1;
            this.addAppsButton.Text = "Add Apps";
            this.addAppsButton.UseVisualStyleBackColor = true;
            this.addAppsButton.Click += new System.EventHandler(this.addAppsButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(2, 366);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(108, 39);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.Text = "Settings\r\n";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // seeAllowedApps
            // 
            this.seeAllowedApps.Location = new System.Drawing.Point(2, 456);
            this.seeAllowedApps.Name = "seeAllowedApps";
            this.seeAllowedApps.Size = new System.Drawing.Size(142, 43);
            this.seeAllowedApps.TabIndex = 3;
            this.seeAllowedApps.Text = "See Allowed Apps";
            this.seeAllowedApps.UseVisualStyleBackColor = true;
            this.seeAllowedApps.Click += new System.EventHandler(this.seeAllowedApps_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 501);
            this.Controls.Add(this.seeAllowedApps);
            this.Controls.Add(this.addAppsButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.newAgendaButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button addAppsButton;
        private System.Windows.Forms.Button newAgendaButton;
        private System.Windows.Forms.Button seeAllowedApps;
    }
}

