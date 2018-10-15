using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс Заметки
    /// </summary>
    public class Note
    {
        /// <summary>
        /// Название заметки
        /// </summary>
        public string Title;

        /// <summary>
        /// Категория заметки
        /// </summary>
        public string NoteCategory;

        /// <summary>
        /// Текст в заметке
        /// </summary>
        public string Text;

        /// <summary>
        /// Время и дата создания заметки
        /// </summary>
        private DateTime _timeCreation;

        /// <summary>
        /// Время и дата последнего изменения заметки
        /// </summary>
        private DateTime _timeModified;


        public Note(){}
    }
}
