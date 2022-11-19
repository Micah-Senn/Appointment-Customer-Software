using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Software2
{
    public partial class TypeReport : Form
    {
        public TypeReport()
        {
            InitializeComponent();
            radioButtonJan.Checked = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void DisplayDGV()
        {
            var checkedButton = this.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked); // LAMBDA EXPLAIN HERE
            var tag = checkedButton.Tag;
            string sql = "datasource=localhost;Port=3306;Username=root;Password=Xmen1029$;Database=software2";
            MySqlConnection conn = new MySqlConnection(sql);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(DISTINCT type) AS 'Type Count' FROM appointment WHERE MONTH(start) = @month;";
            cmd.Parameters.Add("@month", MySqlDbType.Int16).Value = tag;
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridViewType.DataSource = dt;
        }

        private void TypeReport_Load(object sender, EventArgs e)
        {
            DisplayDGV();
        }
    }
}
