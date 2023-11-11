using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model
{
    internal class PriorityOrder : Order
    {
        /// <summary>
        /// Нужное время доставки.
        /// </summary>
        private string _curentDeliveryTime;
        /// <summary>
        /// Нужная дата доставки.
        /// </summary>
        private DateTime _curentDeliveryData;
        /// <summary>
        /// Возможные временные промежутки для доставки. 
        /// </summary>
        private string[] _deliveryTimeChoise = new string[6] { "9:00 – 11:00", "11:00 – 13:00", "13:00 – 15:00", "15:00 – 17:00", "17:00 – 19:00", "19:00 – 21:00" };

        /// <summary>
        /// Возвращает и задает нужное время доставки.
        /// </summary>
        public string CurentDeliveryTime
        {
            get { return _curentDeliveryTime;}
            set { _curentDeliveryTime = value;}
        }

        /// <summary>
        /// Возвращает и задает нужную дату доставки.
        /// </summary>
        public DateTime CurentDeliveryData
        {
            get { return _curentDeliveryData; }
            set { _curentDeliveryData = value;}
        }

        /// <summary>
        /// конструктор класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="customer">Покупатель.</param>
        /// <param name="curentDeliveryData">Нужная дата доставки.</param>
        /// <param name="curentDeliveryTime">Нужное время доставки.</param>
        public PriorityOrder(Customer customer, DateTime curentDeliveryData, DeliveryTime curentDeliveryTime) : base(customer) 
        {
            CurentDeliveryTime = _deliveryTimeChoise[(int)curentDeliveryTime];
            CurentDeliveryData = curentDeliveryData;
        }
    }
}
