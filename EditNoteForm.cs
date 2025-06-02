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
            this.TopLevel = true;
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
                richTextContent.Text = note["Content"].ToString();
                cmbCategory.Text = note["Category"].ToString();
                dtReminder.Value = Convert.ToDateTime(note["ReminderDate"]);
            }
            ////
            ///
            foreach (FontFamily font in FontFamily.Families)
            {
                cmbFonts.Items.Add(font.Name);
            }
            cmbFonts.SelectedIndex = 0;
            ////
            cmbFontSize.Items.AddRange(new object[] { "8", "10", "12", "14", "16", "18", "20", "24", "28", "32", "36" });
            cmbFontSize.SelectedItem = "12"; 

            foreach (FontFamily font in FontFamily.Families)
            {
                cmbFonts.Items.Add(font.Name);
            }
            cmbFonts.SelectedItem = "Arial";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = textTitle.Text.Trim();
            string content = richTextContent.Text.Trim();
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

        private void ToggleStyle(FontStyle style)
        {
            if (richTextContent.SelectionFont != null)
            {
                Font currentFont = richTextContent.SelectionFont;
                FontStyle newStyle = currentFont.Style ^ style;
                richTextContent.SelectionFont = new Font(currentFont, newStyle);
            }
        }


        private void Bold_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Bold);
        }

        private void Italic_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Italic);
        }

        private void Underline_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Underline);
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            string selectedFont = cmbFonts.SelectedItem.ToString();
            float currentSize = richTextContent.SelectionFont?.Size ?? 12;
            richTextContent.SelectionFont = new Font(selectedFont, currentSize);
        }

        private void cmbFontSize_Click(object sender, EventArgs e)
        {
            float size = float.Parse(cmbFontSize.SelectedItem.ToString());
            string fontName = richTextContent.SelectionFont?.FontFamily.Name ?? "Arial";
            richTextContent.SelectionFont = new Font(fontName, size);
        }
     

    }
}
