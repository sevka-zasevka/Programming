﻿
using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.Model.Orders;

namespace ObjectOrientedPractices.View.Tabs
{
    internal partial class CartsTab : UserControl
    {
        /// <summary>
        /// Список товаров класса <see cref="Item"/>.
        /// </summary>
        private List<Item> _items;
        /// <summary>
        /// Список покупателей класса <see cref="Customer"/>.
        /// </summary>
        private List<Customer> _customers;
        /// <summary>
        /// Объект класса <see cref="Customer"/>.
        /// </summary>
        private Customer CurentCustomer = new Customer(" ");

        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
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
                DiscountCheckedListBox.Items.Clear();
                CurentCustomer = Customers[CustomersComboBox.SelectedIndex];
                List<Item> currentCustomersItem = CurentCustomer.Cart.CurentItem;
                for (int i = 0; i < currentCustomersItem.Count; i++)
                {
                    CartListBox.Items.Add(ItemName(currentCustomersItem[i]));
                }
                AmountLabel.Text = CurentCustomer.Cart.Amount.ToString();
                for (int i = 0; i < CurentCustomer.Discounts.Count; i++)
                {
                    DiscountCheckedListBox.Items.Add(CurentCustomer.Discounts[i].Info); 
                    DiscountCheckedListBox.SetItemChecked(i, true);
                }
            }
            else
            {
                CartListBox.Items.Clear();
                DiscountCheckedListBox.Items.Clear();
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1)
            {
                CurentCustomer.Cart.CurentItem.Add(Items[ItemsListBox.SelectedIndex]);
                CartListBox.Items.Add(ItemName(Items[ItemsListBox.SelectedIndex]));
                AmountLabel.Text = CurentCustomer.Cart.Amount.ToString();
                UpdateAmount();
            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1)
            {
                if (CartListBox.Items.Count != 0)
                {
                    if (CurentCustomer.IsPriority)
                    {
                        Order newOrder = new PriorityOrder(CurentCustomer, DateTime.Today, 6);
                        for (int i = 0; i < CurentCustomer.Cart.CurentItem.Count; i++)
                        {
                            newOrder.Items.Add(CurentCustomer.Cart.CurentItem[i]);
                        }
                        newOrder.DiscountAmount = UpdateAmountWithCreate();
                        CurentCustomer.Orders.Add(newOrder);
                        CurentCustomer.Cart.CurentItem = new List<Item>();
                        CartListBox.Items.Clear();
                        DiscountCheckedListBox.Items.Clear();
                        for (int i = 0; i < CurentCustomer.Discounts.Count; i++)
                        {
                            DiscountCheckedListBox.Items.Add(CurentCustomer.Discounts[i].Info);
                            DiscountCheckedListBox.SetItemChecked(i, true);
                        }
                        AmountLabel.Text = "0,0";
                        DiscountAmountLabel.Text = "0,0";
                        TotalLabel.Text = "0,0";
                    }
                    else
                    {
                        Order newOrder = new Order(CurentCustomer);
                        for (int i = 0; i < CurentCustomer.Cart.CurentItem.Count; i++)
                        {
                            newOrder.Items.Add(CurentCustomer.Cart.CurentItem[i]);
                        }
                        newOrder.DiscountAmount = UpdateAmountWithCreate();
                        CurentCustomer.Orders.Add(newOrder);
                        CurentCustomer.Cart.CurentItem = new List<Item>();
                        CartListBox.Items.Clear();
                        DiscountCheckedListBox.Items.Clear();
                        for (int i = 0; i < CurentCustomer.Discounts.Count; i++)
                        {
                            DiscountCheckedListBox.Items.Add(CurentCustomer.Discounts[i].Info);
                            DiscountCheckedListBox.SetItemChecked(i, true);
                        }
                        AmountLabel.Text = "0,0";
                        DiscountAmountLabel.Text = "0,0";
                        TotalLabel.Text = "0,0";
                    }

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
                UpdateAmount();
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            CartListBox.Items.Clear();
            for (int i = 0; i < CurentCustomer.Discounts.Count; i++)
            {
                DiscountCheckedListBox.SetItemChecked(i, true);
            }
            CurentCustomer.Cart.CurentItem.Clear();
            AmountLabel.Text = "0,0";
            DiscountAmountLabel.Text = "0,0";
            TotalLabel.Text = "0,0";
        }

        private void DiscountCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAmount();
        }

        /// <summary>
        /// Метод обновляющий список товаров.
        /// </summary>
        /// <param name="items">Список покупателей класса <see cref="Item"/>.</param>
        public void UpdateDataItems(List<Item> items)
        {
            if (items != null)
            {
                ItemsListBox.Items.Clear();
                DiscountCheckedListBox.Items.Clear();
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

        /// <summary>
        /// Метод обновляющий список покупателей.
        /// </summary>
        /// <param name="customers">Список покупателей класса <see cref="Customer"/>.</param>
        public void UpdateDataCustomers(List<Customer> customers)
        {
            if (customers != null)
            {
                CustomersComboBox.Items.Clear();
                DiscountCheckedListBox.Items.Clear();
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

        /// <summary>
        /// Метод, возвращающий строку для вывода в ItemsListBox.
        /// </summary>
        /// <param name="item">Товар.</param>
        /// <returns></returns>
        private string ItemName(Item item)
        {
            return item.Name.ToString() + ": " + item.Cost.ToString();
        }

        /// <summary>
        /// Метод, возвращающий строку для вывода в CustomersComboBox.
        /// </summary>
        /// <param name="item">Покупатель.</param>
        /// <returns></returns>
        private string CustomerName(Customer customer)
        {
            return customer.Id.ToString() + ": " + customer.Fullname.ToString();
        }

        /// <summary>
        /// Метод для обновления DiscountAmountLabel и TotalLabel при изменении цены.
        /// </summary>
        private void UpdateAmount()
        {
            double discount = 0;
            double amount = CurentCustomer.Cart.Amount;
            for (int i = 0; i < CurentCustomer.Discounts.Count; i++)
            {
                if (DiscountCheckedListBox.GetItemChecked(i))
                {
                    discount += CurentCustomer.Discounts[i].Calculate(CurentCustomer.Cart.CurentItem);
                }
            }
            DiscountAmountLabel.Text = discount.ToString();
            amount -= discount;
            TotalLabel.Text = amount.ToString();
        }

        /// <summary>
        /// Метод для обновления значения скидок.
        /// </summary>
        /// <returns>Размер предоставляемой скидки.</returns>
        private double UpdateAmountWithCreate()
        {
            double discount = 0;
            for (int i = 0; i < CurentCustomer.Discounts.Count; i++)
            {
                if (DiscountCheckedListBox.GetItemChecked(i))
                {
                    discount += CurentCustomer.Discounts[i].Apply(CurentCustomer.Cart.CurentItem);
                }
                CurentCustomer.Discounts[i].Update(CurentCustomer.Cart.CurentItem);
            }
            return discount;
        }
    }
}
