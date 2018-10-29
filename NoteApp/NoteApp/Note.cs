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
        /// Название заметки.
        /// </summary>
        [JsonProperty]
        public string Title { get; set; }

        /// <summary>
        /// Текст в заметке.
        /// </summary>
        [JsonProperty]
        public string Text { get; set; }

        /// <summary>
        /// Категория заметки.
        /// </summary>
        [JsonProperty]
        public NoteCategory Category { get; set; }

        /// <summary>
        /// Время и дата создания заметки.
        /// </summary>
        [JsonProperty]
        public DateTime TimeCreation { get; private set; }

        /// <summary>
        /// Время и дата последнего изменения заметки.
        /// </summary>
        [JsonProperty]
        public DateTime TimeModified { get; set; }

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
