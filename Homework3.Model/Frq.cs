//
// Дисциплина: Программирование
// Студент: Мачнев Алексей
// Работа: Контрольное Домашнее задание за 3й модуль, вариант 8
// Дата написаниия: 24 февраля 2016 г.
// Файл содержит описание класса Frq
//

using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Homework3.Model
{
    /// <summary>
    /// Класс является реализацией интерфейса IFrqData
    /// </summary>
    public class Frq : IFrqData
    {
        // Шаблон записи, описывающей одну позицию букв в слове
        const string pattern = @"Позиция\s*№\s*(\d+)\s*[\r\n]+\s*Буква\s*%\s*[\r\n]+(\s*\w\s+\d+[\.,]?\d*[\r\n]+)+";
        // Шаблон записи, описывающей одну букву в данной позиции
        const string capture_pattern = @"(\w)\s+(\d+[\.,]?\d*)[\r\n]+";
        // Кодировка файла 
        static readonly Encoding file_encoding = Encoding.GetEncoding("windows-1251");
        
        private Frq(Dictionary<uint, Dictionary<char, decimal>> data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Возвращает коллекцию значений 
        /// результотов графематического анализа
        /// где для каждой позиции в слове определены
        /// частоты каждой буквы в данной позиции
        /// Ключ - позиция в слове
        /// Значение - коллекция буква - частота встречаемости в данной позиции
        /// </summary>
        public Dictionary<uint, Dictionary<char, decimal>> Data { get; private set; }

        /// <summary>
        /// Выполняет асинхронное чтение данных из файла, путь к которому указан в path
        /// </summary>
        /// <param name="path">Путь к файлу с данными</param>
        /// <returns>Объект класса Frq, представляющий результаты графематического анализа</returns>
        public static async Task<Frq> LoadAsync(string path)
        {
            Frq frq = new Frq(new Dictionary<uint, Dictionary<char, decimal>>());

            using (StreamReader reader = new StreamReader(path, file_encoding))
            {
                string content = await reader.ReadToEndAsync();

                if (!(await Task.Run(() => Regex.IsMatch(content, pattern, RegexOptions.IgnoreCase))))
                {
                    throw new LoadException("Неправильный формат файла 'frq'", path);
                }

                // Ищем и обрабатываем записи о каждой позиции в слове
                foreach (Match m in await Task.Run(() => Regex.Matches(content, pattern, RegexOptions.IgnoreCase)))
                {
                    // Номер позиции в слове
                    uint num = uint.Parse(m.Groups[1].Value);

                    var _dict_for_num = new Dictionary<char, decimal>();

                    // Обрабатываем записи о каждой букве в данной позиции
                    foreach (Capture c in m.Groups[2].Captures)
                    {
                        Match capt_m = Regex.Match(c.Value, capture_pattern);
                        
                        // Буква 
                        char letter = capt_m.Groups[1].Value[0];
                        // Процент встречаемости в позиции num
                        decimal freq = decimal.Parse(capt_m.Groups[2].Value);

                        _dict_for_num.Add(letter, freq);
                    }
                    frq.Data.Add(num, _dict_for_num);
                }
            }

            return frq;
        }
    }
}
