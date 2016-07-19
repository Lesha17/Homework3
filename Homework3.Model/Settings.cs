//
// Дисциплина: Программирование
// Студент: Мачнев Алексей
// Работа: Контрольное Домашнее задание за 3й модуль, вариант 8
// Дата написаниия: 24 февраля 2016 г.
// Файл содержит описание класса Settings
//

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System;

namespace Homework3.Model
{
    /// <summary>
    /// Класс является реализацией интерфейса ISettings
    /// </summary>
    public class Settings : ISettings
    {
        // Шаблон записи, описывающий все настройки
        const string pattern = @"\s*Точность:\s*(\d+)\s*[\r\n]+\s*Позиций:\s*(\d+)\s*[\r\n]+\s*Отмеченные\s*позиции:(\s+\d+)*";
        // Шаблон записи об одной выбранной в списке позиции
        const string checked_pattern = @"\s+(\d+)";
        // Кодировка файла
        static readonly Encoding file_encoding = Encoding.GetEncoding("windows-1251");
        // Строка форматирования для сохранения настроек    
        const string to_format = "Точность: {0}\nПозиций: {1}\n Отмеченные позиции: {2}";

        /// <summary>
        /// Выполняет асинхронную загрузку настроек из файла
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns>Объект, представляющий настройки</returns>
        public static async Task<Settings> Load(string path)
        {
            Settings settings = new Settings(1, 0);

            using (StreamReader reader = new StreamReader(path, file_encoding))
            {
                string content = await reader.ReadToEndAsync();

                if (!(await Task.Run(() => Regex.IsMatch(content, pattern, RegexOptions.IgnoreCase))))
                {
                    throw new LoadException("Неправильный формат файла настроек", path);
                }

                foreach(Match m in Regex.Matches(content, pattern, RegexOptions.IgnoreCase))
                {
                    settings.Precision = uint.Parse(m.Groups[1].Value);
                    settings.CountOfPositions = uint.Parse(m.Groups[2].Value);
                    
                    foreach(Capture capt in m.Groups[3].Captures)
                    {
                        Match capt_match = Regex.Match(capt.Value, checked_pattern);
                        settings.Check(uint.Parse(capt_match.Groups[1].Value));
                    }
                }
            }
            return settings;
        }

        private List<uint> checked_pos;
        
        /// <summary>
        /// Создаёт объект этого класса с пустым списком отмеченных в списке позиций
        /// </summary>
        /// <param name="count_of_positions">Количество позиций для отображения в списке</param>
        /// <param name="precision">Количество знаков после запятой при выводе значений</param>
        public Settings(uint count_of_positions, uint precision)
        {
            this.CountOfPositions = count_of_positions;
            this.Precision = precision;
            CheckedPositions = new List<uint>();
        }

        /// <summary>
        /// Возвращает или задаёт список отмеченных в списке позиций
        /// </summary>
        public IEnumerable<uint> CheckedPositions
        {
            get { return checked_pos.OrderBy(p => p); }
            set { this.checked_pos = new List<uint>(value); }
        }

        /// <summary>
        /// Возвращает или задаёт количество позиций для отображения в списке
        /// </summary>
        public uint CountOfPositions { get; set; }

        /// <summary>
        /// Возвращает или задаёт количество знаков после запятой при выводе значений
        /// </summary>
        public uint Precision { get; set; }

        /// <summary>
        /// Сообщает о том, что в списке выбрана позиция num
        /// </summary>
        /// <param name="pos">Номер позиции, которая выбрана</param>
        public void Check(uint pos)
        {
            checked_pos.Add(pos);
        }

        /// <summary>
        /// Выполняет асинхронное сохранение настроек в файл по пути path
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns></returns>
        public async Task Save(string path)
        {
            string pos_arr = "";

            foreach(var pos in CheckedPositions)
            {
                pos_arr = string.Format("{0} {1}", pos_arr, pos);
            }

            string to_save = string.Format(to_format, this.Precision, this.CountOfPositions, pos_arr);

            using (StreamWriter writer = new StreamWriter(File.Open(path, FileMode.Create, FileAccess.Write), file_encoding))
            {
                await writer.WriteAsync(to_save);
            }
        }

        /// <summary>
        /// Сообщает о том, что в списке снята отметка с позиции pos
        /// </summary>
        /// <param name="pos">Значение позиции, с которой снята отметка</param>
        public void Uncheck(uint pos)
        {
            checked_pos.Remove(pos);
        }

        /// <summary>
        /// Сообщает о том, что в списке сняты отметки со всех позиций
        /// </summary>
        public void UncheckAll()
        {
            this.checked_pos.Clear();
        }
    }
}
