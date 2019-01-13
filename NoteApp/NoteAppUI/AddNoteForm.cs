using System;
using System.Drawing;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class AddNoteForm : Form
    {
        /// <summary>
        /// Поле для передачи данных.
        /// </summary>
        private Note _data;

        /// <summary>
        /// Определение поля _data.
        /// </summary>
        public Note Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;

                if (_data != null)
                {
                    NewTextTextBox.Text = _data.Text;
                    NewTitleTextBox.Text = _data.Title;
                    NewTimeCreateLabel.Text = _data.TimeCreation.ToString("dd/MM/yyyy");
                    NewTimeModifiedLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
                }
            }
        }

        public AddNoteForm()
        {
            InitializeComponent();

            AddCategoryBox();
        }

        /// <summary>
        /// Кнопка для возвращение на главную форму
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                _data.Title = NewTitleTextBox.Text;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try
            {
                _data.Text = NewTextTextBox.Text;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try
            {
                _data.TimeModified = DateTime.Now;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                return;
            }

            _data.Category = EnumParser.StringToNoteCategory(NewNoteCategoryBox.Text);

            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Метод для добавления категорий
        /// </summary>
        private void AddCategoryBox()
        {
            NewNoteCategoryBox.DataSource = Enum.GetValues(typeof(NoteCategory));
            NewNoteCategoryBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Кнопка отмены (выход из окна добавления/изменения без сохранения)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewTitleText_TextChanged(object sender, EventArgs e)
        {
            if (NewTitleTextBox.Text.Length > 50)
            {
                NewTitleTextBox.ForeColor = Color.Red;
            }
            else
            {
                NewTitleTextBox.ForeColor = Color.Black;
            }
        }
    }
}
