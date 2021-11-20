namespace ProductivityApp
{
    partial class EditAgendaForm
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
            this.addEvent = new System.Windows.Forms.Button();
            this.eventName = new System.Windows.Forms.TextBox();
            this.earlyTime = new System.Windows.Forms.Button();
            this.timeFrame = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.allEvents = new System.Windows.Forms.ListView();
            this.back = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // addEvent
            // 
            this.addEvent.Location = new System.Drawing.Point(566, 69);
            this.addEvent.Name = "addEvent";
            this.addEvent.Size = new System.Drawing.Size(83, 38);
            this.addEvent.TabIndex = 0;
            this.addEvent.Text = "+ New Event";
            this.addEvent.UseVisualStyleBackColor = true;
            // 
            // eventName
            // 
            this.eventName.Location = new System.Drawing.Point(131, 79);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(244, 20);
            this.eventName.TabIndex = 1;
            this.eventName.Text = "Event Name";
            // 
            // earlyTime
            // 
            this.earlyTime.Location = new System.Drawing.Point(454, 56);
            this.earlyTime.Name = "earlyTime";
            this.earlyTime.Size = new System.Drawing.Size(22, 24);
            this.earlyTime.TabIndex = 3;
            this.earlyTime.Text = "^";
            this.earlyTime.UseVisualStyleBackColor = true;
            // 
            // timeFrame
            // 
            this.timeFrame.AutoSize = true;
            this.timeFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeFrame.Location = new System.Drawing.Point(421, 82);
            this.timeFrame.Name = "timeFrame";
            this.timeFrame.Size = new System.Drawing.Size(124, 16);
            this.timeFrame.TabIndex = 4;
            this.timeFrame.Text = "01:00 (Hour: Minute)\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(425, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // allEvents
            // 
            this.allEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.allEvents.ForeColor = System.Drawing.SystemColors.WindowText;
            this.allEvents.HideSelection = false;
            this.allEvents.Location = new System.Drawing.Point(63, 175);
            this.allEvents.Name = "allEvents";
            this.allEvents.Size = new System.Drawing.Size(699, 278);
            this.allEvents.TabIndex = 8;
            this.allEvents.UseCompatibleStateImageBehavior = false;
            this.allEvents.View = System.Windows.Forms.View.Details;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 9;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Event Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time Frame";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Authorized Apps";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 120;
            // 
            // EditAgendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 501);
            this.Controls.Add(this.back);
            this.Controls.Add(this.allEvents);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeFrame);
            this.Controls.Add(this.earlyTime);
            this.Controls.Add(this.eventName);
            this.Controls.Add(this.addEvent);
            this.Name = "EditAgendaForm";
            this.Text = "EditAgendaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addEvent;
        private System.Windows.Forms.TextBox eventName;
        private System.Windows.Forms.Button earlyTime;
        private System.Windows.Forms.Label timeFrame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView allEvents;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}