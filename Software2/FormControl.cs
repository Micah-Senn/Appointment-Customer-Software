﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using Software2.Database;

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

            string sqlStringApp = "SELECT appointmentId AS 'Appointment ID', customerId AS 'Customer ID', userId AS 'User ID', title AS Title, type AS Type, start AS 'Start Time', end AS 'End Time' FROM appointment";
            MySqlCommand cmda = new MySqlCommand(sqlStringApp, con);
            MySqlDataAdapter adpa = new MySqlDataAdapter(cmda);
            DataTable dt = new DataTable();
            adpa.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DateTime y = (DateTime)dt.Rows[i]["Start Time"];
                dt.Rows[i]["Start Time"] = y.ToLocalTime();
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DateTime y = (DateTime)dt.Rows[i]["End Time"];
                dt.Rows[i]["End Time"] = y.ToLocalTime();
            }
            AppointmentGridView.DataSource = dt;    
        }

        public void Display()
        {
            string query = "SELECT customer.customerId AS 'Customer ID', customer.customerName AS 'Customer Name', customer.addressId AS 'Address ID', city.cityID AS 'City ID', country.countryId AS 'Country ID', " +
               "address.phone AS 'Phone Number', customer.active AS Active FROM customer " +
               "LEFT JOIN address ON customer.addressId = address.addressId " +
               "LEFT JOIN city ON address.cityId = city.cityId " +
               "LEFT JOIN country ON city.countryId = country.countryId";
            DbCustomer.DisplayCustomer(query, CustomersGridView);
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
            if (CustomersGridView.Rows.Count == 0)
            {
                MessageBox.Show("The customer table is empty", "Invalid command"); 
            }
            else
            {
                string CusID = CustomersGridView.CurrentRow.Cells[0].Value.ToString();
                string AddrID = CustomersGridView.CurrentRow.Cells[2].Value.ToString();
                string CityID = CustomersGridView.CurrentRow.Cells[3].Value.ToString();
                string CountryID = CustomersGridView.CurrentRow.Cells[4].Value.ToString();
                ModCustomer modcus = new ModCustomer(this);
                modcus.CusId = CusID;
                modcus.AddrId = AddrID;
                modcus.CityId = CityID;
                modcus.CountryId = CountryID;
                modcus.Show();
            }
           
        }

        private void buttonAddCus_Click(object sender, EventArgs e)
        {
            AddCustomer AddCustomerForm = new AddCustomer(this);
            AddCustomerForm.Show();
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

        private void FormControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormControl_Shown(object sender, EventArgs e)
        {
            Display();
        }
        private void buttonDeleteCus_Click(object sender, EventArgs e)
        {
            var confirmDelete = MessageBox.Show("Are you sure you want to delete this item?", "Confirm deletion", MessageBoxButtons.OKCancel);
            if (confirmDelete == DialogResult.Cancel)
            {
                return;
            }

            if (confirmDelete == DialogResult.OK && CustomersGridView.Rows.Count > 0)
            {
                DbCustomer.DeleteCustomer(CustomersGridView.CurrentRow.Cells[0].Value.ToString());
                DbAddress.DeleteAddress(CustomersGridView.CurrentRow.Cells[2].Value.ToString());
                DbCity.DeleteCity(CustomersGridView.CurrentRow.Cells[3].Value.ToString());
                DbCountry.DeleteCountry(CustomersGridView.CurrentRow.Cells[4].Value.ToString());
            }
            else
            {
                MessageBox.Show("No rows to delete", "Invalid deletion");

            }
            Display();
        }

        private void CustomersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
