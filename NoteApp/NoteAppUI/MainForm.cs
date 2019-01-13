using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Поле для хранения пути файла.
        /// </summary>
        private readonly string _address = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\NoteApp.json";

        /// <summary>
        /// Обьект класса.
        /// </summary>
        private  static  Project _project = new Project();

        /// <summary>
        /// Поле для показываемых заметок.
        /// </summary>
        private static List<Note> _showNotes;

        public MainForm()
        {
            InitializeComponent();

            if (ProjectManager.OpenProject(_address) != null)
            {
                _project = ProjectManager.OpenProject(_address);
            }

            AddCategoryBox();
         }

        /// <summary>
        /// Добавляем категории.
        /// </summary>
        private void AddCategoryBox()
        {
            NoteCategoryBox.Items.Add("All");
            NoteCategoryBox.Items.AddRange(Enum.GetNames(typeof(NoteCategory)));

            NoteCategoryBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Вывод текста из ListBox'a в TextBox.
        /// </summary>
        private void ListBoxNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: Items.Any! new VS
            if (ListBoxNote.SelectedIndex > -1)
            {
                
                if (ListBoxNote.Items.Count > 0)
                {
                    var note = _showNotes[ListBoxNote.SelectedIndex];

                    NoteTextBox.Text = note.Text;
                    TimeCreateLabel.Text = note.TimeCreation.ToString("dd/MM/yyyy");
                    TimeModifiedLabel.Text = note.TimeModified.ToString("dd/MM/yyyy");
                    SelectNameLabel.Text = note.Title;
                    SelectCategoryLabel.Text = note.Category.ToString();
                }
            }
        }

        /// <summary>
        /// Метод для добавления новой записи.
        /// </summary>
        public void AddNote()
        {
            var addNoteForm = new AddNoteForm();
            var selectedNote = new Note();

            addNoteForm.Data = selectedNote;
            addNoteForm.ShowDialog();

            if (addNoteForm.DialogResult == DialogResult.OK)
            {
                _project.Notes.Add(addNoteForm.Data);
                ListBoxNote.Items.Add(addNoteForm.Data.Title);
            }

            ShowListBoxNote();

            ProjectManager.SaveProject(_project, _address);
        }

        /// <summary>
        /// Метод для редактирования существующей записи.
        /// </summary>
        public void EditNote()
        {
            if (ListBoxNote.SelectedItem == null)
            {
                MessageBox.Show("Заметка не выбрана!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedIndex = ListBoxNote.SelectedIndex;
            ListBoxNote.SelectedIndex = -1;

            var addNoteForm = new AddNoteForm();
            var selectedNote = _showNotes[selectedIndex];

            addNoteForm.Data = selectedNote;
            addNoteForm.ShowDialog();

            ListBoxNote.Items[selectedIndex] = addNoteForm.Data.Title;

            NoteTextBox.Update();
            ListBoxNote.Update();

            ShowListBoxNote();

            ProjectManager.SaveProject(_project, _address);
        }

        /// <summary>
        /// Метод для удаления записи.
        /// </summary>
        public void RemoveNote()
        {
            if (ListBoxNote.SelectedItem == null)
            {
                MessageBox.Show("Заметка не выбрана!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = new System.Windows.Forms.DialogResult();
            result = MessageBox.Show("Вы точно хотите удалить заметку: " + ListBoxNote.Items[ListBoxNote.SelectedIndex], 
                "Удаление заметки", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                ClearAll();
                _project.Notes.RemoveAt(ListBoxNote.SelectedIndex);
                ListBoxNote.Items.RemoveAt(ListBoxNote.SelectedIndex);

                ShowListBoxNote();

                ProjectManager.SaveProject(_project, _address);
            }
        }

        /// <summary>
        /// Выводит заметки в лист боксе.
        /// </summary>
        public void ShowListBoxNote()
        {
            ListBoxNote.Items.Clear();
            ClearAll();

            if (_project.Notes.Count <= 0)
                return;

            if (NoteCategoryBox.SelectedItem.ToString() != "All")
                _showNotes = _project.SortedNotesCategory(EnumParser.StringToNoteCategory
                    (NoteCategoryBox.SelectedItem.ToString()));
            else
                _showNotes = _project.SortedNotes();

            foreach (Note t in _showNotes)
            {
                ListBoxNote.Items.Add(t.Title);
            }
        }

        /// <summary>
        /// Вывод данных в листбокс по категориям из ComboBox.
        /// </summary>
        private void NoteCategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowListBoxNote();
        }

        /// <summary>
        /// Очищает все поля.
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
        /// Кнопка в меню для добавления новой заметки.
        /// </summary>
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        /// <summary>
        /// Кнопка для добавления новой заметки.
        /// </summary>
        private void AddNote_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        /// <summary>
        /// Кнопка в меню для редактирования заметки.
        /// </summary>
        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        /// <summary>
        /// Кнопка для редактирования заметки.
        /// </summary>
        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        /// <summary>
        /// Кнопка для удаления заметки.
        /// </summary>
        private void RemoveNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        /// <summary>
        /// Кнопка для удаление записей.
        /// </summary>
        private void RemoveNoteButton_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        /// <summary>
        /// Кнопка в меню для закрытии программы.
        /// </summary>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectManager.SaveProject(_project, _address);
            Close();
        }

        /// <summary>
        /// Кнопка в меню для About.
        /// </summary>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutNewForm = new AboutForm();
            aboutNewForm.ShowDialog();
        }

        /// <summary>
        /// Обработчик событий для кнопки Delete, по удалению заметки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                RemoveNote();
            }
        }
    }
}

