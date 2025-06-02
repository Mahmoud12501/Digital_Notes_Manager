namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            this.cmbCategoryFilter = new MaterialSkin.Controls.MaterialComboBox();
            this.txtSearchTitle = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btnSearch = new MaterialSkin.Controls.MaterialButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1008, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.addNoteToolStripMenuItem.Text = "Add Note";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshNotesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // refreshNotesToolStripMenuItem
            // 
            this.refreshNotesToolStripMenuItem.Name = "refreshNotesToolStripMenuItem";
            this.refreshNotesToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.refreshNotesToolStripMenuItem.Text = "Refresh Notes";
            this.refreshNotesToolStripMenuItem.Click += new System.EventHandler(this.refreshNotesToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tileWindowsToolStripMenuItem,
            this.cascadeWindowsToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // tileWindowsToolStripMenuItem
            // 
            this.tileWindowsToolStripMenuItem.Name = "tileWindowsToolStripMenuItem";
            this.tileWindowsToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.tileWindowsToolStripMenuItem.Text = "Tile ";
            this.tileWindowsToolStripMenuItem.Click += new System.EventHandler(this.tileWindowsToolStripMenuItem_Click);
            // 
            // cascadeWindowsToolStripMenuItem
            // 
            this.cascadeWindowsToolStripMenuItem.Name = "cascadeWindowsToolStripMenuItem";
            this.cascadeWindowsToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.cascadeWindowsToolStripMenuItem.Text = "Cascade ";
            this.cascadeWindowsToolStripMenuItem.Click += new System.EventHandler(this.cascadeWindowsToolStripMenuItem_Click);
            // 
            // dgvNotes
            // 
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotes.Location = new System.Drawing.Point(3, 208);
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.RowHeadersWidth = 51;
            this.dgvNotes.RowTemplate.Height = 26;
            this.dgvNotes.Size = new System.Drawing.Size(1002, 364);
            this.dgvNotes.TabIndex = 1;
            this.dgvNotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotes_CellClick);
            // 
            // cmbCategoryFilter
            // 
            this.cmbCategoryFilter.AutoResize = false;
            this.cmbCategoryFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCategoryFilter.Depth = 0;
            this.cmbCategoryFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCategoryFilter.DropDownHeight = 174;
            this.cmbCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryFilter.DropDownWidth = 121;
            this.cmbCategoryFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCategoryFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCategoryFilter.FormattingEnabled = true;
            this.cmbCategoryFilter.IntegralHeight = false;
            this.cmbCategoryFilter.ItemHeight = 43;
            this.cmbCategoryFilter.Location = new System.Drawing.Point(69, 108);
            this.cmbCategoryFilter.MaxDropDownItems = 4;
            this.cmbCategoryFilter.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCategoryFilter.Name = "cmbCategoryFilter";
            this.cmbCategoryFilter.Size = new System.Drawing.Size(175, 49);
            this.cmbCategoryFilter.StartIndex = 0;
            this.cmbCategoryFilter.TabIndex = 2;
            this.cmbCategoryFilter.SelectedIndexChanged += new System.EventHandler(this.cmbCategoryFilter_SelectedIndexChanged);
            // 
            // txtSearchTitle
            // 
            this.txtSearchTitle.AnimateReadOnly = false;
            this.txtSearchTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSearchTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearchTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchTitle.Depth = 0;
            this.txtSearchTitle.HideSelection = true;
            this.txtSearchTitle.Location = new System.Drawing.Point(341, 108);
            this.txtSearchTitle.MaxLength = 32767;
            this.txtSearchTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearchTitle.Name = "txtSearchTitle";
            this.txtSearchTitle.PasswordChar = '\0';
            this.txtSearchTitle.ReadOnly = false;
            this.txtSearchTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchTitle.SelectedText = "";
            this.txtSearchTitle.SelectionLength = 0;
            this.txtSearchTitle.SelectionStart = 0;
            this.txtSearchTitle.ShortcutsEnabled = true;
            this.txtSearchTitle.Size = new System.Drawing.Size(362, 59);
            this.txtSearchTitle.TabIndex = 3;
            this.txtSearchTitle.TabStop = false;
            this.txtSearchTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchTitle.UseSystemPasswordChar = false;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearch.Depth = 0;
            this.btnSearch.HighEmphasis = true;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(727, 118);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearch.Size = new System.Drawing.Size(78, 36);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearch.UseAccentColor = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 605);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchTitle);
            this.Controls.Add(this.cmbCategoryFilter);
            this.Controls.Add(this.dgvNotes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshNotesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvNotes;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MaterialSkin.Controls.MaterialComboBox cmbCategoryFilter;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtSearchTitle;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeWindowsToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}