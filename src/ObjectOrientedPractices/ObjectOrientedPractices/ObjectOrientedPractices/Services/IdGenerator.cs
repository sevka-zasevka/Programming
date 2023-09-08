using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Services
{
    /// <summary>
    /// Класс, назначающий сквозные индетефикаторы для покупателей и товара.
    /// </summary>
    internal static class IdGenerator
    {
        /// <summary>
        /// id.
        /// </summary>
        private static int Id = 0;
        
        /// <summary>
        /// Метод, генерирует уникальный индетификаторы.
        /// </summary>
        /// <returns>Возвращает уникальный номер id.</returns>
        public static int GetNextId()
        {
            return Id++;
        }
    }
}
