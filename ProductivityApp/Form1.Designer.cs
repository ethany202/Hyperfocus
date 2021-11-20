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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.newAgendaButton = new System.Windows.Forms.Button();
            this.addAppsButton = new System.Windows.Forms.Button();
            this.seeAllowedApps = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newAgendaButton
            // 
            this.newAgendaButton.BackColor = System.Drawing.Color.DarkGray;
            this.newAgendaButton.FlatAppearance.BorderSize = 0;
            this.newAgendaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newAgendaButton.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAgendaButton.Image = ((System.Drawing.Image)(resources.GetObject("newAgendaButton.Image")));
            this.newAgendaButton.Location = new System.Drawing.Point(641, 440);
            this.newAgendaButton.Name = "newAgendaButton";
            this.newAgendaButton.Size = new System.Drawing.Size(195, 61);
            this.newAgendaButton.TabIndex = 2;
            this.newAgendaButton.Text = "New Agenda";
            this.newAgendaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.newAgendaButton.UseVisualStyleBackColor = false;
            this.newAgendaButton.Click += new System.EventHandler(this.newAgendaButton_Click);
            // 
            // addAppsButton
            // 
            this.addAppsButton.BackColor = System.Drawing.Color.DarkGray;
            this.addAppsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAppsButton.FlatAppearance.BorderSize = 0;
            this.addAppsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAppsButton.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addAppsButton.Image = ((System.Drawing.Image)(resources.GetObject("addAppsButton.Image")));
            this.addAppsButton.Location = new System.Drawing.Point(-2, 343);
            this.addAppsButton.Name = "addAppsButton";
            this.addAppsButton.Size = new System.Drawing.Size(142, 75);
            this.addAppsButton.TabIndex = 1;
            this.addAppsButton.Text = "Add Apps";
            this.addAppsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addAppsButton.UseVisualStyleBackColor = false;
            this.addAppsButton.Click += new System.EventHandler(this.addAppsButton_Click);
            // 
            // seeAllowedApps
            // 
            this.seeAllowedApps.AutoSize = true;
            this.seeAllowedApps.FlatAppearance.BorderSize = 0;
            this.seeAllowedApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seeAllowedApps.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeAllowedApps.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.seeAllowedApps.Image = ((System.Drawing.Image)(resources.GetObject("seeAllowedApps.Image")));
            this.seeAllowedApps.Location = new System.Drawing.Point(-2, 424);
            this.seeAllowedApps.Name = "seeAllowedApps";
            this.seeAllowedApps.Size = new System.Drawing.Size(142, 70);
            this.seeAllowedApps.TabIndex = 3;
            this.seeAllowedApps.Text = "See Allowed Apps";
            this.seeAllowedApps.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.seeAllowedApps.UseVisualStyleBackColor = true;
            this.seeAllowedApps.Click += new System.EventHandler(this.seeAllowedApps_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.seeAllowedApps);
            this.panel1.Controls.Add(this.addAppsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 501);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(836, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.newAgendaButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addAppsButton;
        private System.Windows.Forms.Button newAgendaButton;
        private System.Windows.Forms.Button seeAllowedApps;
        private System.Windows.Forms.Panel panel1;
    }
}

