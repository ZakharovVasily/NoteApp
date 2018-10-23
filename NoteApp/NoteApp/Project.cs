using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс содержащий заметки и методы для них
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список заметок
        /// </summary>
        public List<Note> _note;

        public Project()
        {
            _note = new List<Note>();
            CountNote = -1;
        }

        /// <summary>
        /// Счетчик кол-ва заметок в списке
        /// </summary>
        private int _countNote;

        public int CountNote
        {
            set { _countNote = value; }
            get { return _countNote; }
        }

        /// <summary>
        /// Метод добавления\изменения заметок
        /// </summary>
        public void ChangeNote(Note NoteMod, string NewTitle, NoteCategory NewCategory, string NewText,
            DateTime NewTimeCreation, DateTime NewTimeModified)
        {
            if (NoteMod != null)
            {
                NoteMod.Title = NewTitle;
                NoteMod.Text = NewText;
                NoteMod.Category = NewCategory;
                NoteMod.TimeModified = NewTimeModified;
            }
            else
            {
                Note NewNote = new Note();
                NewNote.Title = NewTitle;
                NewNote.Text = NewText;
                NewNote.Category = NewCategory;
                NewNote.TimeModified = NewTimeModified;
                _countNote++;
                _note.Add(NewNote);
            }
        }

        /// <summary>
        /// Из категории в текст
        /// </summary>
        /// <param name="NewCategory"></param>
        /// <returns>Возращает строку категории</returns>
        public string NoteCategoryToStr(NoteCategory NewCategory)
        {
            switch (NewCategory)
            {
                case NoteCategory.Different:
                    return "Different";

                case NoteCategory.Documents:
                    return "Documents";

                case NoteCategory.Finance:
                    return "Finance";

                case NoteCategory.HealthAndSport:
                    return "HealthAndSport";

                case NoteCategory.House:
                    return "House";

                case NoteCategory.Job:
                    return "Job";

                default:
                    return "";
            }
        }

        /// <summary>
        /// Из текста в категорию
        /// </summary>
        /// <param name="NewCategory"></param>
        /// <returns>Возращает строку категории</returns>
        public NoteCategory StrToNoteCategory(string TextCategory)
        {
            switch (TextCategory)
            {
                case "Different":
                    return NoteCategory.Different;

                case "Documents":
                    return NoteCategory.Documents;

                case "Finance":
                    return NoteCategory.Finance;

                case "HealthAndSport":
                    return NoteCategory.HealthAndSport;

                case "House":
                    return NoteCategory.House;

                case "Job":
                    return NoteCategory.Job;

                default:
                    return NoteCategory.Different;
            }
        }
    }
}
