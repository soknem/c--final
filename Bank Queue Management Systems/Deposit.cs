﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Queue_Management_Systems
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void btnDclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDEnter_Click(object sender, EventArgs e)
        {
            PIN Pi = new PIN();
            Pi.Show();
        }
    }
}
