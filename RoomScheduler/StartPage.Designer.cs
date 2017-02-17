namespace RoomScheduler
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.btnBookRoom = new System.Windows.Forms.Button();
            this.btnSeeSchedule = new System.Windows.Forms.Button();
            this.btnViewRecords = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBookRoom
            // 
            this.btnBookRoom.BackColor = System.Drawing.Color.Silver;
            this.btnBookRoom.Location = new System.Drawing.Point(5, 19);
            this.btnBookRoom.Name = "btnBookRoom";
            this.btnBookRoom.Size = new System.Drawing.Size(200, 50);
            this.btnBookRoom.TabIndex = 0;
            this.btnBookRoom.Text = "Book Room";
            this.btnBookRoom.UseVisualStyleBackColor = false;
            this.btnBookRoom.Click += new System.EventHandler(this.btnBookRoom_Click);
            // 
            // btnSeeSchedule
            // 
            this.btnSeeSchedule.BackColor = System.Drawing.Color.Silver;
            this.btnSeeSchedule.ForeColor = System.Drawing.Color.Black;
            this.btnSeeSchedule.Location = new System.Drawing.Point(5, 72);
            this.btnSeeSchedule.Name = "btnSeeSchedule";
            this.btnSeeSchedule.Size = new System.Drawing.Size(200, 50);
            this.btnSeeSchedule.TabIndex = 0;
            this.btnSeeSchedule.Text = "See Schedule";
            this.btnSeeSchedule.UseVisualStyleBackColor = false;
            this.btnSeeSchedule.Click += new System.EventHandler(this.btnSeeSchedule_Click);
            // 
            // btnViewRecords
            // 
            this.btnViewRecords.BackColor = System.Drawing.Color.Silver;
            this.btnViewRecords.Location = new System.Drawing.Point(5, 125);
            this.btnViewRecords.Name = "btnViewRecords";
            this.btnViewRecords.Size = new System.Drawing.Size(200, 50);
            this.btnViewRecords.TabIndex = 0;
            this.btnViewRecords.Text = "View Rooms";
            this.btnViewRecords.UseVisualStyleBackColor = false;
            this.btnViewRecords.Click += new System.EventHandler(this.btnViewRecords_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.btnQuit);
            this.groupBox1.Controls.Add(this.btnViewRecords);
            this.groupBox1.Controls.Add(this.btnSeeSchedule);
            this.groupBox1.Controls.Add(this.btnBookRoom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(28, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 234);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select an Option";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Silver;
            this.btnQuit.Location = new System.Drawing.Point(5, 178);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(200, 50);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(263, 250);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartPage";
            this.Text = "Room Scheduler";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBookRoom;
        private System.Windows.Forms.Button btnSeeSchedule;
        private System.Windows.Forms.Button btnViewRecords;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuit;
    }
}