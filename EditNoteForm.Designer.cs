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
            this.txtContent = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.dtReminder = new System.Windows.Forms.DateTimePicker();
            this.cmbCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.textTitle = new MaterialSkin.Controls.MaterialTextBox2();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(626, 85);
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
            // txtContent
            // 
            this.txtContent.AnimateReadOnly = false;
            this.txtContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtContent.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContent.Depth = 0;
            this.txtContent.HideSelection = true;
            this.txtContent.Location = new System.Drawing.Point(6, 153);
            this.txtContent.MaxLength = 32767;
            this.txtContent.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContent.Name = "txtContent";
            this.txtContent.PasswordChar = '\0';
            this.txtContent.ReadOnly = false;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContent.SelectedText = "";
            this.txtContent.SelectionLength = 0;
            this.txtContent.SelectionStart = 0;
            this.txtContent.ShortcutsEnabled = true;
            this.txtContent.Size = new System.Drawing.Size(765, 260);
            this.txtContent.TabIndex = 12;
            this.txtContent.TabStop = false;
            this.txtContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContent.UseSystemPasswordChar = false;
            // 
            // dtReminder
            // 
            this.dtReminder.Location = new System.Drawing.Point(376, 89);
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
            this.cmbCategory.Location = new System.Drawing.Point(200, 88);
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
            this.textTitle.Location = new System.Drawing.Point(14, 89);
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
            // EditNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.dtReminder);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.textTitle);
            this.Name = "EditNoteForm";
            this.Text = "EditNoteForm";
            this.Load += new System.EventHandler(this.EditNoteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtContent;
        private System.Windows.Forms.DateTimePicker dtReminder;
        private MaterialSkin.Controls.MaterialComboBox cmbCategory;
        private MaterialSkin.Controls.MaterialTextBox2 textTitle;
    }
}