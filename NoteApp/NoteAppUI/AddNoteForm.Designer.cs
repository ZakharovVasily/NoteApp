namespace NoteAppUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.NewTitleTextBox = new System.Windows.Forms.TextBox();
            this.NewTextTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NewTimeCreateLabel = new System.Windows.Forms.Label();
            this.NewNoteCategoryBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NewTimeModifiedLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(359, 371);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "OK";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NewTitleTextBox
            // 
            this.NewTitleTextBox.ForeColor = System.Drawing.Color.Black;
            this.NewTitleTextBox.Location = new System.Drawing.Point(94, 8);
            this.NewTitleTextBox.Name = "NewTitleTextBox";
            this.NewTitleTextBox.Size = new System.Drawing.Size(359, 20);
            this.NewTitleTextBox.TabIndex = 3;
            this.NewTitleTextBox.TextChanged += new System.EventHandler(this.NewTitleText_TextChanged);
            // 
            // NewTextTextBox
            // 
            this.NewTextTextBox.Location = new System.Drawing.Point(15, 115);
            this.NewTextTextBox.Multiline = true;
            this.NewTextTextBox.Name = "NewTextTextBox";
            this.NewTextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.NewTextTextBox.Size = new System.Drawing.Size(500, 250);
            this.NewTextTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Категория:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Созданно:";
            // 
            // NewTimeCreateLabel
            // 
            this.NewTimeCreateLabel.AutoSize = true;
            this.NewTimeCreateLabel.Location = new System.Drawing.Point(84, 80);
            this.NewTimeCreateLabel.Name = "NewTimeCreateLabel";
            this.NewTimeCreateLabel.Size = new System.Drawing.Size(35, 13);
            this.NewTimeCreateLabel.TabIndex = 7;
            this.NewTimeCreateLabel.Text = "label5";
            // 
            // NewNoteCategoryBox
            // 
            this.NewNoteCategoryBox.FormattingEnabled = true;
            this.NewNoteCategoryBox.Location = new System.Drawing.Point(94, 40);
            this.NewNoteCategoryBox.Name = "NewNoteCategoryBox";
            this.NewNoteCategoryBox.Size = new System.Drawing.Size(130, 21);
            this.NewNoteCategoryBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(348, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Измененно:";
            // 
            // NewTimeModifiedLabel
            // 
            this.NewTimeModifiedLabel.AutoSize = true;
            this.NewTimeModifiedLabel.Location = new System.Drawing.Point(430, 82);
            this.NewTimeModifiedLabel.Name = "NewTimeModifiedLabel";
            this.NewTimeModifiedLabel.Size = new System.Drawing.Size(35, 13);
            this.NewTimeModifiedLabel.TabIndex = 10;
            this.NewTimeModifiedLabel.Text = "label7";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(440, 371);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 401);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NewTimeModifiedLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NewNoteCategoryBox);
            this.Controls.Add(this.NewTimeCreateLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewTextTextBox);
            this.Controls.Add(this.NewTitleTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddNoteForm";
            this.Text = "Add/Edit Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox NewTitleTextBox;
        private System.Windows.Forms.TextBox NewTextTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NewTimeCreateLabel;
        private System.Windows.Forms.ComboBox NewNoteCategoryBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label NewTimeModifiedLabel;
        private System.Windows.Forms.Button CancelButton;
    }
}