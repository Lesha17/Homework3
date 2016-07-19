//
// Дисциплина: Программирование
// Студент: Мачнев Алексей
// Работа: Контрольное Домашнее задание за 3й модуль, вариант 8
// Дата написаниия: 24 февраля 2016 г.
// Файл содержит описание класса ошибки FormatException
//

using System;

namespace Homework3.Model
{
    /// <summary>
    /// Возникает при попытке чтения из файла, данные в котором хранятся в некорректном формате
    /// </summary>
    public class LoadException  : FormatException
    {
        /// <summary>
        /// Создает это исключение
        /// </summary>
        /// <param name="message">Сообщение</param>
        /// <param name="file_name">
        /// Путь к файлу, попытка чтения которого была осуществлена
        /// </param>
        public LoadException(string message, string file_name) : base(message)
        {
            this.FileName = file_name;
        }

        /// <summary>
        /// Возвращает путь к файлу, попытка чтения которого была осуществлена
        /// </summary>
        public String FileName { get; private set; }
    }
}
