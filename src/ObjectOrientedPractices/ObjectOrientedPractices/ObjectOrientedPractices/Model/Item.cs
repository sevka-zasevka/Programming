using ObjectOrientedPractices.Model.Enums;
using ObjectOrientedPractices.Services;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Класс, хранящий id, название, описание и цену товара.
    /// </summary>
    internal class Item
    {
        /// <summary>
        /// Id товара, уникальный
        /// </summary>
        readonly int _id = IdGenerator.GetNextId();
        /// <summary>
        /// Название товара, до 200 символов.
        /// </summary>
        private string _name;
        /// <summary>
        /// Описание товара, до 200 символов.
        /// </summary>
        private string _info;
        /// <summary>
        /// Цена товара, до 100 000.
        /// </summary>
        private double _cost;
        /// <summary>
        /// Категория товара.
        /// </summary>
        private Category _category;

        /// <summary>
        /// Возвращает уникальный id товара.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает и задает название товара.
        /// </summary>
        public string Name
        { 
            get { return _name; } 
            set 
            {
                ValueValidator.AssertStringOnLength(value, 200, "Item.Name");
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает описание товара.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set 
            { 
                ValueValidator.AssertStringOnLength(value, 1000, "Item.Info");
                _info = value; 
            }
        }

        /// <summary>
        /// Возвращает и задает цену товара.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set 
            {
                ValueValidator.CheckDoubleValue(0, 100000, value, "Item.Cost");
                _cost = value; 
            }
        }

        /// <summary>
        /// Возвращает и задает категорию товара из перечисления.
        /// </summary>
        public Category Category
        {
            get => _category;
            set
            {
                _category = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара, до 200 символов.</param>
        /// <param name="info">Описание товара, до 1000 символов.</param>
        /// <param name="cost">Цена товара, до 100 000.</param>
        /// <param name="category">Категория товара, из перечисления <see cref="Category"/></param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }
    }
}
