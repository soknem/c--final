using System;
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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void PClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(count < 4)
            {
                SlideShow.Image = imageList1.Images[count];
                count++;
            }
            else
            {
                count = 0;
            }
        }
        //public string displayNum { get; set; }
        Bank b = new Bank();
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //if (lblOne.Text == "show")
            //{
            //    lblOne.Text = b.ShowTicket.Text;
            //}
            //else if (labalTwo.Text == "show")
            //{
            //    labalTwo.Text = Program.bankQueue.Peek().ToString();
            //}
            //else if (labelthree.Text == "show")
            //{
            //    labelthree.Text = Program.bankQueue.Peek().ToString();
            //}
            //else if (labelfour.Text == "show")
            //{
            //    labelfour.Text = Program.bankQueue.Peek().ToString();
            //}
            //else
            //{
            //    return;
            //}
        }
    }
}
