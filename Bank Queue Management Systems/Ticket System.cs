using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static Bank_Queue_Management_Systems.Queues;

namespace Bank_Queue_Management_Systems
{
    public partial class Ticket_System : Form
    {
        //private Queue<int> queue = new Queue<int>();
        //private int currentNumber = 1;

        public Ticket_System()
        {
            InitializeComponent();
        }

        private void btnT_Click(object sender, EventArgs e)
        {

            if (btnT.Text == "Khmer")
            {
                btnT.Text = "English";
                btnDeposit.Text = "ដាក់ប្រាក់";
                btnRegister.Text = "បង្កើតគណនី";
                btnTransfers.Text = "ការផ្ទេរប្រាក់";
                btnUtilities.Text = "បង់ទឹក នឹងបង់ផ្លើង";
                btnWithdraw.Text = "ដកប្រាក់";
                btnOther.Text = "ផ្សេងៗ";
                lblTicker.Text = "សំបុត្រ";
            }
            else if (btnT.Text == "English")
            {
                btnT.Text = "Khmer";
                btnDeposit.Text = "Deposit";
                btnRegister.Text = "Register";
                btnTransfers.Text = "Transfers";
                btnUtilities.Text = "Utilities";
                btnWithdraw.Text = "Withdraw";
                btnOther.Text = "Other";
                lblTicker.Text = "Ticker";
            }
        }

        private void PClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        int currentNumber = 1;
        int numberOfNumbersToGenerate = 1;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            

            for ( int i = 0; i < numberOfNumbersToGenerate; i++)
            {
                
                Program.bankQueue.Enqueue(currentNumber);
                currentNumber++;
            }

            lblTicker.Text = "R - " + (currentNumber - 1).ToString();

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numberOfNumbersToGenerate; i++)
            {
                Program.bankQueue.Enqueue(currentNumber);
                currentNumber++;
            }
            lblTicker.Text = "R - " + (currentNumber-1).ToString();
        }


        private void btnTransfers_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numberOfNumbersToGenerate; i++)
            {
                Program.bankQueue.Enqueue(currentNumber);
                currentNumber++;
            }
            lblTicker.Text = "R- : " + (currentNumber - 1).ToString();
        }

        private void btnUtilities_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numberOfNumbersToGenerate; i++)
            {
                Program.bankQueue.Enqueue(currentNumber);
                currentNumber++;
            }
            lblTicker.Text = "R- : " + (currentNumber - 1).ToString();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numberOfNumbersToGenerate; i++)
            {
                Program.bankQueue.Enqueue(currentNumber);
                currentNumber++;
            }
            lblTicker.Text = "R- : " + (currentNumber - 1).ToString();
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numberOfNumbersToGenerate; i++)
            {
                Program.bankQueue.Enqueue(currentNumber);
                currentNumber++;
            }
            lblTicker.Text = "R- : " + (currentNumber - 1).ToString();
        }
    }
}
