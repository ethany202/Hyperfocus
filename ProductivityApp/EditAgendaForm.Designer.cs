using System;

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

        /*#region Windows Form Designer generated code

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
            this.button1 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Begin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditAgendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 501);
            this.Controls.Add(this.button1);
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
        */
        private void InitializeComponent()
        {
            this.addEvent = new System.Windows.Forms.Button();
            this.addMinute = new System.Windows.Forms.Button();
            this.timeFrame = new System.Windows.Forms.Label();
            this.addHour = new System.Windows.Forms.Button();
            this.lowerHour = new System.Windows.Forms.Button();
            this.minus10Min = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.setAuthorizedApps = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addAuthorizedApp = new System.Windows.Forms.Button();
            this.beginAgenda = new System.Windows.Forms.Button();
            this.eventName = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.currentApps = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // addEvent
            // 
            this.addEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEvent.Font = new System.Drawing.Font("Moon", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvent.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.addEvent.Location = new System.Drawing.Point(662, 53);
            this.addEvent.Name = "addEvent";
            this.addEvent.Size = new System.Drawing.Size(169, 55);
            this.addEvent.TabIndex = 0;
            this.addEvent.Text = "+  New Event";
            this.addEvent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addEvent.UseVisualStyleBackColor = true;
            this.addEvent.Click += new System.EventHandler(this.addEvent_Click);
            // 
            // addMinute
            // 
            this.addMinute.BackColor = System.Drawing.Color.DimGray;
            this.addMinute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMinute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMinute.Location = new System.Drawing.Point(140, 8);
            this.addMinute.Name = "addMinute";
            this.addMinute.Size = new System.Drawing.Size(22, 25);
            this.addMinute.TabIndex = 3;
            this.addMinute.Text = "+";
            this.addMinute.UseVisualStyleBackColor = false;
            this.addMinute.Click += new System.EventHandler(this.addMinute_Click);
            // 
            // timeFrame
            // 
            this.timeFrame.AutoSize = true;
            this.timeFrame.Font = new System.Drawing.Font("Moon", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeFrame.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.timeFrame.Location = new System.Drawing.Point(43, 36);
            this.timeFrame.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.timeFrame.Name = "timeFrame";
            this.timeFrame.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.timeFrame.Size = new System.Drawing.Size(119, 22);
            this.timeFrame.TabIndex = 5;
            this.timeFrame.Text = "Time: 01 : 00";
            this.timeFrame.Click += new System.EventHandler(this.timeFrame_Click);
            // 
            // addHour
            // 
            this.addHour.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addHour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addHour.Location = new System.Drawing.Point(101, 8);
            this.addHour.Name = "addHour";
            this.addHour.Size = new System.Drawing.Size(22, 25);
            this.addHour.TabIndex = 7;
            this.addHour.Text = "+";
            this.addHour.UseVisualStyleBackColor = false;
            this.addHour.Click += new System.EventHandler(this.addHour_Click);
            // 
            // lowerHour
            // 
            this.lowerHour.BackColor = System.Drawing.Color.DimGray;
            this.lowerHour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lowerHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lowerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerHour.Location = new System.Drawing.Point(101, 62);
            this.lowerHour.Name = "lowerHour";
            this.lowerHour.Size = new System.Drawing.Size(22, 23);
            this.lowerHour.TabIndex = 11;
            this.lowerHour.Text = "-";
            this.lowerHour.UseVisualStyleBackColor = false;
            this.lowerHour.Click += new System.EventHandler(this.lowerHour_Click);
            // 
            // minus10Min
            // 
            this.minus10Min.BackColor = System.Drawing.Color.DimGray;
            this.minus10Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minus10Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus10Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus10Min.Location = new System.Drawing.Point(140, 62);
            this.minus10Min.Name = "minus10Min";
            this.minus10Min.Size = new System.Drawing.Size(22, 23);
            this.minus10Min.TabIndex = 12;
            this.minus10Min.Text = "-";
            this.minus10Min.UseVisualStyleBackColor = false;
            this.minus10Min.Click += new System.EventHandler(this.minus10Min_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Moon", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(38, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Event Name: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.timeFrame);
            this.panel1.Controls.Add(this.minus10Min);
            this.panel1.Controls.Add(this.addMinute);
            this.panel1.Controls.Add(this.lowerHour);
            this.panel1.Controls.Add(this.addHour);
            this.panel1.Location = new System.Drawing.Point(438, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 15;
            // 
            // setAuthorizedApps
            // 
            this.setAuthorizedApps.AutoSize = true;
            this.setAuthorizedApps.Font = new System.Drawing.Font("Moon", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setAuthorizedApps.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.setAuthorizedApps.Location = new System.Drawing.Point(74, 158);
            this.setAuthorizedApps.Name = "setAuthorizedApps";
            this.setAuthorizedApps.Size = new System.Drawing.Size(213, 20);
            this.setAuthorizedApps.TabIndex = 17;
            this.setAuthorizedApps.Text = "Set Authorized Apps";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DimGray;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Moon", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(45, 45);
            this.back.TabIndex = 9;
            this.back.Text = "<";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DimGray;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(300, 184);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 80);
            this.listBox1.TabIndex = 18;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DimGray;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.richTextBox1.Location = new System.Drawing.Point(300, 154);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(261, 24);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Moon", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Location = new System.Drawing.Point(185, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 22);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // addAuthorizedApp
            // 
            this.addAuthorizedApp.BackColor = System.Drawing.Color.Gainsboro;
            this.addAuthorizedApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAuthorizedApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAuthorizedApp.Font = new System.Drawing.Font("Moon", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAuthorizedApp.ForeColor = System.Drawing.Color.Black;
            this.addAuthorizedApp.Location = new System.Drawing.Point(607, 153);
            this.addAuthorizedApp.Name = "addAuthorizedApp";
            this.addAuthorizedApp.Size = new System.Drawing.Size(111, 25);
            this.addAuthorizedApp.TabIndex = 21;
            this.addAuthorizedApp.Text = "Include App";
            this.addAuthorizedApp.UseVisualStyleBackColor = false;
            this.addAuthorizedApp.Click += new System.EventHandler(this.addAuthorizedApp_Click);
            // 
            // beginAgenda
            // 
            this.beginAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.beginAgenda.FlatAppearance.BorderSize = 0;
            this.beginAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beginAgenda.Font = new System.Drawing.Font("Moon", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginAgenda.ForeColor = System.Drawing.Color.Gainsboro;
            this.beginAgenda.Location = new System.Drawing.Point(0, 460);
            this.beginAgenda.Name = "beginAgenda";
            this.beginAgenda.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.beginAgenda.Size = new System.Drawing.Size(77, 35);
            this.beginAgenda.TabIndex = 22;
            this.beginAgenda.Text = "Begin";
            this.beginAgenda.UseVisualStyleBackColor = true;
            this.beginAgenda.Click += new System.EventHandler(this.beginAgenda_Click);
            // 
            // eventName
            // 
            this.eventName.AutoSize = true;
            this.eventName.Font = new System.Drawing.Font("Moon", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventName.ForeColor = System.Drawing.Color.Gainsboro;
            this.eventName.Location = new System.Drawing.Point(70, 5);
            this.eventName.Margin = new System.Windows.Forms.Padding(70, 5, 0, 5);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(111, 16);
            this.eventName.TabIndex = 0;
            this.eventName.Text = "Event Name";
            this.eventName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Moon", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.Gainsboro;
            this.time.Location = new System.Drawing.Point(60, 5);
            this.time.Margin = new System.Windows.Forms.Padding(60, 5, 0, 5);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(106, 16);
            this.time.TabIndex = 1;
            this.time.Text = "Time Frame";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Moon", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(45, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(45, 5, 3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "All Authorized Apps";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.eventName);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(58, 299);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(229, 155);
            this.flowLayoutPanel1.TabIndex = 24;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.time);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(285, 299);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(234, 155);
            this.flowLayoutPanel2.TabIndex = 25;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(515, 299);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(316, 155);
            this.flowLayoutPanel3.TabIndex = 26;
            // 
            // currentApps
            // 
            this.currentApps.AutoSize = true;
            this.currentApps.Font = new System.Drawing.Font("Moon", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentApps.ForeColor = System.Drawing.Color.Gainsboro;
            this.currentApps.Location = new System.Drawing.Point(605, 193);
            this.currentApps.Name = "currentApps";
            this.currentApps.Size = new System.Drawing.Size(8, 11);
            this.currentApps.TabIndex = 27;
            this.currentApps.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Moon", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(605, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(8, 11);
            this.label4.TabIndex = 29;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Moon", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(605, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(8, 11);
            this.label5.TabIndex = 30;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Moon", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(605, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(8, 11);
            this.label6.TabIndex = 31;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Moon", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(605, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(8, 11);
            this.label7.TabIndex = 32;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Moon", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(605, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(8, 11);
            this.label8.TabIndex = 33;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Moon", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(605, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(8, 11);
            this.label9.TabIndex = 34;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Moon", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(605, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(8, 11);
            this.label10.TabIndex = 35;
            this.label10.Text = ":";
            // 
            // EditAgendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(879, 525);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.currentApps);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.beginAgenda);
            this.Controls.Add(this.addAuthorizedApp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.setAuthorizedApps);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.addEvent);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditAgendaForm";
            this.Text = "EditAgendaForm";
            this.TransparencyKey = System.Drawing.SystemColors.WindowFrame;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void timeFrame_Click(object sender, EventArgs e)
        {
        }

        private void eventName_TextChanged(object sender, EventArgs e)
        {
        }



        /*private System.Windows.Forms.Button addEvent;
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
private System.Windows.Forms.Button button1;*/
        private System.Windows.Forms.Button addMinute;
        private System.Windows.Forms.Label timeFrame;
        private System.Windows.Forms.Button addHour;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button lowerHour;
        private System.Windows.Forms.Button minus10Min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addEvent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label setAuthorizedApps;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addAuthorizedApp;
        private System.Windows.Forms.Button beginAgenda;
        private System.Windows.Forms.Label eventName;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label currentApps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}