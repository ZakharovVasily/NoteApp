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
        public IList<Note> Note { get; set; }

        /// <summary>
        /// Количество записей в листе
        /// </summary>
        public int CountList { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Project()
        {
            Note = new List<Note>();
            CountList = -1;
        }

        /// <summary>
        /// Метод добавления\изменения заметок
        /// </summary>
        public void AddNote(Note note)
        {
            //TODO: принцип Solid
            if (note == null)
                throw new ArgumentNullException(nameof(note));

            Note.Add(note);
            CountList++;
        }
    }
}
