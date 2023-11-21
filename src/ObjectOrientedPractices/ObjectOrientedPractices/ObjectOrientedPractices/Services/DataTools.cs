using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.Model.Enums;

namespace ObjectOrientedPractices.Services
{
    internal delegate bool CompareValues(Item item, object obj);
    internal delegate List<Item> SortingDelegate(List<Item> items);

    internal static class DataTools
    {
        /// <summary>
        /// Метод для сравнения товаров с определённой ценой.
        /// </summary>
        /// <param name="item">Товар - объект класса <see cref="Item"/>.</param>
        /// <param name="price">Определённая цена типа double.</param>
        /// <returns>Булевое значение относительно результата сравнения.</returns>
        public static bool ToPrice(Item item, object price) 
        {
            return item.Cost > (double)price; 
        }

        /// <summary>
        /// Метод для сравнения товаров с определённной категорией.
        /// </summary>
        /// <param name="item">Товар - объект класса <see cref="Item"/>.</param>
        /// <param name="categoty">Определённая категория товара из перечисления <see cref="Category"/>.</param>
        /// <returns>Булевое значение относительно результата сравнения.</returns>
        public static bool ToCategory(Item item, object categoty) 
        { 
            return item.Category == (Category)categoty; 
        }

        /// <summary>
        /// Метод для создания списка товаров класса <see cref="Item"/> исходя из передоваемого критерия.
        /// </summary>
        /// <param name="values">Изначальный список товаров, оъектов класса <see cref="Item"/>.</param>
        /// <param name="compare">Передаваемый критерий сравнения.</param>
        /// <param name="obj">Объеект для сравнения.</param>
        /// <returns>Список объектов класса <see cref="Item"/>.</returns>
        public static List<Item> Filtration(List<Item> values, CompareValues compare, object obj) 
        { 
            var result = new List<Item>();
            for (int i = 0; i < values.Count; i++) 
            {
                if (compare(values[i], obj))
                {
                    result.Add(values[i]);
                }
            } 
            return result;
        }

        /// <summary>
        /// Сортирует список товаров по имени в алфавитном порядке. 
        /// </summary>
        /// <param name="items">Список товаров. </param>
        /// <returns>Отсортированный список. </returns>
        public static List<Item> SortName(List<Item> items)
        {
            items.Sort((left, right) => left.Name.CompareTo(right.Name));
            return items;
        }

        public static List<Item> SortCostAscending(List<Item> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 1; j < items.Count; j++)
                {
                    if (items[j].Cost < items[j - 1].Cost)
                    {
                        Item temp = items[j];
                        items[j] = items[j - 1];
                        items[j - 1] = temp;
                    }
                }
            }
            return items;
        }

        /// <summary>
        /// Сортирует список товаров по цене по убыванию. 
        /// </summary>
        /// <param name="items">Список товаров. </param>
        /// <returns>Отсортированный список товаров. </returns>
        public static List<Item> SortCostDescending(List<Item> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 1; j < items.Count; j++)
                {
                    if (items[j].Cost > items[j - 1].Cost)
                    {
                        Item temp = items[j];
                        items[j] = items[j - 1];
                        items[j - 1] = temp;
                    }
                }
            }
            return items;
        }

        /// <summary>
        /// Сортирует список товаров по указанному критерию. 
        /// </summary>
        /// <param name="items">Список товаров. </param>
        /// <param name="sortingDelegate">Критерий сортировки. </param>
        /// <returns>Отсортированный список. </returns>
        public static List<Item> Sort(List<Item> items, SortingDelegate sortingDelegate)
        {
            return sortingDelegate(items);
        }
    }
}

