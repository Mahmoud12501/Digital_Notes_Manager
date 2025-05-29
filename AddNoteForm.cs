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
    public partial class AddNoteForm : MaterialForm
    {
        private int userId;

        public AddNoteForm()
        {
            InitializeComponent();

        }
        public AddNoteForm(int loggedInUserId)
        {
            InitializeComponent();
            userId = loggedInUserId;

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE
            );


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = textTitle.Text.Trim();
            string content = txtContent.Text.Trim();
            string category = cmbCategory.Text;
            DateTime reminderDate = dtReminder.Value;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            DatabaseHelper db = new DatabaseHelper();
            db.AddNote(title, content, category, DateTime.Now, reminderDate, userId);

            MessageBox.Show("Note saved successfully!");
            this.Close();
        }

     

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtReminder_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
