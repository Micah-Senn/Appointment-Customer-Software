using MySql.Data.MySqlClient;
using Software2.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Software2
{
    public partial class Calender : Form
    {
        public Calender()
        {
            InitializeComponent();
            radioAll.Checked = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void DisplayLAMBDA()
        {
            var checkedButton = this.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked); // LAMBDA EXPRESSION. I saved dozens of lines of codes by using a lambda to determine the radio button selected then passing the button specific queries through a variable in the buttons Tag attribute.
            string tag = checkedButton.Tag.ToString();
            MySqlConnection conn = SQL.GetConnection();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT appointmentId AS 'Appointment ID', userId AS 'User ID', customerId AS 'Customer ID', description AS 'Description', type AS 'Type', start AS 'Start Time', end AS 'End Time' FROM software2.appointment {tag};";
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridViewCal.DataSource = dt;
        }

        private void Calender_Load(object sender, EventArgs e)
        {
            DisplayLAMBDA();
        }

        private void radioAll_CheckedChanged(object sender, EventArgs e)
        {
            DisplayLAMBDA();
        }

        private void radioWeek_CheckedChanged(object sender, EventArgs e)
        {
            DisplayLAMBDA();
        }

        private void radioMonth_CheckedChanged(object sender, EventArgs e)
        {
            DisplayLAMBDA();
        }

        private void dataGridViewCal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is DateTime dt)
            {
                e.Value = dt.ToLocalTime();
            }
        }
    }
}
