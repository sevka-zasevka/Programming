using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractices.View.Controls;
using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.Model.Orders;
using ObjectOrientedPractices.Model.Enums;

namespace ObjectOrientedPractices.View.Tabs
{
    internal partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Список всех покупателей класса <see cref="Customer"/>.
        /// </summary>
        private List<Customer> _customersOrder;
        /// <summary>
        /// Список всех заказов класса <see cref="Order"/>.
        /// </summary>
        private List<Order> _orders;
        /// <summary>
        /// Объект покупателя класса <see cref="Customer"/>.
        /// </summary>
        public Customer CurentCustomer;

        /// <summary>
        /// Возвращает и задаёт список покупателей класса <see cref="Customer"/>.
        /// </summary>
        public List<Customer> CustomersOrder
        {
            get
            {
                return _customersOrder;
            }
            set
            {
                _customersOrder = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт список заказов класса <see cref="Order"/>.
        /// </summary>
        private List<Order> Orders
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
        public OrdersTab()
        {
            InitializeComponent();
            Orders = new List<Order>();
            foreach (string status in Enum.GetNames(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(status);
            }
            foreach (string time in PriorityOrder.DeliveryTimeChoise)
            {
                DeliveryTimeComboBox.Items.Add(time);
            }
        }

        public void UpdateOrdersTabData(List<Customer> customers)
        {
            if (CustomersOrder != null)
            {
                Orders.Clear();
                foreach (Customer customer in CustomersOrder)
                {
                    foreach (Order order in customer.Orders)
                    {
                        Orders.Add(order);
                    }
                }
                OrderDataGridView.Rows.Clear();
                for (int i = 0; i < Orders.Count; i++)
                {
                    OrderDataGridView.Rows.Add(Orders[i].Id.ToString(), Orders[i].DateCreation.ToString(), Orders[i].Status.ToString(), Orders[i].FullnameCustomer.ToString(), AddressOrderToString(Orders[i]), Orders[i].Amount.ToString());
                }
            }
        }

        /// <summary>
        /// Переводит адрес в одну строку.
        /// </summary>
        /// <param name="order">Адрес заказа класса <see cref="Order"/></param>
        /// <returns></returns>
        private string AddressOrderToString(Order order)
        {
            return $"{order.OrderAddress.Index}, " +
                $"{order.OrderAddress.Country}, " +
                $"{order.OrderAddress.City}, " +
                $"{order.OrderAddress.Street}, " +
                $"{order.OrderAddress.Building}, " +
                $"{order.OrderAddress.Apartment}.";


        }

        private void OrderDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrderDataGridView.CurrentRow.Cells[1].Value == null)
            {
                return;
            }
            IDTextBox.Text = Orders[Convert.ToInt32(OrderDataGridView.CurrentRow.Index)].Id.ToString();
            CreatedTextBox.Text = Orders[Convert.ToInt32(OrderDataGridView.CurrentRow.Index)].DateCreation.ToString();
            StatusComboBox.Text = Orders[Convert.ToInt32(OrderDataGridView.CurrentRow.Index)].Status.ToString();
            OrderAddressControl.SelectedAddress = Orders[Convert.ToInt32(OrderDataGridView.CurrentRow.Index)].OrderAddress;
            OrderItemsListBox.Items.Clear();
            for (int i = 0; i < Orders[Convert.ToInt32(OrderDataGridView.CurrentRow.Index)].Items.Count; i++)
            {
                LineToOrderTextBox(Orders[Convert.ToInt32(OrderDataGridView.CurrentRow.Index)].Items[i]);
            }
            AmountLabel.Text = Orders[Convert.ToInt32(OrderDataGridView.CurrentRow.Index)].Amount.ToString();
            if (Orders[Convert.ToInt32(OrderDataGridView.CurrentRow.Index)] is PriorityOrder priority)
            {
                PriorityOptionsPanel.Visible = true;
                DeliveryTimeComboBox.SelectedIndex = priority.CurentDeliveryTime;
            }
            else
            {
                PriorityOptionsPanel.Visible = false;
            }
        }
        /// <summary>
        /// Метод создающий строку для вывода в OrderTextBox из объекта класса <see cref="Item"/>.
        /// </summary>
        /// <param name="item">Объект класса <see cref="Item"/>.</param>
        private void LineToOrderTextBox(Item item)
        {
            OrderItemsListBox.Items.Add(item.Id.ToString() + " : " + item.Name);
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(OrderDataGridView.CurrentRow.Index);
            if (OrderDataGridView.CurrentRow.Cells[1].Value == null)
            {
                return;
            }
            int selectCategory = StatusComboBox.SelectedIndex;
            if (selectCategory != -1)
            {
                Orders[index].Status = (OrderStatus)selectCategory;
            }
            OrderDataGridView.CurrentRow.Cells[2].Value = Orders[index].Status.ToString();
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(OrderDataGridView.CurrentRow.Index);
            if (OrderDataGridView.CurrentRow.Cells[1].Value == null)
            {
                return;
            }
            int selectDeliveryTime = DeliveryTimeComboBox.SelectedIndex;
            if (Orders[index] is PriorityOrder priority)
            {
                priority.CurentDeliveryTime =selectDeliveryTime;
            }
        }
    }
}
