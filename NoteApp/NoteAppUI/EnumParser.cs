using System;
using NoteApp;

namespace NoteAppUI
{
    /// <summary>
    /// Вспомагающий класс для парсера.
    /// </summary>
    static class EnumParser
    {
        /// <summary>
        /// Из категории в текст.
        /// </summary>
        /// <param name="newCategory"></param>
        /// <returns>Возращает строку категории</returns>
        static public string NoteCategoryToString(NoteCategory newCategory)
        {
            return newCategory.ToString();
        }

        /// <summary>
        /// Из текста в категорию.
        /// </summary>
        /// <param name="textCategory"></param>
        /// <returns>Возращает строку категории</returns>
        static public NoteCategory StringToNoteCategory(string textCategory)
        {
            //TODO: Enum try pars
            switch (textCategory)
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
