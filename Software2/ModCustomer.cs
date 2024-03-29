﻿using MySql.Data.MySqlClient;
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
    public partial class ModCustomer : Form
    {
        private readonly FormControl _parent;
        public string CusId { get; set; }
        public string AddrId { get; set; }
        public string CityId { get; set; }
        public string CountryId { get; set; }

        public ModCustomer(FormControl parent)
        {
            InitializeComponent();
            _parent = parent;



        }

        private void ModCustomer_Load(object sender, EventArgs e)
        {
           textBoxCusId.Text = this.CusId;
            string getName = ($"SELECT customerName FROM customer WHERE customerId = ({this.CusId})");
            string getAdd1 = ($"SELECT address FROM address WHERE addressId = ({this.AddrId})");
            string getAdd2 = ($"SELECT address2 FROM address WHERE addressId = ({this.AddrId})");
            string getCity = ($"SELECT city FROM city WHERE cityId = ({this.CityId})");
            string getCountry = ($"SELECT country FROM country WHERE countryId = ({this.CountryId})");
            string getZip = ($"SELECT postalCode FROM address WHERE addressId = ({this.AddrId})");
            string getPhone = ($"SELECT phone FROM address WHERE addressId = ({this.AddrId})");
            string getActive = ($"SELECT active FROM customer WHERE addressId = ({this.AddrId})");
            textBoxCusName.Text = SQL.getSQL(getName);
            textBoxAdd1.Text = SQL.getSQL(getAdd1);
            textBoxAdd2.Text = SQL.getSQL(getAdd2);
            textBoxCity.Text = SQL.getSQL(getCity);
            textBoxCountry.Text = SQL.getSQL(getCountry);
            textBoxZip.Text = SQL.getSQL(getZip);
            textBoxPhone.Text = SQL.getSQL(getPhone);
            comboBoxActive.SelectedIndex = SQL.getIntSQL(getActive);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCusName.Text) ||
               string.IsNullOrEmpty(textBoxAdd1.Text) ||
               string.IsNullOrEmpty(textBoxAdd2.Text) ||
               string.IsNullOrEmpty(textBoxCity.Text) ||
               string.IsNullOrEmpty(textBoxCountry.Text) ||
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
            Customer cus = new Customer(textBoxCusName.Text, comboBoxActive.SelectedIndex);
            Address addr = new Address(textBoxAdd1.Text, textBoxAdd2.Text, textBoxZip.Text, textBoxPhone.Text);
            City city = new City(textBoxCity.Text);
            Country country = new Country(textBoxCountry.Text);

            string cusId = this.CusId;
            string addrId = this.AddrId;
            string cityId = this.CityId;
            string countryId = this.CountryId;
            DbCustomer.UpdateCustomer(cus, cusId);
            DbAddress.UpdateAddress(addr, addrId);
            DbCity.UpdateCity(city, cityId);
            DbCountry.UpdateCountry(country, countryId);
            _parent.DisplayCus();
            this.Close();
        }

        
    }
}
