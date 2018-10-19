using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace NoteAppUI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
         }
    }

    /// <summary>
    /// Класс для передачи данных между формами
    /// </summary>
    static class Data
    {
        /// <summary>
        /// Передача заголовка между формами
        /// </summary>
        public static string TmpTitle;

        /// <summary>
        /// Передача основного текста между формами
        /// </summary>
        public static string TmpText;

        /// <summary>
        /// Передача времени создании между формами
        /// </summary>
        public static DateTime TmpTimeCreate;

        /// <summary>
        /// Передача времени создании между формами
        /// </summary>
        public static string TmpNoteCategory;
    }

}
