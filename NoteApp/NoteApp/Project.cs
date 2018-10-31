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
        public List<Note> Notes { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Project()
        {
            Notes = new List<Note>();
        }

        /// <summary>
        /// Сортировка списка заметок по времени изменения и категории.
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public List<Note> SortedNotes(NoteCategory category)
        {
            List<Note> notes = Notes.Where(t => t.Category == category)
                .OrderByDescending(t => t.TimeModified).ToList();

            return notes;
        }
    }
}
