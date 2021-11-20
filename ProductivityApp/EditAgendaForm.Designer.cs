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
            this.addMinute = new System.Windows.Forms.Button();
            this.timeFrame = new System.Windows.Forms.Label();
            this.addHour = new System.Windows.Forms.Button();
            this.allEvents = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.back = new System.Windows.Forms.Button();
            this.add1Min = new System.Windows.Forms.Button();
            this.lowerHour = new System.Windows.Forms.Button();
            this.minus10Min = new System.Windows.Forms.Button();
            this.minus1Minute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addEvent
            // 
            this.addEvent.Location = new System.Drawing.Point(637, 74);
            this.addEvent.Name = "addEvent";
            this.addEvent.Size = new System.Drawing.Size(83, 38);
            this.addEvent.TabIndex = 0;
            this.addEvent.Text = "+ New Event";
            this.addEvent.UseVisualStyleBackColor = true;
            this.addEvent.Click += new System.EventHandler(this.addEvent_Click);
            // 
            // eventName
            // 
            this.eventName.Location = new System.Drawing.Point(131, 79);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(244, 20);
            this.eventName.TabIndex = 1;
            this.eventName.Text = "Event Name";
            // 
            // addMinute
            // 
            this.addMinute.Location = new System.Drawing.Point(519, 56);
            this.addMinute.Name = "addMinute";
            this.addMinute.Size = new System.Drawing.Size(36, 24);
            this.addMinute.TabIndex = 3;
            this.addMinute.Text = "+10";
            this.addMinute.UseVisualStyleBackColor = true;
            this.addMinute.Click += new System.EventHandler(this.addMinute_Click);
            // 
            // timeFrame
            // 
            this.timeFrame.AutoSize = true;
            this.timeFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeFrame.Location = new System.Drawing.Point(425, 79);
            this.timeFrame.Name = "timeFrame";
            this.timeFrame.Size = new System.Drawing.Size(154, 20);
            this.timeFrame.TabIndex = 4;
            this.timeFrame.Text = "01:00 (Hour: Minute)\r\n";
            // 
            // addHour
            // 
            this.addHour.Location = new System.Drawing.Point(472, 56);
            this.addHour.Name = "addHour";
            this.addHour.Size = new System.Drawing.Size(32, 23);
            this.addHour.TabIndex = 7;
            this.addHour.Text = "+1";
            this.addHour.UseVisualStyleBackColor = true;
            this.addHour.Click += new System.EventHandler(this.addHour_Click);
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
            // add1Min
            // 
            this.add1Min.Location = new System.Drawing.Point(561, 56);
            this.add1Min.Name = "add1Min";
            this.add1Min.Size = new System.Drawing.Size(33, 23);
            this.add1Min.TabIndex = 10;
            this.add1Min.Text = "+1";
            this.add1Min.UseVisualStyleBackColor = true;
            this.add1Min.Click += new System.EventHandler(this.add1Min_Click);
            // 
            // lowerHour
            // 
            this.lowerHour.Location = new System.Drawing.Point(476, 102);
            this.lowerHour.Name = "lowerHour";
            this.lowerHour.Size = new System.Drawing.Size(28, 23);
            this.lowerHour.TabIndex = 11;
            this.lowerHour.Text = "-1";
            this.lowerHour.UseVisualStyleBackColor = true;
            // 
            // minus10Min
            // 
            this.minus10Min.Location = new System.Drawing.Point(522, 102);
            this.minus10Min.Name = "minus10Min";
            this.minus10Min.Size = new System.Drawing.Size(33, 23);
            this.minus10Min.TabIndex = 12;
            this.minus10Min.Text = "-10";
            this.minus10Min.UseVisualStyleBackColor = true;
            // 
            // minus1Minute
            // 
            this.minus1Minute.Location = new System.Drawing.Point(564, 102);
            this.minus1Minute.Name = "minus1Minute";
            this.minus1Minute.Size = new System.Drawing.Size(30, 23);
            this.minus1Minute.TabIndex = 13;
            this.minus1Minute.Text = "-1";
            this.minus1Minute.UseVisualStyleBackColor = true;
            // 
            // EditAgendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 501);
            this.Controls.Add(this.minus1Minute);
            this.Controls.Add(this.minus10Min);
            this.Controls.Add(this.lowerHour);
            this.Controls.Add(this.add1Min);
            this.Controls.Add(this.back);
            this.Controls.Add(this.allEvents);
            this.Controls.Add(this.addHour);
            this.Controls.Add(this.timeFrame);
            this.Controls.Add(this.addMinute);
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
        private System.Windows.Forms.Button addMinute;
        private System.Windows.Forms.Label timeFrame;
        private System.Windows.Forms.Button addHour;
        private System.Windows.Forms.ListView allEvents;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button add1Min;
        private System.Windows.Forms.Button lowerHour;
        private System.Windows.Forms.Button minus10Min;
        private System.Windows.Forms.Button minus1Minute;
    }
}