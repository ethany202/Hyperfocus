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
            this.moreInfoButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTime = new System.Windows.Forms.Label();
            this.addAppsButton = new System.Windows.Forms.Button();
            this.seeAllowedApps = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newAgendaButton
            // 
            this.newAgendaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newAgendaButton.BackColor = System.Drawing.SystemColors.Control;
            this.newAgendaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newAgendaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAgendaButton.Location = new System.Drawing.Point(1125, 5);
            this.newAgendaButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.newAgendaButton.Name = "newAgendaButton";
            this.newAgendaButton.Size = new System.Drawing.Size(280, 55);
            this.newAgendaButton.TabIndex = 2;
            this.newAgendaButton.Text = "+ New Agenda";
            this.newAgendaButton.UseVisualStyleBackColor = false;
            this.newAgendaButton.Click += new System.EventHandler(this.newAgendaButton_Click);
            this.newAgendaButton.MouseEnter += new System.EventHandler(this.newAgendaButton_MouseEnter);
            this.newAgendaButton.MouseLeave += new System.EventHandler(this.newAgendaButton_MouseLeave);
            // 
            // moreInfoButton
            // 
            this.moreInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moreInfoButton.Location = new System.Drawing.Point(4, 2);
            this.moreInfoButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.moreInfoButton.Name = "moreInfoButton";
            this.moreInfoButton.Size = new System.Drawing.Size(84, 58);
            this.moreInfoButton.TabIndex = 4;
            this.moreInfoButton.Text = "=";
            this.moreInfoButton.UseVisualStyleBackColor = true;
            this.moreInfoButton.MouseEnter += new System.EventHandler(this.moreInfoButton_MouseEnter);
            this.moreInfoButton.MouseLeave += new System.EventHandler(this.moreInfoButton_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(141, 95);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 695);
            this.panel1.TabIndex = 5;
            // 
            // dateTime
            // 
            this.dateTime.AutoSize = true;
            this.dateTime.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Location = new System.Drawing.Point(216, 31);
            this.dateTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(89, 35);
            this.dateTime.TabIndex = 0;
            this.dateTime.Text = "label1";
            // 
            // addAppsButton
            // 
            this.addAppsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addAppsButton.BackColor = System.Drawing.Color.DimGray;
            this.addAppsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addAppsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAppsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addAppsButton.FlatAppearance.BorderSize = 2;
            this.addAppsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAppsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addAppsButton.Location = new System.Drawing.Point(4, 656);
            this.addAppsButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.addAppsButton.Name = "addAppsButton";
            this.addAppsButton.Size = new System.Drawing.Size(84, 71);
            this.addAppsButton.TabIndex = 1;
            this.addAppsButton.Text = "+";
            this.addAppsButton.UseVisualStyleBackColor = false;
            this.addAppsButton.Click += new System.EventHandler(this.addAppsButton_Click);
            this.addAppsButton.MouseEnter += new System.EventHandler(this.addAppsButton_MouseEnter_1);
            this.addAppsButton.MouseLeave += new System.EventHandler(this.addAppsButton_MouseLeave_1);
            // 
            // seeAllowedApps
            // 
            this.seeAllowedApps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.seeAllowedApps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seeAllowedApps.ForeColor = System.Drawing.SystemColors.ControlText;
            this.seeAllowedApps.Location = new System.Drawing.Point(4, 737);
            this.seeAllowedApps.Margin = new System.Windows.Forms.Padding(6, 5, 6, 6);
            this.seeAllowedApps.Name = "seeAllowedApps";
            this.seeAllowedApps.Size = new System.Drawing.Size(84, 69);
            this.seeAllowedApps.TabIndex = 3;
            this.seeAllowedApps.Text = "Apps";
            this.seeAllowedApps.UseVisualStyleBackColor = true;
            this.seeAllowedApps.Click += new System.EventHandler(this.seeAllowedApps_Click);
            this.seeAllowedApps.MouseEnter += new System.EventHandler(this.seeAllowedApps_MouseEnter);
            this.seeAllowedApps.MouseLeave += new System.EventHandler(this.seeAllowedApps_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1515, 809);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.moreInfoButton);
            this.Controls.Add(this.seeAllowedApps);
            this.Controls.Add(this.addAppsButton);
            this.Controls.Add(this.newAgendaButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addAppsButton;
        private System.Windows.Forms.Button newAgendaButton;
        private System.Windows.Forms.Button seeAllowedApps;
        private System.Windows.Forms.Button moreInfoButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dateTime;
    }
}

