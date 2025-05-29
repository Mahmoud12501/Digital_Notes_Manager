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
    public partial class MainForm : MaterialForm
    {
        
        private int userId;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(int loggedInUserId)
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.GetNotesByUser(userId);
            dgvNotes.DataSource = dt;
        }

        private void LoadNotes()
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.GetNotesByUser(userId);
            dgvNotes.DataSource = dt;

            // امسح الأعمدة التفاعلية أولًا عشان ما تتكرر
            if (!dgvNotes.Columns.Contains("Edit"))
            {
                DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
                editBtn.HeaderText = "Edit";
                editBtn.Text = "Edit";
                editBtn.UseColumnTextForButtonValue = true;
                dgvNotes.Columns.Add(editBtn);
            }

            if (!dgvNotes.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
                deleteBtn.HeaderText = "Delete";
                deleteBtn.Text = "Delete";
                deleteBtn.UseColumnTextForButtonValue = true;
                dgvNotes.Columns.Add(deleteBtn);
            }
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNoteForm form = new AddNoteForm(userId);
            form.FormClosed += (s, args) => LoadNotes();
            form.ShowDialog();

        }

        private void refreshNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadNotes();
        }

        private void dgvNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedNoteId = Convert.ToInt32(dgvNotes.Rows[e.RowIndex].Cells["NoteID"].Value);

                // تعديل
                if (dgvNotes.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    EditNoteForm editForm = new EditNoteForm(selectedNoteId);
                    editForm.FormClosed += (s, args) => LoadNotes();
                    editForm.ShowDialog();
                }

                // حذف
                else if (dgvNotes.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    var confirm = MessageBox.Show("Are you sure you want to delete this note?", "Confirm", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        DatabaseHelper db = new DatabaseHelper();
                        db.DeleteNote(selectedNoteId);
                        LoadNotes();
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
