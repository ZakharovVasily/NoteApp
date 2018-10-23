using System;
using System.Windows.Forms;


namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        public NoteApp.Project pr = new NoteApp.Project();

        //public NoteApp.ManagerProject pr = new NoteApp.ManagerProject();

        public MainForm()
        {
            InitializeComponent();

            ClearAll();
            
            
            pr.ChangeNote(null, "Название1", NoteApp.NoteCategory.Different, "Текст1", DateTime.Now, DateTime.Now);
            ListBoxNote.Items.Add(pr._note[pr.CountNote].Title);
            pr.ChangeNote(null, "Название2", NoteApp.NoteCategory.Documents,"Текст2", DateTime.Now, DateTime.Now);
            ListBoxNote.Items.Add(pr._note[pr.CountNote].Title);

            //pr.UpdateData();

            ListBoxNote.SelectedIndex = 0;
            AddCategoryBox();
         }

        /// <summary>
        /// Добавляем категории (хз как все срвзу)
        /// </summary>
        private void AddCategoryBox()
        {
            NoteCategoryBox.Items.Add("All");
            NoteCategoryBox.Items.Add(NoteApp.NoteCategory.Different);
            NoteCategoryBox.Items.Add(NoteApp.NoteCategory.Documents);
            NoteCategoryBox.Items.Add(NoteApp.NoteCategory.Finance);
            NoteCategoryBox.Items.Add(NoteApp.NoteCategory.HealthAndSport);
            NoteCategoryBox.Items.Add(NoteApp.NoteCategory.House);
            NoteCategoryBox.Items.Add(NoteApp.NoteCategory.Job);

            NoteCategoryBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Вывод текста из ListBox'a в TextBox
        /// </summary>
        private void ListBoxNote_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ListBoxNote.Items.Count > 1)
            {
                //WriteTextBox.Text = pr._note[ListBoxNote.SelectedIndex].Text;

                //WriteTextBox.Text = pr.UpdateData();

                TimeCreateLabel.Text = (pr._note[ListBoxNote.SelectedIndex].TimeCreation).ToString("dd/MM/yyyy");
                TimeModifiedLabel.Text = (pr._note[ListBoxNote.SelectedIndex].TimeModified).ToString("dd/MM/yyyy");
                SelectNameLabel.Text = pr._note[ListBoxNote.SelectedIndex].Title;
                SelectCategoryLabel.Text = pr.NoteCategoryToStr(pr._note[ListBoxNote.SelectedIndex].Category);
            }
        }

        /// <summary>
        /// Метод для добавления новой записи
        /// </summary>
        public void AddNoteMeth()
        {
            Data.TmpTitle = "";
            Data.TmpText = "";
            Data.TmpTimeCreate = DateTime.Now;

            AddNoteForm Form2 = new AddNoteForm();
            Form2.ShowDialog();

            if (Form2.DialogResult == DialogResult.OK)
            {
                pr.ChangeNote(null, Data.TmpTitle, pr.StrToNoteCategory(Data.TmpNoteCategory), Data.TmpText, DateTime.Now, DateTime.Now);
                ListBoxNote.Items.Add(pr._note[pr.CountNote].Title);
            }
        }

        /// <summary>
        /// Метод для редактирования существующей записи
        /// </summary>
        public void EditNoteMeth()
        {
            try
            {
                Data.TmpTitle = pr._note[ListBoxNote.SelectedIndex].Title;
                Data.TmpText = pr._note[ListBoxNote.SelectedIndex].Text;
                Data.TmpTimeCreate = pr._note[ListBoxNote.SelectedIndex].TimeCreation;
                Data.TmpNoteCategory = pr.NoteCategoryToStr(pr._note[ListBoxNote.SelectedIndex].Category);

                AddNoteForm Form2 = new AddNoteForm();
                Form2.ShowDialog();

                if (Form2.DialogResult == DialogResult.OK)
                {
                    pr.ChangeNote(pr._note[ListBoxNote.SelectedIndex], Data.TmpTitle, pr.StrToNoteCategory(Data.TmpNoteCategory), Data.TmpText, Data.TmpTimeCreate, DateTime.Now);
                }

                ListBoxNote.Items[ListBoxNote.SelectedIndex] = Data.TmpTitle;

                WriteTextBox.Update();
                ListBoxNote.Update();
            }
            catch 
            {
                if (ListBoxNote.SelectedItem == null)
                {
                    MessageBox.Show("Заметка не выбрана!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Метод для удаления записи
        /// </summary>
        public void RemoteNoteMeth()
        {
            try
            {
                int ItemID = ListBoxNote.SelectedIndex;

                if (ItemID == 0)
                {
                    WriteTextBox.Text = "";
                    TimeCreateLabel.Text = "";
                    TimeModifiedLabel.Text = "";
                    SelectNameLabel.Text = "";
                    SelectCategoryLabel.Text = "";
                }

                ListBoxNote.SelectedIndex--;

                ListBoxNote.Items.RemoveAt(ItemID);
                pr._note.RemoveAt(ItemID);
                pr.CountNote--;
            }
            catch
            {
                if (ListBoxNote.SelectedItem == null)
                {
                    MessageBox.Show("Заметка не выбрана!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Вывод данных в листбокс по категориям из ComboBox
        /// </summary>
        private void NoteCategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxNote.Items.Clear();
            ClearAll();

            for (int i = 0; i <= pr.CountNote; i++)
            {
                if (NoteCategoryBox.SelectedItem.ToString() == "All")
                {
                    ListBoxNote.Items.Add(pr._note[i].Title);
                }
                else if (pr._note[i].Category == pr.StrToNoteCategory(NoteCategoryBox.SelectedItem.ToString())) ///!!!!!
                {
                    ListBoxNote.Items.Add(pr._note[i].Title);
                }
            }
        }

        /// <summary>
        /// Очищает все поля
        /// </summary>
        public void ClearAll()
        {
            WriteTextBox.Text = "";
            TimeCreateLabel.Text = "";
            TimeModifiedLabel.Text = "";
            SelectNameLabel.Text = "";
            SelectCategoryLabel.Text = "";
        }

        /// <summary>
        /// Кнопка в меню для добавления новой заметки
        /// </summary>
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNoteMeth();
        }

        /// <summary>
        /// Кнопка для добавления новой заметки
        /// </summary>
        private void AddNote_Click(object sender, EventArgs e)
        {
            AddNoteMeth();
        }

        /// <summary>
        /// Кнопка в меню для редактирования заметки
        /// </summary>
        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNoteMeth();
        }

        /// <summary>
        /// Кнопка для редактирования заметки
        /// </summary>
        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            EditNoteMeth();
        }

        /// <summary>
        /// Кнопка для удаления заметки
        /// </summary>
        private void remoteNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoteNoteMeth();
        }

        /// <summary>
        /// Кнопка для удаление записей
        /// </summary>
        private void RemoveNoteButton_Click(object sender, EventArgs e)
        {
            RemoteNoteMeth();
        }

        /// <summary>
        /// Кнопка в меню для закрытии программы
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Кнопка в меню для About
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm AboutNewForm = new AboutForm();
            AboutNewForm.ShowDialog();
        }
    }
}

