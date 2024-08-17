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
    public partial class PIN : Form
    {
        public PIN()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtPin.Text = txtPin.Text + button.Text;
        }

        private void PClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            txtPin.Clear();
        }
    }
}
