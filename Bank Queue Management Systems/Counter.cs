using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bank_Queue_Management_Systems
{
    public partial class Bank : Form
    {
        public Bank()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register Re = new Register();
            Re.Show();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Deposit De = new Deposit();
            De.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw Wi = new Withdraw();
            Wi.Show();
        }

        private void btnTransfers_Click(object sender, EventArgs e)
        {
            Transfers Tr = new Transfers();
            Tr.Show();
        }

        private void btnUtilities_Click(object sender, EventArgs e)
        {
            Utility Ut = new Utility();
            Ut.Show();
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            Setting st = new Setting();
            st.Show();
        }

        private void PClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Display frm = new Display();
            ShowTicket.Text = "R-" + Program.bankQueue.Peek().ToString();
            
            Program.bankQueue.Dequeue();
        }

        private void btnDis_Click(object sender, EventArgs e)
        {
            //Display frm = new Display();
            //frm.Show();
            //if (frm.lblOne.Text == "show")
            //{
            //    frm.lblOne.Text = ShowTicket.Text;
            //}
            //else if (frm.labalTwo.Text == "show")
            //{
            //    frm.labalTwo.Text = ShowTicket.Text;
            //}
            //else if (frm.labelthree.Text == "show")
            //{
            //    frm.labelthree.Text = ShowTicket.Text;
            //}
            //else if (frm.labelfour.Text == "show")
            //{
            //    frm.labelfour.Text = Program.bankQueue.Peek().ToString();
            //}
            //else
            //{
            //    return;
            //}
        }
    }
}
