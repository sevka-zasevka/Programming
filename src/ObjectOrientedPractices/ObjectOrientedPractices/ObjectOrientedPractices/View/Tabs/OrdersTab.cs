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

namespace ObjectOrientedPractices.View.Tabs
{
    internal partial class OrdersTab : UserControl
    {
        private List<Customer> _customersOrder;
        private List<Order> _orders;
        public Customer CurentCustomer;

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
        }

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
    }
}
