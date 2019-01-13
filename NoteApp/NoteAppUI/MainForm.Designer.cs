namespace NoteAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ListBoxNote = new System.Windows.Forms.ListBox();
            this.AddNoteButton = new System.Windows.Forms.Button();
            this.TimeCreateLabel = new System.Windows.Forms.Label();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.TimeModifiedLabel = new System.Windows.Forms.Label();
            this.NoteCategoryBox = new System.Windows.Forms.ComboBox();
            this.EditNoteButton = new System.Windows.Forms.Button();
            this.RemoveNoteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectCategoryLabel = new System.Windows.Forms.Label();
            this.SelectNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxNote
            // 
            this.ListBoxNote.FormattingEnabled = true;
            this.ListBoxNote.Location = new System.Drawing.Point(12, 54);
            this.ListBoxNote.Name = "ListBoxNote";
            this.ListBoxNote.Size = new System.Drawing.Size(229, 355);
            this.ListBoxNote.TabIndex = 0;
            this.ListBoxNote.SelectedIndexChanged += new System.EventHandler(this.ListBoxNote_SelectedIndexChanged);
            this.ListBoxNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RemoveNote_KeyDown);
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNoteButton.FlatAppearance.BorderSize = 0;
            this.AddNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("AddNoteButton.Image")));
            this.AddNoteButton.Location = new System.Drawing.Point(12, 417);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(16, 16);
            this.AddNoteButton.TabIndex = 1;
            this.AddNoteButton.UseVisualStyleBackColor = true;
            this.AddNoteButton.Click += new System.EventHandler(this.AddNote_Click);
            // 
            // TimeCreateLabel
            // 
            this.TimeCreateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TimeCreateLabel.AutoSize = true;
            this.TimeCreateLabel.Location = new System.Drawing.Point(297, 78);
            this.TimeCreateLabel.Name = "TimeCreateLabel";
            this.TimeCreateLabel.Size = new System.Drawing.Size(64, 13);
            this.TimeCreateLabel.TabIndex = 2;
            this.TimeCreateLabel.Text = "CreateLabel";
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Location = new System.Drawing.Point(247, 99);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.ReadOnly = true;
            this.NoteTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.NoteTextBox.Size = new System.Drawing.Size(527, 324);
            this.NoteTextBox.TabIndex = 3;
            // 
            // TimeModifiedLabel
            // 
            this.TimeModifiedLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TimeModifiedLabel.AutoSize = true;
            this.TimeModifiedLabel.Location = new System.Drawing.Point(502, 78);
            this.TimeModifiedLabel.Name = "TimeModifiedLabel";
            this.TimeModifiedLabel.Size = new System.Drawing.Size(73, 13);
            this.TimeModifiedLabel.TabIndex = 4;
            this.TimeModifiedLabel.Text = "ModifiedLabel";
            // 
            // NoteCategoryBox
            // 
            this.NoteCategoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NoteCategoryBox.FormattingEnabled = true;
            this.NoteCategoryBox.Location = new System.Drawing.Point(96, 27);
            this.NoteCategoryBox.Name = "NoteCategoryBox";
            this.NoteCategoryBox.Size = new System.Drawing.Size(145, 21);
            this.NoteCategoryBox.TabIndex = 5;
            this.NoteCategoryBox.SelectedIndexChanged += new System.EventHandler(this.NoteCategoryBox_SelectedIndexChanged);
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditNoteButton.FlatAppearance.BorderSize = 0;
            this.EditNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("EditNoteButton.Image")));
            this.EditNoteButton.Location = new System.Drawing.Point(34, 418);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(16, 16);
            this.EditNoteButton.TabIndex = 6;
            this.EditNoteButton.UseVisualStyleBackColor = true;
            this.EditNoteButton.Click += new System.EventHandler(this.EditNoteButton_Click);
            // 
            // RemoveNoteButton
            // 
            this.RemoveNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveNoteButton.FlatAppearance.BorderSize = 0;
            this.RemoveNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveNoteButton.Image")));
            this.RemoveNoteButton.Location = new System.Drawing.Point(56, 418);
            this.RemoveNoteButton.Name = "RemoveNoteButton";
            this.RemoveNoteButton.Size = new System.Drawing.Size(16, 16);
            this.RemoveNoteButton.TabIndex = 7;
            this.RemoveNoteButton.UseVisualStyleBackColor = true;
            this.RemoveNoteButton.Click += new System.EventHandler(this.RemoveNoteButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(247, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Created:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(447, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Modified:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(247, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Category:";
            // 
            // SelectCategoryLabel
            // 
            this.SelectCategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SelectCategoryLabel.AutoSize = true;
            this.SelectCategoryLabel.Location = new System.Drawing.Point(300, 56);
            this.SelectCategoryLabel.Name = "SelectCategoryLabel";
            this.SelectCategoryLabel.Size = new System.Drawing.Size(75, 13);
            this.SelectCategoryLabel.TabIndex = 12;
            this.SelectCategoryLabel.Text = "CategoryLabel";
            // 
            // SelectNameLabel
            // 
            this.SelectNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SelectNameLabel.AutoSize = true;
            this.SelectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectNameLabel.Location = new System.Drawing.Point(247, 28);
            this.SelectNameLabel.Name = "SelectNameLabel";
            this.SelectNameLabel.Size = new System.Drawing.Size(80, 17);
            this.SelectNameLabel.TabIndex = 13;
            this.SelectNameLabel.Text = "TitleLabel";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.remoteNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.addToolStripMenuItem.Text = "Add Note";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.editNoteToolStripMenuItem.Text = "Edit Note";
            this.editNoteToolStripMenuItem.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
            // 
            // remoteNoteToolStripMenuItem
            // 
            this.remoteNoteToolStripMenuItem.Name = "remoteNoteToolStripMenuItem";
            this.remoteNoteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.remoteNoteToolStripMenuItem.Text = "Remote Note";
            this.remoteNoteToolStripMenuItem.Click += new System.EventHandler(this.RemoveNoteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Show category:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectNameLabel);
            this.Controls.Add(this.SelectCategoryLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RemoveNoteButton);
            this.Controls.Add(this.EditNoteButton);
            this.Controls.Add(this.NoteCategoryBox);
            this.Controls.Add(this.TimeModifiedLabel);
            this.Controls.Add(this.NoteTextBox);
            this.Controls.Add(this.TimeCreateLabel);
            this.Controls.Add(this.AddNoteButton);
            this.Controls.Add(this.ListBoxNote);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 484);
            this.MinimumSize = new System.Drawing.Size(816, 484);
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxNote;
        private System.Windows.Forms.Button AddNoteButton;
        private System.Windows.Forms.Label TimeCreateLabel;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.Label TimeModifiedLabel;
        private System.Windows.Forms.ComboBox NoteCategoryBox;
        private System.Windows.Forms.Button EditNoteButton;
        private System.Windows.Forms.Button RemoveNoteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SelectCategoryLabel;
        private System.Windows.Forms.Label SelectNameLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

