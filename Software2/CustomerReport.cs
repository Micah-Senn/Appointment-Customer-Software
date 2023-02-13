using MySql.Data.MySqlClient;
using Software2.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Software2
{
    public partial class CustomerReport : Form
    {
        public CustomerReport()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerReport_Load(object sender, EventArgs e)
        {
            LoadCustomersId();

        }
        public void DisplayDGV()
        {
            MySqlConnection conn = SQL.GetConnection();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT appointmentId AS 'Appointment ID',userId AS 'User ID',  customer.customerName AS 'Customer Name', car AS 'Vehicle', type AS 'Type', start AS 'Start Time', " +
                "end AS 'End Time' FROM software2.appointment LEFT JOIN customer ON appointment.customerId = @customerId";
            cmd.Parameters.Add("@customerId", MySqlDbType.Int16).Value = comboBoxCus.SelectedIndex + 1;
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridViewCus.DataSource = dt;
        }

        private void comboBoxCus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayDGV();
            labelSel.Hide();
            this.Refresh();
        }

        private void dataGridViewCus_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is DateTime dt)
            {
                e.Value = dt.ToLocalTime();
            }
        }
        private void LoadCustomersId()
        {
            using (var connection = SQL.GetConnection())
            {
                var query = "SELECT customerId FROM customer";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        //Iterate through the rows and add it to the combobox's items
                        while (reader.Read())
                        {
                            comboBoxCus.Items.Add(reader.GetString("customerId"));
                        }
                    }
                }
            }
        }

        private void dataGridViewCus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
