using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

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
             string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
             MySqlConnection con = new MySqlConnection(connectionString);
            
            string sqlStringApp = "SELECT * FROM appointment";
             MySqlCommand cmda = new MySqlCommand(sqlStringApp, con);
             MySqlDataAdapter adpa = new MySqlDataAdapter(cmda);
            DataTable dt = new DataTable();
            adpa.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DateTime y = (DateTime)dt.Rows[i]["start"];
                dt.Rows[i]["start"] = y.ToLocalTime();
            }
            AppointmentGridView.DataSource = dt;

            string sqlStringCus = "SELECT * FROM customer";
             MySqlCommand cmdc = new MySqlCommand(sqlStringCus, con);
            MySqlDataAdapter adpc = new MySqlDataAdapter(cmdc);
            DataTable dt2 = new DataTable();
            adpc.Fill(dt2);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DateTime y = (DateTime)dt.Rows[i]["CreateDate"];
                dt2.Rows[i]["CreateDate"] = y.ToLocalTime();
            }
            CustomersGridView.DataSource = dt2;
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
            new Calender().Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new SchedulingReport().Show();
        }

        private void buttonModCus_Click(object sender, EventArgs e)
        {
            new ModCustomer().Show();
        }

        private void buttonAddCus_Click(object sender, EventArgs e)
        {
            new AddCustomer().Show();
        }

        private void buttonType_Click(object sender, EventArgs e)
        {
            new TypeReport().Show();
        }

        private void buttonCusReport_Click(object sender, EventArgs e)
        {
            new CustomerReport().Show();
        }

        private void AppointmentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
