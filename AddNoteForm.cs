using System;
using System.Drawing;
using System.IO;
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
            this.TopLevel = true;

        }
        public AddNoteForm(int loggedInUserId)
        {
            InitializeComponent();
            userId = loggedInUserId;

            var skinManager = MaterialSkinManager.Instance;
         
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
            string content = richTextContent.Text.Trim();
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
        private void AddNoteForm_Load(object sender, EventArgs e)
        {

            
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

        private void btnOpenFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string content = File.ReadAllText(openFileDialog.FileName);
                richTextContent.Text = content;
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, richTextContent.Text);
                MessageBox.Show("Note saved successfully to file!");
            }
        }
    }
}
