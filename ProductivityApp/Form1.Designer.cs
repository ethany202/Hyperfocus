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
            this.dateTime = new System.Windows.Forms.Label();
            this.addAppsButton = new System.Windows.Forms.Button();
            this.seeAllowedApps = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newAgendaButton
            // 
            this.newAgendaButton.BackColor = System.Drawing.Color.DimGray;
            this.newAgendaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newAgendaButton.FlatAppearance.BorderSize = 0;
            this.newAgendaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newAgendaButton.Font = new System.Drawing.Font("Moon", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAgendaButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.newAgendaButton.Location = new System.Drawing.Point(510, 379);
            this.newAgendaButton.Name = "newAgendaButton";
            this.newAgendaButton.Size = new System.Drawing.Size(167, 41);
            this.newAgendaButton.TabIndex = 2;
            this.newAgendaButton.Text = "+ New Agenda";
            this.newAgendaButton.UseVisualStyleBackColor = false;
            this.newAgendaButton.Click += new System.EventHandler(this.newAgendaButton_Click);
            this.newAgendaButton.MouseEnter += new System.EventHandler(this.newAgendaButton_MouseHover);
            this.newAgendaButton.MouseLeave += new System.EventHandler(this.newAgendaButton_MouseLeave);
            // 
            // dateTime
            // 
            this.dateTime.AutoSize = true;
            this.dateTime.BackColor = System.Drawing.Color.Transparent;
            this.dateTime.Font = new System.Drawing.Font("Moon", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.dateTime.Location = new System.Drawing.Point(214, 388);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(80, 20);
            this.dateTime.TabIndex = 0;
            this.dateTime.Text = "label1";
            // 
            // addAppsButton
            // 
            this.addAppsButton.BackColor = System.Drawing.Color.Transparent;
            this.addAppsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addAppsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAppsButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.addAppsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAppsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addAppsButton.Location = new System.Drawing.Point(2, 2);
            this.addAppsButton.Name = "addAppsButton";
            this.addAppsButton.Size = new System.Drawing.Size(55, 55);
            this.addAppsButton.TabIndex = 1;
            this.addAppsButton.Text = "+";
            this.addAppsButton.UseVisualStyleBackColor = false;
            this.addAppsButton.Click += new System.EventHandler(this.addAppsButton_Click);
            // 
            // seeAllowedApps
            // 
            this.seeAllowedApps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seeAllowedApps.Font = new System.Drawing.Font("Moon", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeAllowedApps.ForeColor = System.Drawing.SystemColors.ControlText;
            this.seeAllowedApps.Location = new System.Drawing.Point(2, 57);
            this.seeAllowedApps.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.seeAllowedApps.Name = "seeAllowedApps";
            this.seeAllowedApps.Size = new System.Drawing.Size(55, 55);
            this.seeAllowedApps.TabIndex = 3;
            this.seeAllowedApps.Text = "Apps";
            this.seeAllowedApps.UseVisualStyleBackColor = true;
            this.seeAllowedApps.Click += new System.EventHandler(this.seeAllowedApps_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Moon", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(271, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hyperfocus";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Moon", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(316, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Where Productivity is Born;";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Moon", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(339, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Be Smart, Be Efficient";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Moon", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(73, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add Apps";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Moon", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(72, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Authorized";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(863, 510);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.seeAllowedApps);
            this.Controls.Add(this.addAppsButton);
            this.Controls.Add(this.newAgendaButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addAppsButton;
        private System.Windows.Forms.Button newAgendaButton;
        private System.Windows.Forms.Button seeAllowedApps;
        private System.Windows.Forms.Label dateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

