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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTime = new System.Windows.Forms.Label();
            this.seeAllowedApps = new ProductivityApp.NewAgendaButton();
            this.addAppsButton = new ProductivityApp.NewAgendaButton();
            this.newAgendaButton = new ProductivityApp.NewAgendaButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(77, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 408);
            this.panel1.TabIndex = 5;
            // 
            // dateTime
            // 
            this.dateTime.AutoSize = true;
            this.dateTime.BackColor = System.Drawing.Color.Transparent;
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.dateTime.Location = new System.Drawing.Point(118, 31);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(66, 24);
            this.dateTime.TabIndex = 0;
            this.dateTime.Text = "label1";
            // 
            // seeAllowedApps
            // 
            this.seeAllowedApps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(55)))), ((int)(((byte)(242)))));
            this.seeAllowedApps.FlatAppearance.BorderSize = 0;
            this.seeAllowedApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seeAllowedApps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeAllowedApps.ForeColor = System.Drawing.SystemColors.Control;
            this.seeAllowedApps.Location = new System.Drawing.Point(12, 432);
            this.seeAllowedApps.Name = "seeAllowedApps";
            this.seeAllowedApps.Size = new System.Drawing.Size(55, 55);
            this.seeAllowedApps.TabIndex = 0;
            this.seeAllowedApps.Text = "Apps";
            this.seeAllowedApps.UseVisualStyleBackColor = false;
            this.seeAllowedApps.Click += new System.EventHandler(this.seeAllowedApps_Click);
            // 
            // addAppsButton
            // 
            this.addAppsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(55)))), ((int)(((byte)(242)))));
            this.addAppsButton.FlatAppearance.BorderSize = 0;
            this.addAppsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAppsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppsButton.ForeColor = System.Drawing.Color.White;
            this.addAppsButton.Location = new System.Drawing.Point(12, 369);
            this.addAppsButton.Name = "addAppsButton";
            this.addAppsButton.Size = new System.Drawing.Size(55, 55);
            this.addAppsButton.TabIndex = 0;
            this.addAppsButton.Text = "+";
            this.addAppsButton.UseVisualStyleBackColor = false;
            this.addAppsButton.Click += new System.EventHandler(this.addAppsButton_Click);
            // 
            // newAgendaButton
            // 
            this.newAgendaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(55)))), ((int)(((byte)(242)))));
            this.newAgendaButton.FlatAppearance.BorderSize = 0;
            this.newAgendaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newAgendaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAgendaButton.ForeColor = System.Drawing.SystemColors.Control;
            this.newAgendaButton.Location = new System.Drawing.Point(654, 25);
            this.newAgendaButton.Name = "newAgendaButton";
            this.newAgendaButton.Size = new System.Drawing.Size(150, 40);
            this.newAgendaButton.TabIndex = 0;
            this.newAgendaButton.Text = "+New Agenda";
            this.newAgendaButton.UseVisualStyleBackColor = false;
            this.newAgendaButton.Click += new System.EventHandler(this.newAgendaButton_Click);
            this.newAgendaButton.MouseEnter += new System.EventHandler(this.newAgendaButton_MouseEnter);
            this.newAgendaButton.MouseLeave += new System.EventHandler(this.newAgendaButton_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(836, 501);
            this.Controls.Add(this.seeAllowedApps);
            this.Controls.Add(this.addAppsButton);
            this.Controls.Add(this.newAgendaButton);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dateTime;
        private NewAgendaButton newAgendaButton;
        private NewAgendaButton addAppsButton;
        private NewAgendaButton seeAllowedApps;
    }
}

