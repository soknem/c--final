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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void btnScounter_Click(object sender, EventArgs e)
        {
            Bank ba = new Bank();
            ba.Show();
        }

        private void btnSticket_Click(object sender, EventArgs e)
        {
            Ticket_System ts = new Ticket_System();
            ts.Show();
        }

        private void btnSdisplay_Click(object sender, EventArgs e)
        {
            Display di = new Display();
            di.Show();
        }

        private void PClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
