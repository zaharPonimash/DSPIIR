using Newtonsoft.Json;
using System;
using System.Globalization;
using System.IO;

namespace FilterGenLogic
{
    // Настройки проекта
    [Serializable]
    public class ProjectSettings
    {
        public int Fd { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        private string _path;


        public ProjectSettings()
        {
        }

        /// <summary>
        /// Настройки проекта
        /// </summary>
        /// <param name="name">Имя проекта</param>
        /// <param name="fd">Настройки</param>
        public ProjectSettings(string name, int fd)
        {
            Name = name;
            Fd = fd;
        }

        /// <summary>
        /// Настройки проекта
        /// </summary>
        /// <param name="name">Имя проекта</param>
        /// <param name="fd">Настройки</param>
        /// <param name="desc">Описание</param>
        public ProjectSettings(string name, string desc, int fd)
        {
            Description = desc;
            Name = name;
            Fd = fd;
        }

        /// <summary>
        /// Сохранение "Сохранить как"
        /// </summary>
        /// <param name="path">Путь до файл</param>
        public void Save(string path)
        {
            _path = path;
            string json = JsonConvert.SerializeObject(this);
            File.WriteAllText(path, json);
        }



        /// <summary>
        /// Сохранение
        /// </summary>
        public void Save()
        {
            string json = JsonConvert.SerializeObject(this);
            File.WriteAllText(_path, json);
        }


        /// <summary>
        /// Загрузка
        /// </summary>
        /// <param name="path">Путь до файл</param>
        public static ProjectSettings Open(string path)
        {
            string json = File.ReadAllText(path);
            ProjectSettings dat = JsonConvert.DeserializeObject<ProjectSettings>(json);
            dat._path = path;
            return dat;
        }

        /// <summary>
        /// Строка в число
        /// </summary>
        public static double ToDouble(string data)
        {
            NumberFormatInfo provider = new NumberFormatInfo
            {
                NumberDecimalSeparator = ",",
                NumberGroupSeparator = ".",
                NumberGroupSizes = new int[] { 3 }
            };
            string str = data.Replace(".", ",");
            return Convert.ToDouble(str, provider);
        }
    }
}
