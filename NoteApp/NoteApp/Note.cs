using System;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Класс Заметки.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Note: ICloneable
    {
        /// <summary>
        /// Заголовок заметки.
        /// </summary>
        private string _title;
        
        /// <summary>
        /// Текст заметки.
        /// </summary>
        private string _text;

        /// <summary>
        /// Дата создания.
        /// </summary>
        private DateTime _timeCreation;

        /// <summary>
        /// Дата модификации.
        /// </summary>
        private DateTime _timeModified;

        /// <summary>
        /// Определение переменной _title.
        /// </summary>
        [JsonProperty]
        public string Title
        {
            get { return _title; }

            set
            {
                if (value == null)
                    throw new ArgumentNullException("Заголовок не может быть пустым!");

                if (value.Length > 50)
                    throw new ArgumentException("Длинна заголовка должна быть меньше 50 символов.");
                
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Заголовок не может быть пустым!");

                _title = value;
            }
        }

        /// <summary>
        /// Определение переменной _text.
        /// </summary>
        [JsonProperty]
        public string Text
        {
            get { return _text; }
            set
            {

                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Текст не может быть пустым!");

                _text = value;
            }
        }

        /// <summary>
        /// Категория заметки.
        /// </summary>
        [JsonProperty]
        public NoteCategory Category { get; set; }

        /// <summary>
        /// Время и дата создания заметки.
        /// </summary>
        [JsonProperty]
        public DateTime TimeCreation
        {
            get { return _timeCreation; }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Дата модификации не может быть больше чем текущая!");

                _timeCreation = value;
            }
        }

        /// <summary>
        /// Определение переменной _timeModified.
        /// </summary>
        [JsonProperty]
        public DateTime TimeModified
        {
            get { return _timeModified; }
            set
            {
                if (value < TimeCreation)
                    throw new ArgumentException("Дата модификации не может быть меньше чем дата создания!");

                if (value > DateTime.Now)
                    throw new ArgumentException("Дата модификации не может быть больше чем текущая!");

                _timeModified = value;
            }
        }

        /// <summary>
        /// Крнструктор по умолчанию.
        /// </summary>
        public Note()
        {
            Title = "Без названия";
            Category = NoteCategory.Different;
            TimeCreation = DateTime.Now;
            TimeModified = DateTime.Now;
        }

        /// <summary>
        /// Клонирование класса.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Note()
            {
                Category = this.Category,
                Title = this.Title,
                Text = this.Text,
                TimeCreation = this.TimeCreation,
                TimeModified = this.TimeModified
            };
        }
    }
}
