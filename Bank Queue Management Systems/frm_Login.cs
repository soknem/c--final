using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Queue_Management_Systems
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoign_Click(object sender, EventArgs e)
        {
            string UserName = txtName.Text;
            string Pass = txtPassword.Text;
            if (UserName == "so" && Pass == "123")
            {
                this.Hide();
                new Setting().Show();
            }
            else
            {
                Mss.Text = "Enter Name and Password again";
                txtName.Clear();
                txtPassword.Clear();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPassword.Clear();
        }
    }
}
