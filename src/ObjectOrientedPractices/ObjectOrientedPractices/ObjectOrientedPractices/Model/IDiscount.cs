using ObjectOrientedPractices.Model.Discounts;

namespace ObjectOrientedPractices.Model
{
    internal interface IDiscount 
    { 
        /// <summary>
        /// Метод для вывода информации.
        /// </summary>
        string Info { get; } 

        /// <summary>
        /// Метод для подсчета возможной скидки.
        /// </summary>
        /// <param name="items">Список товаров класса <see cref="Item"/>.</param>
        /// <returns></returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Список для подсчета скидки и обновления её величины.
        /// </summary>
        /// <param name="items">Список товаров класса <see cref="Item"/>.</param>
        /// <returns></returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Метод для обновления величины скидки после совершения заказа.
        /// </summary>
        /// <param name="items">Список товаров класса <see cref="Item"/></param>
        void Update(List<Item> items); 
    }
}
