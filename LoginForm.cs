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
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT; // أو DARK

            skinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter email and password.");
                return;
            }

            DatabaseHelper db = new DatabaseHelper();
            bool valid = db.ValidateUser(email, password);

            if (valid)
            {
                int userId = db.GetUserIdByEmail(email);
                MessageBox.Show("Login successful!");

                //// فتح MainForm وتمرير userId إليه لاحقًا
                MainForm mainForm = new MainForm(userId);
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials.");
            }
        }

        RegisterForm RegisterForm=new RegisterForm();
        private void newAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm.ShowDialog();
            this.Visible = true;

        }
    }


}
