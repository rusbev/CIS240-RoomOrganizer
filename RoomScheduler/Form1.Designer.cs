namespace RoomScheduler
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
            this.lbxRooms = new System.Windows.Forms.ListBox();
            this.lbxDescription = new System.Windows.Forms.ListBox();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.rbt10 = new System.Windows.Forms.RadioButton();
            this.rbt20 = new System.Windows.Forms.RadioButton();
            this.rbt30 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxProjector = new System.Windows.Forms.CheckBox();
            this.cbxPhone = new System.Windows.Forms.CheckBox();
            this.cbxNoChairs = new System.Windows.Forms.CheckBox();
            this.btnViewRoom = new System.Windows.Forms.Button();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.cmbxStartTime = new System.Windows.Forms.ComboBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.cmbxEndTime = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.cbxFoldingTable = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxRooms
            // 
            this.lbxRooms.BackColor = System.Drawing.Color.Silver;
            this.lbxRooms.FormattingEnabled = true;
            this.lbxRooms.Items.AddRange(new object[] {
            "Bellvue Room",
            "Wilmington Room",
            "Room 216"});
            this.lbxRooms.Location = new System.Drawing.Point(254, 9);
            this.lbxRooms.Name = "lbxRooms";
            this.lbxRooms.Size = new System.Drawing.Size(289, 277);
            this.lbxRooms.TabIndex = 0;
            // 
            // lbxDescription
            // 
            this.lbxDescription.BackColor = System.Drawing.Color.Silver;
            this.lbxDescription.FormattingEnabled = true;
            this.lbxDescription.Items.AddRange(new object[] {
            "Bellvue Room",
            "Seats up to 20",
            "Has Projector"});
            this.lbxDescription.Location = new System.Drawing.Point(254, 303);
            this.lbxDescription.Name = "lbxDescription";
            this.lbxDescription.Size = new System.Drawing.Size(291, 108);
            this.lbxDescription.TabIndex = 1;
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.Silver;
            this.btnBooking.Location = new System.Drawing.Point(452, 417);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(91, 23);
            this.btnBooking.TabIndex = 2;
            this.btnBooking.Text = "Book Room";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Silver;
            this.btnQuit.Location = new System.Drawing.Point(254, 417);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // rbt10
            // 
            this.rbt10.AutoSize = true;
            this.rbt10.Location = new System.Drawing.Point(12, 19);
            this.rbt10.Name = "rbt10";
            this.rbt10.Size = new System.Drawing.Size(70, 17);
            this.rbt10.TabIndex = 4;
            this.rbt10.TabStop = true;
            this.rbt10.Text = "10 or less";
            this.rbt10.UseVisualStyleBackColor = true;
            // 
            // rbt20
            // 
            this.rbt20.AutoSize = true;
            this.rbt20.Location = new System.Drawing.Point(12, 38);
            this.rbt20.Name = "rbt20";
            this.rbt20.Size = new System.Drawing.Size(70, 17);
            this.rbt20.TabIndex = 4;
            this.rbt20.TabStop = true;
            this.rbt20.Text = "20 or less";
            this.rbt20.UseVisualStyleBackColor = true;
            // 
            // rbt30
            // 
            this.rbt30.AutoSize = true;
            this.rbt30.Location = new System.Drawing.Point(12, 59);
            this.rbt30.Name = "rbt30";
            this.rbt30.Size = new System.Drawing.Size(70, 17);
            this.rbt30.TabIndex = 4;
            this.rbt30.TabStop = true;
            this.rbt30.Text = "30 or less";
            this.rbt30.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbt10);
            this.groupBox1.Controls.Add(this.rbt20);
            this.groupBox1.Controls.Add(this.rbt30);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 91);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Number of people";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxFoldingTable);
            this.groupBox2.Controls.Add(this.cbxNoChairs);
            this.groupBox2.Controls.Add(this.cbxPhone);
            this.groupBox2.Controls.Add(this.cbxProjector);
            this.groupBox2.Location = new System.Drawing.Point(13, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 108);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hardware";
            // 
            // cbxProjector
            // 
            this.cbxProjector.AutoSize = true;
            this.cbxProjector.Location = new System.Drawing.Point(12, 18);
            this.cbxProjector.Name = "cbxProjector";
            this.cbxProjector.Size = new System.Drawing.Size(68, 17);
            this.cbxProjector.TabIndex = 0;
            this.cbxProjector.Text = "Projector";
            this.cbxProjector.UseVisualStyleBackColor = true;
            // 
            // cbxPhone
            // 
            this.cbxPhone.AutoSize = true;
            this.cbxPhone.Location = new System.Drawing.Point(11, 41);
            this.cbxPhone.Name = "cbxPhone";
            this.cbxPhone.Size = new System.Drawing.Size(115, 17);
            this.cbxPhone.TabIndex = 0;
            this.cbxPhone.Text = "Conference Phone";
            this.cbxPhone.UseVisualStyleBackColor = true;
            // 
            // cbxNoChairs
            // 
            this.cbxNoChairs.AutoSize = true;
            this.cbxNoChairs.Location = new System.Drawing.Point(12, 64);
            this.cbxNoChairs.Name = "cbxNoChairs";
            this.cbxNoChairs.Size = new System.Drawing.Size(71, 17);
            this.cbxNoChairs.TabIndex = 0;
            this.cbxNoChairs.Text = "No chairs";
            this.cbxNoChairs.UseVisualStyleBackColor = true;
            // 
            // btnViewRoom
            // 
            this.btnViewRoom.BackColor = System.Drawing.Color.Silver;
            this.btnViewRoom.Location = new System.Drawing.Point(353, 417);
            this.btnViewRoom.Name = "btnViewRoom";
            this.btnViewRoom.Size = new System.Drawing.Size(77, 23);
            this.btnViewRoom.TabIndex = 2;
            this.btnViewRoom.Text = "View Room";
            this.btnViewRoom.UseVisualStyleBackColor = false;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(10, 224);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(55, 13);
            this.lblStartTime.TabIndex = 7;
            this.lblStartTime.Text = "Start Time";
            // 
            // cmbxStartTime
            // 
            this.cmbxStartTime.FormattingEnabled = true;
            this.cmbxStartTime.Items.AddRange(new object[] {
            "2:00PM"});
            this.cmbxStartTime.Location = new System.Drawing.Point(71, 221);
            this.cmbxStartTime.Name = "cmbxStartTime";
            this.cmbxStartTime.Size = new System.Drawing.Size(68, 21);
            this.cmbxStartTime.TabIndex = 8;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(12, 256);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(52, 13);
            this.lblEndTime.TabIndex = 9;
            this.lblEndTime.Text = "End Time";
            // 
            // cmbxEndTime
            // 
            this.cmbxEndTime.FormattingEnabled = true;
            this.cmbxEndTime.Items.AddRange(new object[] {
            "3:00PM"});
            this.cmbxEndTime.Location = new System.Drawing.Point(70, 253);
            this.cmbxEndTime.Name = "cmbxEndTime";
            this.cmbxEndTime.Size = new System.Drawing.Size(69, 21);
            this.cmbxEndTime.TabIndex = 10;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(15, 278);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // cbxFoldingTable
            // 
            this.cbxFoldingTable.AutoSize = true;
            this.cbxFoldingTable.Location = new System.Drawing.Point(12, 85);
            this.cbxFoldingTable.Name = "cbxFoldingTable";
            this.cbxFoldingTable.Size = new System.Drawing.Size(95, 17);
            this.cbxFoldingTable.TabIndex = 1;
            this.cbxFoldingTable.Text = "Folding Tables";
            this.cbxFoldingTable.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(557, 452);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.cmbxEndTime);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.cmbxStartTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnViewRoom);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.lbxDescription);
            this.Controls.Add(this.lbxRooms);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Scheduler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxRooms;
        private System.Windows.Forms.ListBox lbxDescription;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.RadioButton rbt10;
        private System.Windows.Forms.RadioButton rbt20;
        private System.Windows.Forms.RadioButton rbt30;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbxNoChairs;
        private System.Windows.Forms.CheckBox cbxPhone;
        private System.Windows.Forms.CheckBox cbxProjector;
        private System.Windows.Forms.Button btnViewRoom;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.ComboBox cmbxStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.ComboBox cmbxEndTime;
        private System.Windows.Forms.CheckBox cbxFoldingTable;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

