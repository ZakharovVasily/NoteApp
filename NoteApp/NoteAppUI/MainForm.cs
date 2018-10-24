using System;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Создаеться обьект класса
        /// </summary>
        private  static  Project _project = new Project();


        public MainForm()
        {
            InitializeComponent();
                
            if (ProjectManager.OpenProject() != null)
            {
                _project = ProjectManager.OpenProject();

                //if(_project.CountList > -1) { ListBoxNote.SelectedIndex = 0;}
            }

            AddCategoryBox();
         }

        /// <summary>
        /// Добавляем категории (хз как все срвзу) 
        /// </summary>
        private void AddCategoryBox()
        {
            //TODO: прогуглить
            NoteCategoryBox.Items.Add("All");
            NoteCategoryBox.Items.Add(NoteCategory.Different);
            NoteCategoryBox.Items.Add(NoteCategory.Documents);
            NoteCategoryBox.Items.Add(NoteCategory.Finance);
            NoteCategoryBox.Items.Add(NoteCategory.HealthAndSport);
            NoteCategoryBox.Items.Add(NoteCategory.House);
            NoteCategoryBox.Items.Add(NoteCategory.Job);

            NoteCategoryBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Вывод текста из ListBox'a в TextBox
        /// </summary>
        private void ListBoxNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: Items.Any! new VS
            if (ListBoxNote.SelectedIndex > -1)
            {
                if (ListBoxNote.Items.Count > 0)
                {
                    NoteTextBox.Text = _project.Note[ListBoxNote.SelectedIndex].Text;
                    TimeCreateLabel.Text = (_project.Note[ListBoxNote.SelectedIndex].TimeCreation).ToString("dd/MM/yyyy");
                    TimeModifiedLabel.Text = (_project.Note[ListBoxNote.SelectedIndex].TimeModified).ToString("dd/MM/yyyy");
                    SelectNameLabel.Text = _project.Note[ListBoxNote.SelectedIndex].Title;
                    SelectCategoryLabel.Text = _project.Note[ListBoxNote.SelectedIndex].Category.ToString();
                }
            }
        }

        /// <summary>
        /// Метод для добавления новой записи
        /// </summary>
        public void AddNote()
        {
            var addNoteForm = new AddNoteForm(new Note());
            addNoteForm.ShowDialog();

            if (addNoteForm.DialogResult == DialogResult.OK)
            {
                _project.AddNote(addNoteForm.CurrentNote);
                ListBoxNote.Items.Add(addNoteForm.CurrentNote.Title);
            }
            
            ProjectManager.SaveProject(_project);
        }

        /// <summary>
        /// Метод для редактирования существующей записи
        /// </summary>
        public void EditNote()
        {
            if (ListBoxNote.SelectedItem == null)
            {
                MessageBox.Show("Заметка не выбрана!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedIndex = ListBoxNote.SelectedIndex;
            ListBoxNote.SelectedIndex = -1;

            var addNoteForm = new AddNoteForm(_project.Note[selectedIndex]);
            addNoteForm.ShowDialog();

            ListBoxNote.Items[selectedIndex] = addNoteForm.CurrentNote.Title;

            NoteTextBox.Update();
            ListBoxNote.Update();

            ProjectManager.SaveProject(_project);
        }

        /// <summary>
        /// Метод для удаления записи
        /// </summary>
        public void RemoveNote()
        {
            if (ListBoxNote.SelectedItem == null)
            {
                MessageBox.Show("Заметка не выбрана!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            ClearAll();
            _project.Note.RemoveAt(ListBoxNote.SelectedIndex);
            ListBoxNote.Items.RemoveAt(ListBoxNote.SelectedIndex);
            _project.CountList--;

            ProjectManager.SaveProject(_project);
        }

        /// <summary>
        /// Вывод данных в листбокс по категориям из ComboBox
        /// </summary>
        private void NoteCategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxNote.Items.Clear();
            ClearAll();

            for (int i = 0; i <= _project.CountList; i++)
            {
                if (NoteCategoryBox.SelectedItem.ToString() == "All")
                {
                    ListBoxNote.Items.Add(_project.Note[i].Title);
                }
                else if (_project.Note[i].Category == EnumParser.StringToNoteCategory(NoteCategoryBox.SelectedItem.ToString()))
                {
                    ListBoxNote.Items.Add(_project.Note[i].Title);
                }
            }
        }

        /// <summary>
        /// Очищает все поля
        /// </summary>
        public void ClearAll()
        {
            NoteTextBox.Text = "";
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
            AddNote();
        }

        /// <summary>
        /// Кнопка для добавления новой заметки
        /// </summary>
        private void AddNote_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        /// <summary>
        /// Кнопка в меню для редактирования заметки
        /// </summary>
        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        /// <summary>
        /// Кнопка для редактирования заметки
        /// </summary>
        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        /// <summary>
        /// Кнопка для удаления заметки
        /// </summary>
        private void remoteNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        /// <summary>
        /// Кнопка для удаление записей
        /// </summary>
        private void RemoveNoteButton_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        /// <summary>
        /// Кнопка в меню для закрытии программы
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectManager.SaveProject(_project);
            Close();
        }

        /// <summary>
        /// Кнопка в меню для About
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutNewForm = new AboutForm();
            aboutNewForm.ShowDialog();
        }
    }
}

