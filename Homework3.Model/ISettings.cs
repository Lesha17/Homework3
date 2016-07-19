//
// Дисциплина: Программирование
// Студент: Мачнев Алексей
// Работа: Контрольное Домашнее задание за 3й модуль, вариант 8
// Дата написаниия: 24 февраля 2016 г.
// Файл содержит описание интерфейса ISettings
//

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Homework3.Model
{
    /// <summary>
    /// Интерфейс описывает настройки программы
    /// </summary>
    public interface ISettings
    {
        /// <summary>
        /// Должен возвращать количество позиций для отображения в списке
        /// </summary>
        uint CountOfPositions { get; set; }
        
        /// <summary>
        /// Должен возвращать список выбранных в тексте номеров позиций
        /// </summary>
        IEnumerable<uint> CheckedPositions { get; }

        /// <summary>
        /// Сообщает о том, что в списке отмечена позиция pos
        /// </summary>
        /// <param name="pos">Значение отмеченнной в списке позиции</param>
        void Check(uint pos);

        /// <summary>
        /// Сообщает о том, что в списке снята отметка с позиции pos
        /// </summary>
        /// <param name="pos">Значение позиции, с которой снята отметка</param>
        void Uncheck(uint pos);

        /// <summary>
        /// Сообщает о том, что в списке сняты отметки со всех позиций
        /// </summary>
        void UncheckAll();

        /// <summary>
        /// Возвращает количество знаков после запятой при выводе значений
        /// </summary>
        uint Precision { get; set; }

        /// <summary>
        /// Выполняет асинхронное сохранение настроек в файл по пути path
        /// </summary>
        /// <param name="path">Путь к файлу, в котором нужно сохранить настройки</param>
        /// <returns></returns>
        Task Save(string path);
    }
}
