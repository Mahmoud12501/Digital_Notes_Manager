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
            cmbCategoryFilter.Items.Add("All");
            cmbCategoryFilter.Items.Add("Work");
            cmbCategoryFilter.Items.Add("Study");
            cmbCategoryFilter.Items.Add("Personal");
            cmbCategoryFilter.SelectedIndex = 0; // "All"

            LoadNotes(); // تحميل الملاحظات
        }

        private void LoadNotes()
        {
            string category = cmbCategoryFilter.SelectedItem?.ToString() ?? "All";
            string search = txtSearchTitle.Text.Trim();

            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.GetFilteredNotes(userId, category, search);
            dgvNotes.DataSource = dt;

            // حذف وإعادة إضافة أعمدة Edit/Delete
            foreach (DataGridViewColumn col in dgvNotes.Columns.Cast<DataGridViewColumn>().ToList())
            {
                if (col.Name == "Edit" || col.Name == "Delete")
                    dgvNotes.Columns.Remove(col);
            }

            DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn
            {
                HeaderText = "Edit",
                Text = "Edit",
                Name = "Edit",
                UseColumnTextForButtonValue = true
            };
            dgvNotes.Columns.Add(editBtn);

            DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn
            {
                HeaderText = "Delete",
                Text = "Delete",
                Name = "Delete",
                UseColumnTextForButtonValue = true
            };
            dgvNotes.Columns.Add(deleteBtn);
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

        private void cmbCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNotes();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadNotes();
        }

        private void tileWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal); // TileVertical
        }

        private void cascadeWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void CheckReminders()
        {
            DatabaseHelper db = new DatabaseHelper();
            var notesDue = db.GetDueReminders(userId, DateTime.Today);
            foreach (DataRow row in notesDue.Rows)
            {
                string title = row["Title"].ToString();
                DateTime reminderDate = Convert.ToDateTime(row["ReminderDate"]);

                MessageBox.Show($"🔔 Reminder: {title} is due today ({reminderDate:dd/MM/yyyy})",
                                "Note Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckReminders();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.ShowDialog();

        }
    }
}


