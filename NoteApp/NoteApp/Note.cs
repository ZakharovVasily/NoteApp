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
    public class Note: ICloneable
    {
        /// <summary>
        /// Название заметки
        /// </summary>
        public string Title;

         /// <summary>
        /// Текст в заметке
        /// </summary>
        public string Text;

        /// <summary>
        /// Категория заметки
        /// </summary>
        private NoteCategory _category;

        public NoteCategory Category
        {
            set { _category = value; }
            get { return _category; }
        }     

        /// <summary>
        /// Время и дата создания заметки
        /// </summary>
        private DateTime _timeCreation;

        public DateTime TimeCreation
        {
            get { return _timeCreation;  }
        }

        /// <summary>
        /// Время и дата последнего изменения заметки
        /// </summary>
        private DateTime _timeModified;

        public DateTime TimeModified
        {
            set { _timeModified = value; }
            get { return _timeModified; }
        }

        /// <summary>
        /// Крнструктор по умолчанию
        /// </summary>
        public Note()
        {
            Title = string.Empty;
            Text = string.Empty;
            _category = NoteCategory.Different;
            _timeCreation = DateTime.Now;
            _timeModified = DateTime.Now;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
