using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Software2
{
    public partial class AddCustomer : Form
    {
        private readonly FormControl _parent;
        public AddCustomer(FormControl parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxCusName.Text.Length < 1)
            {
                MessageBox.Show("Student Name is empty.");
                return;
            }

            Address addr = new Address(textBoxAdd1.Text, textBoxAdd2.Text, textBoxZip.Text, textBoxPhone.Text);
            Customer cus = new Customer(textBoxCusName.Text, comboBoxActive.SelectedIndex);
            DbCustomer.AddCustomer(cus);
            DbAddress.AddAddress(addr);
            _parent.Display();
            this.Close();
        }
    }
}
