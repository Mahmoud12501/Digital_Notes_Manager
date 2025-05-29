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
    public partial class EditNoteForm : MaterialForm
    {
        private int noteId;

        public EditNoteForm(int selectedNoteId)
        {
            InitializeComponent();
            noteId = selectedNoteId;

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                Primary.Orange600, Primary.Orange700,
                Primary.Orange200, Accent.Orange100,
                TextShade.WHITE
            );
        }

        private void EditNoteForm_Load(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            var note = db.GetNoteById(noteId);

            if (note != null)
            {
                textTitle.Text = note["Title"].ToString();
                txtContent.Text = note["Content"].ToString();
                cmbCategory.Text = note["Category"].ToString();
                dtReminder.Value = Convert.ToDateTime(note["ReminderDate"]);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = textTitle.Text.Trim();
            string content = txtContent.Text.Trim();
            string category = cmbCategory.Text;
            DateTime reminder = dtReminder.Value;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            DatabaseHelper db = new DatabaseHelper();
            db.UpdateNote(noteId, title, content, category, reminder);

            MessageBox.Show("Note updated successfully!");
            this.Close();
        }
    }
 }
