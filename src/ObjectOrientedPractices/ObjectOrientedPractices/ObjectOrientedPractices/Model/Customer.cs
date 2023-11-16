using ObjectOrientedPractices.Model.Discounts;
using ObjectOrientedPractices.Model.Orders;
using ObjectOrientedPractices.Services;

namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Класс, хранящий id, ФИО и адресс покупателя.
    /// </summary>
    internal class Customer
    {
        /// <summary>
        /// id покупателя, уникальный.
        /// </summary>
        private int _id = IdGenerator.GetNextId();
        /// <summary>
        /// ФИО покупателя, до 200 символов.
        /// </summary>
        private string _fullname;
        /// <summary>
        /// Адрес покупателя, объект класса <see cref="Address"/>.
        /// </summary>
        private Address _address;
        /// <summary>
        /// Корзина покупателя, объект класса <see cref="Cart"/>.
        /// </summary>
        private Cart _cart;
        /// <summary>
        /// Список заказов покупателя, объекты класса <see cref="Order"/>
        /// </summary>
        private List<Order> _orders;
        /// <summary>
        /// Флаг проверки приоритетности покупателя.
        /// </summary>
        private bool _isPriority;
        /// <summary>
        /// Список всех скидок покупателя. Интерфейс <see cref="IDiscount"/>.
        /// </summary>
        private List<IDiscount> _discounts;

        /// <summary>
        /// Возвращает id покупателя, уникальный
        /// </summary>
        public int Id
        { 
            get 
            { 
                return _id; 
            } 
        }
        /// <summary>
        /// Возвращает и задает ФИО покупателя. 
        /// </summary>
        public string Fullname
        {
            get 
            { 
                return _fullname; 
            }
            
            set 
            {
                ValueValidator.AssertStringOnLength(value, 200, "Customer.Fullname");
                _fullname = value; 
            }
        }

        /// <summary>
        /// Возвращает и задает Адрес покупателя.
        /// </summary>
        public Address Address
        {
            get 
            { 
                return _address; 
            }

            set 
            {
                _address = value; 
            }
        }

        /// <summary>
        /// Возвращает и задаёт корзину покупателя.
        /// </summary>
        public Cart Cart
        {
            get
            {
                return _cart;
            }
            set
            {
                _cart = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт списоз заказов, объекты класса <see cref="Order"/>
        /// </summary>
        public List<Order> Orders
        {
            get
            {
                return _orders;
            }

            set
            {
                _orders = value;
            }
        }

        /// <summary>
        /// Возвращает и задает флаг приоритетности покупателя.
        /// </summary>
        public bool IsPriority
        {
            get { return _isPriority; }
            set { _isPriority = value; }
        }

        public List<IDiscount> Discounts
        {
            get { return _discounts; }
            set { _discounts = value; }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Фио покупателя, до 200 символов.</param>
        public Customer(string fullname)
        {
            Fullname = fullname;
            Address = new Address();
            Cart = new Cart();
            Orders = new List<Order>();
            Discounts = new List<IDiscount>();
            PointsDiscount pointsDiscount = new PointsDiscount();
            Discounts.Add(pointsDiscount);
            IsPriority = false;
        }
    }
}
