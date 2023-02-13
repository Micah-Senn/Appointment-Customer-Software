using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Software2
{

    public partial class FormLogin : Form
    {
        public static int userId;
        public string error = "The username or password you entered was incorrect";
        public FormLogin()
        {
            InitializeComponent();


            if (RegionInfo.CurrentRegion.EnglishName == "Mexico")
            {
                labelLanguage.Text = "Idioma Actual: Español";
                labelLogin.Text = "Inicio de sesión del sistema";
                textBoxUser.PlaceholderText = "Introduzca su nombre de usuario:";
                textBoxPass.PlaceholderText = "Introducir la contraseña:";
                buttonLogin.Text = "Acceso";
                buttonClear.Text = "Claro";
                buttonExit.Text = "Salida";
                this.Text = "Acceso";
                error = "El nombre de usuario o contraseña que ingresaste es incorrecto";
            }
            else
            {
                labelLanguage.Text = "Current Language: English";
                labelLogin.Text = "System Login";
                textBoxUser.PlaceholderText = "Enter Username";
                textBoxPass.PlaceholderText = "Enter Password";
                buttonLogin.Text = "Login";
                buttonClear.Text = "Clear";
                buttonExit.Text = "Exit";
                this.Text = "Login";
            }

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            using (StreamWriter txt = new StreamWriter("login.txt", true))
            {
                string time = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
                txt.WriteLine(string.Format("Login Attempt {0}--{1}:{2} {3}:{4}", time, "Username:", textBoxUser.Text, "Password", textBoxPass.Text));

            }
            if (textBoxUser.Text == "test" && textBoxPass.Text == "test")
            {
                userId = 1;
                new FormControl().Show();
                this.Hide();
            }
            else if (textBoxUser.Text == "admin" && textBoxPass.Text == "admin")
            {
                userId = 2;
                new FormControl().Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show(error);
            }


        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUser.Clear();
            textBoxPass.Clear();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
        
}
