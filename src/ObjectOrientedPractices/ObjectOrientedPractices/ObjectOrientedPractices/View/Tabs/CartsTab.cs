using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractices.Model;

namespace ObjectOrientedPractices.View.Tabs
{
    internal partial class CartsTab : UserControl
    {
        private List<Item> _items;
        private List<Customer> _customers;
        private Customer CurentCustomer = new Customer(" ");

        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }


        public CartsTab()
        {
            InitializeComponent();
        }


        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1)
            {
                CartListBox.Items.Clear();
                CurentCustomer = Customers[CustomersComboBox.SelectedIndex];
                List<Item> currentCustomersItem = CurentCustomer.Cart.CurentItem;
                for (int i = 0; i < currentCustomersItem.Count; i++)
                {
                    CartListBox.Items.Add(ItemName(currentCustomersItem[i]));
                }
                AmountLabel.Text = CurentCustomer.Cart.Amount.ToString();
            }
            else
            {
                CartListBox.Items.Clear();
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1)
            {
                CurentCustomer.Cart.CurentItem.Add(Items[ItemsListBox.SelectedIndex]);
                CartListBox.Items.Add(ItemName(Items[ItemsListBox.SelectedIndex]));
                AmountLabel.Text = CurentCustomer.Cart.Amount.ToString();
            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1)
            {
                if (CartListBox.Items != null)
                {
                    Order newOrder = new Order(CurentCustomer);
                    for (int i=0;i<CurentCustomer.Cart.CurentItem.Count;i++ )
                    {
                        newOrder.Items.Add(CurentCustomer.Cart.CurentItem[i]);
                    }
                    CurentCustomer.Orders.Add(newOrder);
                    CurentCustomer.Cart.CurentItem = new List<Item>();
                    CartListBox.Items.Clear();
                    AmountLabel.Text = "0,0";
                }
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex != -1)
            {
                CurentCustomer.Cart.CurentItem.RemoveAt(CartListBox.SelectedIndex);
                CartListBox.Items.RemoveAt(CartListBox.SelectedIndex);
                AmountLabel.Text = CurentCustomer.Cart.Amount.ToString();
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            CartListBox.Items.Clear();
            CurentCustomer.Cart.CurentItem.Clear();
            AmountLabel.Text = "0,0";
        }

        public void UpdateDataItems(List<Item> items)
        {
            if (items != null)
            {
                ItemsListBox.Items.Clear();
                for (int i = 0; i < Items.Count; i++)
                {
                    ItemsListBox.Items.Add(ItemName(Items[i]));
                }
                if (ItemsListBox.Items.Count > 0)
                {
                    ItemsListBox.SelectedIndex = 0;
                }
            }
        }

        public void UpdateDataCustomers(List<Customer> customers)
        {
            if (customers != null)
            {
                CustomersComboBox.Items.Clear();
                for (int i = 0; i < Customers.Count; i++)
                {
                    CustomersComboBox.Items.Add(CustomerName(Customers[i]));
                }
                if (CustomersComboBox.Items.Count > 0)
                {
                    CustomersComboBox.SelectedIndex = 0;
                }
            }
        }

        private string ItemName(Item item)
        {
            return item.Name.ToString() + ": " + item.Cost.ToString();
        }

        private string CustomerName(Customer customer)
        {
            return customer.Id.ToString() + ": " + customer.Fullname.ToString();
        }
    }
}
