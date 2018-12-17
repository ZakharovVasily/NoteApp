using System.Collections.Generic;
using System.Linq;

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
        public List<Note> Notes { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="noteList"></param>
        public Project(List<Note> noteList)
        {
            Notes = noteList;
        }

        public Project()
        {
            Notes = new List<Note>();
        }

        /// <summary>
        /// Сортировка списка заметок по времени изменения и категории.
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public List<Note> SortedNotesCategory(NoteCategory category)
        {
            List<Note> notes = Notes.Where(t => t.Category == category)
                .OrderByDescending(t => t.TimeModified).ToList();

            return notes;
        }

        /// <summary>
        /// Сортировка списка заметок по времени изменения
        /// </summary>
        /// <returns></returns>
        public List<Note> SortedNotes()
        {
            List<Note> notes = Notes.OrderByDescending(t => t.TimeModified).ToList();

            return notes;
        }
    }
}
