using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace WindowsFormsApp1
{
    public partial class RegisterForm : MaterialForm
    {
        public RegisterForm()
        {
            InitializeComponent();

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                Primary.Green600, Primary.Green700,
                Primary.Green200, Accent.LightGreen200,
                TextShade.WHITE
            );
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            DatabaseHelper db = new DatabaseHelper();

            if (db.IsEmailExist(email))
            {
                MessageBox.Show("Email already registered.");
                return;
            }

            db.RegisterUser(email, password);
            MessageBox.Show("Registration successful!");

            this.Close(); 
        }
    }
} 

