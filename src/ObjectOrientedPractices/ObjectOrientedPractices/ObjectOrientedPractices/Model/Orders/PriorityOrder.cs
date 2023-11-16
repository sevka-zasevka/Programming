using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model.Orders
{
    internal class PriorityOrder : Order
    {
        /// <summary>
        /// Нужное время доставки.
        /// </summary>
        private int _curentDeliveryTime;
        /// <summary>
        /// Нужная дата доставки.
        /// </summary>
        private DateTime _curentDeliveryData;
        /// <summary>
        /// Возможные временные промежутки для доставки. 
        /// </summary>
        public static string[] DeliveryTimeChoise = new string[7] { "9:00 – 11:00", "11:00 – 13:00", "13:00 – 15:00", "15:00 – 17:00", "17:00 – 19:00", "19:00 – 21:00", "Время не выбрано." };

        /// <summary>
        /// Возвращает и задает нужное время доставки.
        /// </summary>
        public int CurentDeliveryTime
        {
            get { return _curentDeliveryTime; }
            set { _curentDeliveryTime = value; }
        }

        /// <summary>
        /// Возвращает и задает нужную дату доставки.
        /// </summary>
        public DateTime CurentDeliveryData
        {
            get { return _curentDeliveryData; }
            set { _curentDeliveryData = value; }
        }

        /// <summary>
        /// конструктор класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="customer">Покупатель.</param>
        /// <param name="curentDeliveryData">Нужная дата доставки.</param>
        /// <param name="curentDeliveryTime">Нужное время доставки.</param>
        public PriorityOrder(Customer customer, DateTime curentDeliveryData, int curentDeliveryTime) : base(customer)
        {
            CurentDeliveryTime = curentDeliveryTime;
            CurentDeliveryData = curentDeliveryData;
        }
    }
}
