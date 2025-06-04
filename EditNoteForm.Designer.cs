namespace WindowsFormsApp1
{
    partial class EditNoteForm
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
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.dtReminder = new System.Windows.Forms.DateTimePicker();
            this.cmbCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.textTitle = new MaterialSkin.Controls.MaterialTextBox2();
            this.richTextContent = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Bold = new System.Windows.Forms.ToolStripButton();
            this.Italic = new System.Windows.Forms.ToolStripButton();
            this.Underline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbFonts = new System.Windows.Forms.ToolStripComboBox();
            this.cmbFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.btnSaveToFile = new MaterialSkin.Controls.MaterialButton();
            this.btnOpenFromFile = new MaterialSkin.Controls.MaterialButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(766, 101);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(99, 36);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save Note";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtReminder
            // 
            this.dtReminder.Location = new System.Drawing.Point(491, 105);
            this.dtReminder.Name = "dtReminder";
            this.dtReminder.Size = new System.Drawing.Size(216, 24);
            this.dtReminder.TabIndex = 11;
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
            this.cmbCategory.Location = new System.Drawing.Point(256, 101);
            this.cmbCategory.MaxDropDownItems = 4;
            this.cmbCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(158, 49);
            this.cmbCategory.StartIndex = 0;
            this.cmbCategory.TabIndex = 10;
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
            this.textTitle.Location = new System.Drawing.Point(27, 101);
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
            this.textTitle.TabIndex = 9;
            this.textTitle.TabStop = false;
            this.textTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textTitle.TrailingIcon = null;
            this.textTitle.UseSystemPasswordChar = false;
            // 
            // richTextContent
            // 
            this.richTextContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextContent.Location = new System.Drawing.Point(3, 208);
            this.richTextContent.Name = "richTextContent";
            this.richTextContent.Size = new System.Drawing.Size(1060, 288);
            this.richTextContent.TabIndex = 14;
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
            this.toolStrip1.Location = new System.Drawing.Point(3, 180);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1060, 28);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Bold
            // 
            this.Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bold.Image = global::WindowsFormsApp1.Properties.Resources.images;
            this.Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(29, 25);
            this.Bold.Text = "toolStripButton1";
            this.Bold.Click += new System.EventHandler(this.Bold_Click);
            // 
            // Italic
            // 
            this.Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Italic.Image = global::WindowsFormsApp1.Properties.Resources.images__1_;
            this.Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(29, 25);
            this.Italic.Text = "toolStripButton2";
            // 
            // Underline
            // 
            this.Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Underline.Image = global::WindowsFormsApp1.Properties.Resources.Editing_Underline_icon;
            this.Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(29, 25);
            this.Underline.Text = "toolStripButton3";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // cmbFonts
            // 
            this.cmbFonts.Name = "cmbFonts";
            this.cmbFonts.Size = new System.Drawing.Size(121, 28);
            // 
            // cmbFontSize
            // 
            this.cmbFontSize.Name = "cmbFontSize";
            this.cmbFontSize.Size = new System.Drawing.Size(121, 28);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveToFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveToFile.Depth = 0;
            this.btnSaveToFile.HighEmphasis = true;
            this.btnSaveToFile.Icon = null;
            this.btnSaveToFile.Location = new System.Drawing.Point(379, 443);
            this.btnSaveToFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveToFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveToFile.Size = new System.Drawing.Size(90, 36);
            this.btnSaveToFile.TabIndex = 17;
            this.btnSaveToFile.Text = "Save File";
            this.btnSaveToFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveToFile.UseAccentColor = false;
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnOpenFromFile
            // 
            this.btnOpenFromFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenFromFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOpenFromFile.Depth = 0;
            this.btnOpenFromFile.HighEmphasis = true;
            this.btnOpenFromFile.Icon = null;
            this.btnOpenFromFile.Location = new System.Drawing.Point(548, 443);
            this.btnOpenFromFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOpenFromFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenFromFile.Name = "btnOpenFromFile";
            this.btnOpenFromFile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOpenFromFile.Size = new System.Drawing.Size(92, 36);
            this.btnOpenFromFile.TabIndex = 16;
            this.btnOpenFromFile.Text = "Open File";
            this.btnOpenFromFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOpenFromFile.UseAccentColor = false;
            this.btnOpenFromFile.UseVisualStyleBackColor = true;
            this.btnOpenFromFile.Click += new System.EventHandler(this.btnOpenFromFile_Click);
            // 
            // EditNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 499);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.btnOpenFromFile);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextContent);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtReminder);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.textTitle);
            this.Name = "EditNoteForm";
            this.Text = "EditNoteForm";
            this.Load += new System.EventHandler(this.EditNoteForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnSave;
        private System.Windows.Forms.DateTimePicker dtReminder;
        private MaterialSkin.Controls.MaterialComboBox cmbCategory;
        private MaterialSkin.Controls.MaterialTextBox2 textTitle;
        private System.Windows.Forms.RichTextBox richTextContent;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Bold;
        private System.Windows.Forms.ToolStripButton Italic;
        private System.Windows.Forms.ToolStripButton Underline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox cmbFonts;
        private System.Windows.Forms.ToolStripComboBox cmbFontSize;
        private MaterialSkin.Controls.MaterialButton btnSaveToFile;
        private MaterialSkin.Controls.MaterialButton btnOpenFromFile;
    }
}