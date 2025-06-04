namespace WindowsFormsApp1
{
    partial class AddNoteForm
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
            this.textTitle = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dtReminder = new System.Windows.Forms.DateTimePicker();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.richTextContent = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Bold = new System.Windows.Forms.ToolStripButton();
            this.Italic = new System.Windows.Forms.ToolStripButton();
            this.Underline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbFonts = new System.Windows.Forms.ToolStripComboBox();
            this.cmbFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.btnOpenFromFile = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveToFile = new MaterialSkin.Controls.MaterialButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textTitle
            // 
            this.textTitle.AnimateReadOnly = false;
            this.textTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textTitle.Depth = 0;
            this.textTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textTitle.HideSelection = true;
            this.textTitle.LeadingIcon = null;
            this.textTitle.Location = new System.Drawing.Point(69, 96);
            this.textTitle.MaxLength = 32767;
            this.textTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.textTitle.Name = "textTitle";
            this.textTitle.PasswordChar = '\0';
            this.textTitle.PrefixSuffixText = null;
            this.textTitle.ReadOnly = false;
            this.textTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textTitle.SelectedText = "";
            this.textTitle.SelectionLength = 0;
            this.textTitle.SelectionStart = 0;
            this.textTitle.ShortcutsEnabled = true;
            this.textTitle.Size = new System.Drawing.Size(167, 48);
            this.textTitle.TabIndex = 0;
            this.textTitle.TabStop = false;
            this.textTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textTitle.TrailingIcon = null;
            this.textTitle.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 111);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(32, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Title";
            // 
            // cmbCategory
            // 
            this.cmbCategory.AutoResize = false;
            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCategory.Depth = 0;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCategory.DropDownHeight = 174;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.DropDownWidth = 121;
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.IntegralHeight = false;
            this.cmbCategory.ItemHeight = 43;
            this.cmbCategory.Items.AddRange(new object[] {
            "Work",
            "Study",
            "Personal"});
            this.cmbCategory.Location = new System.Drawing.Point(374, 95);
            this.cmbCategory.MaxDropDownItems = 4;
            this.cmbCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(158, 49);
            this.cmbCategory.StartIndex = 0;
            this.cmbCategory.TabIndex = 3;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(275, 110);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(64, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Category";
            // 
            // dtReminder
            // 
            this.dtReminder.Location = new System.Drawing.Point(655, 105);
            this.dtReminder.Name = "dtReminder";
            this.dtReminder.Size = new System.Drawing.Size(216, 24);
            this.dtReminder.TabIndex = 5;
            this.dtReminder.ValueChanged += new System.EventHandler(this.dtReminder_ValueChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(567, 111);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(68, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Reminder";
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(914, 99);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(99, 36);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save Note";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // richTextContent
            // 
            this.richTextContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextContent.Location = new System.Drawing.Point(3, 198);
            this.richTextContent.Name = "richTextContent";
            this.richTextContent.Size = new System.Drawing.Size(1107, 295);
            this.richTextContent.TabIndex = 9;
            this.richTextContent.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bold,
            this.Italic,
            this.Underline,
            this.toolStripSeparator1,
            this.cmbFonts,
            this.cmbFontSize});
            this.toolStrip1.Location = new System.Drawing.Point(3, 170);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1107, 28);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Bold
            // 
            this.Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bold.Image = global::WindowsFormsApp1.Properties.Resources.images;
            this.Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(29, 28);
            this.Bold.Text = "toolStripButton1";
            this.Bold.Click += new System.EventHandler(this.Bold_Click);
            // 
            // Italic
            // 
            this.Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Italic.Image = global::WindowsFormsApp1.Properties.Resources.images__1_;
            this.Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(29, 28);
            this.Italic.Text = "toolStripButton2";
            this.Italic.Click += new System.EventHandler(this.Italic_Click);
            // 
            // Underline
            // 
            this.Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Underline.Image = global::WindowsFormsApp1.Properties.Resources.Editing_Underline_icon;
            this.Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(29, 28);
            this.Underline.Text = "toolStripButton3";
            this.Underline.Click += new System.EventHandler(this.Underline_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // cmbFonts
            // 
            this.cmbFonts.Name = "cmbFonts";
            this.cmbFonts.Size = new System.Drawing.Size(121, 31);
            this.cmbFonts.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // cmbFontSize
            // 
            this.cmbFontSize.Name = "cmbFontSize";
            this.cmbFontSize.Size = new System.Drawing.Size(121, 31);
            this.cmbFontSize.Click += new System.EventHandler(this.cmbFontSize_Click);
            // 
            // btnOpenFromFile
            // 
            this.btnOpenFromFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenFromFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOpenFromFile.Depth = 0;
            this.btnOpenFromFile.HighEmphasis = true;
            this.btnOpenFromFile.Icon = null;
            this.btnOpenFromFile.Location = new System.Drawing.Point(570, 442);
            this.btnOpenFromFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOpenFromFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenFromFile.Name = "btnOpenFromFile";
            this.btnOpenFromFile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOpenFromFile.Size = new System.Drawing.Size(92, 36);
            this.btnOpenFromFile.TabIndex = 11;
            this.btnOpenFromFile.Text = "Open File";
            this.btnOpenFromFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOpenFromFile.UseAccentColor = false;
            this.btnOpenFromFile.UseVisualStyleBackColor = true;
            this.btnOpenFromFile.Click += new System.EventHandler(this.btnOpenFromFile_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveToFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveToFile.Depth = 0;
            this.btnSaveToFile.HighEmphasis = true;
            this.btnSaveToFile.Icon = null;
            this.btnSaveToFile.Location = new System.Drawing.Point(401, 442);
            this.btnSaveToFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveToFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveToFile.Size = new System.Drawing.Size(90, 36);
            this.btnSaveToFile.TabIndex = 12;
            this.btnSaveToFile.Text = "Save File";
            this.btnSaveToFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveToFile.UseAccentColor = false;
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // AddNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 496);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.btnOpenFromFile);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextContent);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.dtReminder);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textTitle);
            this.Name = "AddNoteForm";
            this.Text = "AddNoteForm";
            this.Load += new System.EventHandler(this.AddNoteForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 textTitle;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cmbCategory;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DateTimePicker dtReminder;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private System.Windows.Forms.RichTextBox richTextContent;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Bold;
        private System.Windows.Forms.ToolStripButton Italic;
        private System.Windows.Forms.ToolStripButton Underline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox cmbFonts;
        private System.Windows.Forms.ToolStripComboBox cmbFontSize;
        private MaterialSkin.Controls.MaterialButton btnOpenFromFile;
        private MaterialSkin.Controls.MaterialButton btnSaveToFile;
    }
}