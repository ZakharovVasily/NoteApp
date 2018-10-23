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
            this.ListBoxNote = new System.Windows.Forms.ListBox();
            this.AddNote = new System.Windows.Forms.Button();
            this.TimeCreateLabel = new System.Windows.Forms.Label();
            this.WriteTextBox = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxNote
            // 
            this.ListBoxNote.FormattingEnabled = true;
            this.ListBoxNote.Location = new System.Drawing.Point(12, 61);
            this.ListBoxNote.Name = "ListBoxNote";
            this.ListBoxNote.Size = new System.Drawing.Size(145, 251);
            this.ListBoxNote.TabIndex = 0;
            this.ListBoxNote.SelectedIndexChanged += new System.EventHandler(this.ListBoxNote_SelectedIndexChanged_1);
            // 
            // AddNote
            // 
            this.AddNote.Location = new System.Drawing.Point(12, 324);
            this.AddNote.Name = "AddNote";
            this.AddNote.Size = new System.Drawing.Size(64, 24);
            this.AddNote.TabIndex = 1;
            this.AddNote.Text = "Add";
            this.AddNote.UseVisualStyleBackColor = true;
            this.AddNote.Click += new System.EventHandler(this.AddNote_Click);
            // 
            // TimeCreateLabel
            // 
            this.TimeCreateLabel.AutoSize = true;
            this.TimeCreateLabel.Location = new System.Drawing.Point(586, 328);
            this.TimeCreateLabel.Name = "TimeCreateLabel";
            this.TimeCreateLabel.Size = new System.Drawing.Size(35, 13);
            this.TimeCreateLabel.TabIndex = 2;
            this.TimeCreateLabel.Text = "label1";
            // 
            // WriteTextBox
            // 
            this.WriteTextBox.Location = new System.Drawing.Point(172, 61);
            this.WriteTextBox.Multiline = true;
            this.WriteTextBox.Name = "WriteTextBox";
            this.WriteTextBox.ReadOnly = true;
            this.WriteTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WriteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.WriteTextBox.Size = new System.Drawing.Size(500, 250);
            this.WriteTextBox.TabIndex = 3;
            // 
            // TimeModifiedLabel
            // 
            this.TimeModifiedLabel.AutoSize = true;
            this.TimeModifiedLabel.Location = new System.Drawing.Point(586, 360);
            this.TimeModifiedLabel.Name = "TimeModifiedLabel";
            this.TimeModifiedLabel.Size = new System.Drawing.Size(35, 13);
            this.TimeModifiedLabel.TabIndex = 4;
            this.TimeModifiedLabel.Text = "label1";
            // 
            // NoteCategoryBox
            // 
            this.NoteCategoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NoteCategoryBox.FormattingEnabled = true;
            this.NoteCategoryBox.Location = new System.Drawing.Point(12, 34);
            this.NoteCategoryBox.Name = "NoteCategoryBox";
            this.NoteCategoryBox.Size = new System.Drawing.Size(145, 21);
            this.NoteCategoryBox.TabIndex = 5;
            this.NoteCategoryBox.SelectedIndexChanged += new System.EventHandler(this.NoteCategoryBox_SelectedIndexChanged);
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.Location = new System.Drawing.Point(12, 354);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(64, 24);
            this.EditNoteButton.TabIndex = 6;
            this.EditNoteButton.Text = "Edit";
            this.EditNoteButton.UseVisualStyleBackColor = true;
            this.EditNoteButton.Click += new System.EventHandler(this.EditNoteButton_Click);
            // 
            // RemoveNoteButton
            // 
            this.RemoveNoteButton.Location = new System.Drawing.Point(82, 325);
            this.RemoveNoteButton.Name = "RemoveNoteButton";
            this.RemoveNoteButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveNoteButton.TabIndex = 7;
            this.RemoveNoteButton.Text = "Remove";
            this.RemoveNoteButton.UseVisualStyleBackColor = true;
            this.RemoveNoteButton.Click += new System.EventHandler(this.RemoveNoteButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(523, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Созданно:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(513, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Измененно:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(242, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Категория:";
            // 
            // SelectCategoryLabel
            // 
            this.SelectCategoryLabel.AutoSize = true;
            this.SelectCategoryLabel.Location = new System.Drawing.Point(320, 330);
            this.SelectCategoryLabel.Name = "SelectCategoryLabel";
            this.SelectCategoryLabel.Size = new System.Drawing.Size(35, 13);
            this.SelectCategoryLabel.TabIndex = 12;
            this.SelectCategoryLabel.Text = "label1";
            // 
            // SelectNameLabel
            // 
            this.SelectNameLabel.AutoSize = true;
            this.SelectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectNameLabel.Location = new System.Drawing.Point(169, 37);
            this.SelectNameLabel.Name = "SelectNameLabel";
            this.SelectNameLabel.Size = new System.Drawing.Size(52, 17);
            this.SelectNameLabel.TabIndex = 13;
            this.SelectNameLabel.Text = "label2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.remoteNoteToolStripMenuItem.Click += new System.EventHandler(this.remoteNoteToolStripMenuItem_Click);
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
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 386);
            this.Controls.Add(this.SelectNameLabel);
            this.Controls.Add(this.SelectCategoryLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RemoveNoteButton);
            this.Controls.Add(this.EditNoteButton);
            this.Controls.Add(this.NoteCategoryBox);
            this.Controls.Add(this.TimeModifiedLabel);
            this.Controls.Add(this.WriteTextBox);
            this.Controls.Add(this.TimeCreateLabel);
            this.Controls.Add(this.AddNote);
            this.Controls.Add(this.ListBoxNote);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxNote;
        private System.Windows.Forms.Button AddNote;
        private System.Windows.Forms.Label TimeCreateLabel;
        private System.Windows.Forms.TextBox WriteTextBox;
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
    }
}

