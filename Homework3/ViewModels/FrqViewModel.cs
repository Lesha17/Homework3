//
// Дисциплина: Программирование
// Студент: Мачнев Алексей
// Работа: Контрольное Домашнее задание за 3й модуль, вариант 8
// Дата написаниия: 24 февраля 2016 г.
// Файл содержит описание класса FrqViewModel
//

using System.Collections.Generic;
using System.Linq;
using Homework3.Model;

namespace Homework3.ViewModels
{
    // Является моделью представления для IFrqData
    public class FrqViewModel
    {
        public FrqViewModel(IFrqData data)
        {
            this.Data = data;
        }

        // Возвращает список букв
        public IEnumerable<char> Letters
        {
            get
            {
                var q = from a in Data.Data.Values
                        from p in a.Keys
                        select p;

                return q.Distinct().OrderBy(p => char.ToUpperInvariant(p));
            }
        }

        // Возвращает список описанных позиций в слове
        public IEnumerable<uint> Positions
        {
            get
            {
                return Data.Data.Keys.OrderBy(p => p);
            }
        }

        public IFrqData Data
        {
            get; set;
        }

        // Возвращает массив строк, каждая из которых
        // является строковым представлением частоты буквы
        // для заданной позиции в слове
        // с заданной точностью
        public string[] RowAt(uint index, uint precision)
        {
            var q = from p in Data.Data[index].Values
                    select decimal.Round(p, (int)precision).ToString();

            return q.ToArray();
        }
    }
}
