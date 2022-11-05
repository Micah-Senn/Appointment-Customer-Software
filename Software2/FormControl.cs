using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Software2
{
    public partial class FormControl : Form
    {
        
        public FormControl()
        {
            InitializeComponent();
        }

        private void FormControl_Load(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddApp_Click(object sender, EventArgs e)
        {
            new AddAppointment().Show();
        }

        private void buttonModifyApp_Click(object sender, EventArgs e)
        {
            new ModAppointment().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
