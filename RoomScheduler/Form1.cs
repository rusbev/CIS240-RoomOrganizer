﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomScheduler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bellvue Room Booked\n2:00PM-3:00PM", "Booking Confirmation", MessageBoxButtons.OKCancel);
        }
    }
}
