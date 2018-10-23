using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace NoteApp
{
    /*public class ManagerProject
    {
        /// <summary>
        ///     Поле для хранения <see cref="Newtonsoft.Json.JsonSerializer" />
        /// </summary>
        private static readonly JsonSerializer JsonSerializer;

        /// <summary>
        ///     Путь к файлу проекта.
        /// </summary>
        private readonly string _pathToProjectFile;

        /// <summary>
        ///     Статический конструктор.
        /// </summary>
        static ProjectManager()
        {
            //var myDocumentsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //PathToProjectFile = $"{myDocumentsFolderPath}\\NoteApp.notes";

            JsonSerializer = JsonSerializer.Create();
            JsonSerializer.Formatting = Formatting.Indented;
        }
        
        /// <summary>
        ///     Конструктор, устанавливающий путь к файлу проекта.
        /// </summary>
        /// <param name="pathToProjectName"> Путь к файлу проекта. </param>
        public ProjectManager(string pathToProjectName)
        {
            _pathToProjectFile = pathToProjectName;
        }

        /// <summary>
        ///     Сохраняет проект в файл.
        /// </summary>
        /// <param name="saveableProject"> Сохраняемый проект. </param>
        public void SaveProject(Project saveableProject)
        {
            using (var streamWriter = new StreamWriter(_pathToProjectFile))
            using (var jsonWriter = new JsonTextWriter(streamWriter))
            {
                JsonSerializer.Serialize(jsonWriter, saveableProject);
            }
        }
    }*/
}
