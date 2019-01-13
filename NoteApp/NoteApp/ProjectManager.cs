using Newtonsoft.Json;
using System.IO;

namespace NoteApp
{
    public static class ProjectManager
    {
        /// <summary>
        /// Экземпляр сериализатора.
        /// </summary>
        private static readonly JsonSerializer _serializer = new JsonSerializer();

        /// <summary>
        /// Сериализирование проекта в строку и сохранение в файл.
        /// </summary>
        /// <param name="saveProject"> Сохраняемый проект. </param>
        public static void SaveProject(Project saveProject, string streamWriter)
        {
            using (StreamWriter sw = new StreamWriter(streamWriter))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                _serializer.Serialize(writer, saveProject);
            }

        }

        /// <summary>
        /// Считывание json текста из файла и десериализация в проект.
        /// </summary>
        public static Project OpenProject(string streamReader)
        {
            if (!File.Exists(streamReader))
            {
                return null;
            }

            using (StreamReader sr = new StreamReader(streamReader))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                return _serializer.Deserialize<Project>(reader);
            }
        }
    }
}
