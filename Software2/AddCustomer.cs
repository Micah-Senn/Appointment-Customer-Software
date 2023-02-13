using MySql.Data.MySqlClient;
using Software2.Database;
using Software2.DbClasses;
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
        public static int getID(string id, string table)
        {
            MySqlConnection conn = SQL.GetConnection();
            string query = $"SELECT max({id}) FROM {table}";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                rdr.Read();
                if (rdr[0] == DBNull.Value)
                {

                    return 0;
                }


                return Convert.ToInt32(rdr[0]); ;


            }

            return 0;
        }
        int customerId = getID("customerId", "customer") + 1;

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCusName.Text) ||
                string.IsNullOrEmpty(textBoxAdd1.Text) ||
                string.IsNullOrEmpty(textBoxCity.Text) ||
                string.IsNullOrEmpty(comboBoxState.Text) ||
                string.IsNullOrEmpty(textBoxZip.Text) ||
                string.IsNullOrEmpty(textBoxPhone.Text) ||
                (comboBoxActive.SelectedItem == null))
            {
                MessageBox.Show("Please fill out all fields");
                return;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxZip.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter a valid zip code", "Invalid entry");
                textBoxZip.Text = textBoxZip.Text.Remove(textBoxZip.Text.Length - 1);
            }
            Address addr = new Address(textBoxAdd1.Text, textBoxZip.Text, textBoxCity.Text, comboBoxState.Text,  textBoxPhone.Text);
            Customer cus = new Customer(textBoxCusName.Text, comboBoxActive.SelectedIndex);
            DbAddress.AddAddress(addr);
            DbCustomer.AddCustomer(cus);
            _parent.DisplayCus();
            this.Close();
        }

        private void textBoxPhone_MouseDown(object sender, MouseEventArgs e)
        {

            if (textBoxPhone.Text.Length == 0)
            {
                textBoxPhone.Focus();
                textBoxPhone.SelectionStart = 0;

            }
        }

        private void labelCountry_Click(object sender, EventArgs e)
        {
            
        }
    }
}

