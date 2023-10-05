using ObjectOrientedPractices.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractices.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ObjectOrientedPractices.View;
using ObjectOrientedPractices.View.Controls;

namespace ObjectOrientedPractices.View.Tabs
{
    internal partial class CustomersTab : UserControl
    {

        /// <summary>
        /// Список объектов класса <see cref="Customer"/>.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();
        /// <summary>
        /// Объект класса <see cref="Customer"/> c полным именем Name и адрeсом Adress.
        /// </summary>
        private Customer SelectedItem = new Customer("Name");
        /// <summary>
        /// Целочисленная переменная, для запоминания индекса.
        /// </summary>
        private int Index;
        /// <summary>
        /// Целочисленная переменная, для счета.
        /// </summary>
        private int Count = 1;
        /// <summary>
        /// Булевая переменная.
        /// </summary>
        private bool AddCheck;

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
        public CustomersTab()
        {
            InitializeComponent();
            FullNameValidationLabel.Visible = false;
            FullNameTextBox.Enabled = false;
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Index = CustomersListBox.SelectedIndex;
            if (Index != -1)
            {
                PrintToTextBox(Customers[Index]);
            }
            else
            {
                CleanTextBox();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            VisibleItems(false);
            SelectedItem = new Customer("Fullname " + Count.ToString());
            Count++;
            Customers.Add(SelectedItem);
            CustomersListBox.Items.Add(StringToListBox(SelectedItem));
            CustomersListBox.SelectedIndex = (CustomersListBox.Items.Count) - 1;
            Index = CustomersListBox.SelectedIndex;
            AddCheck = true;
            AddressControl.Flag = "Add";
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Index = CustomersListBox.SelectedIndex;
            if (Index != -1)
            {
                Customers.RemoveAt(Index);
                CustomersListBox.Items.RemoveAt(Index);
                CustomersListBox.SelectedIndex = -1;
                AddressControl.Flag = "Remove";
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (Index != -1)
            {
                VisibleItems(false);
                SelectedItem.Fullname = Customers[Index].Fullname;
                SelectedItem.Address = Customers[Index].Address;
                PrintToTextBox(SelectedItem);
                AddCheck = true;
                AddressControl.Flag = "Add";
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Customers[Index].Fullname = SelectedItem.Fullname;
            Customers[Index].Address = SelectedItem.Address;
            VisibleItems(true);
            ListBoxLineChange(Customers);
            AddCheck = false;
            AddressControl.Flag = "Ok";
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (AddCheck)
            {
                AddCheck = false;
                Customers.RemoveAt(Index);
                CustomersListBox.Items.RemoveAt(Index);
                VisibleItems(true);
                CustomersListBox.SelectedIndex = -1;
                AddressControl.Flag = "Ok";
            }
            else
            {
                PrintToTextBox(Customers[Index]);
                VisibleItems(true);
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddCheck)
            {
                try
                {
                    string newFullname = FullNameTextBox.Text.ToString();
                    SelectedItem.Fullname = newFullname;
                    FullNameTextBox.BackColor = Color.White;
                    FullNameValidationLabel.Visible = false;
                    OkButton.Visible = true;
                    int currentSelection = FullNameTextBox.SelectionStart;
                    FullNameTextBox.Focus();
                    FullNameTextBox.SelectionStart = currentSelection;
                }

                catch
                {
                    FullNameTextBox.BackColor = Color.LightPink;
                    FullNameValidationLabel.Visible = true;
                    OkButton.Visible = false;
                }
            }
        }

        /// <summary>
        /// Метод для появления кнопок "ok" и "cancel"
        /// И исчезновения "Add", "Remove" и "Change".
        /// Также блокиет доступ к "CustomerListBox",
        /// "FullNameTextBox", "AdressTextBox". 
        /// И наоборот.
        /// </summary>
        /// <param name="visible">Булевая переменная для определения нужного состояния окна.</param>
        private void VisibleItems(bool visible)
        {
            AddButton.Visible = visible;
            RemoveButton.Visible = visible;
            ChangeButton.Visible = visible;
            OkButton.Visible = !visible;
            CancelButton.Visible = !visible;
            CustomersListBox.Enabled = visible;
            FullNameTextBox.Enabled = !visible;
        }

        /// <summary>
        /// Метод для создания строки для вывод в Listbox.
        /// </summary>
        /// <param name="customer">Объект класса <see cref="Customer"/>.</param>
        /// <returns></returns>
        private string StringToListBox(Customer customer)
        {
            return customer.Id + ":" + customer.Fullname;
        }

        /// <summary>
        /// Метод для вывода значения полей выбранного покупателя
        /// в текстовые поля. Также передаёт значение поля address в AddressControl.
        /// </summary>
        /// <param name="customer">Объект класса <see cref="Customer"/>.</param>
        private void PrintToTextBox(Customer customer)
        {
            if (AddCheck)
            {
                IdTextBox.Text = customer.Id.ToString();
                FullNameTextBox.Text = customer.Fullname.ToString();
                AddressControl.SelectedAddress = Customers[Index].Address;
            }
            else
            {
                IdTextBox.Text = Customers[Index].Id.ToString();
                FullNameTextBox.Text = customer.Fullname.ToString();
                AddressControl.SelectedAddress = Customers[Index].Address;
            }
        }

        /// <summary>
        /// Метод для очистки всех текстовых полей.
        /// </summary>
        private void CleanTextBox()
        {
            IdTextBox.Clear();
            FullNameTextBox.Clear();
        }

        /// <summary>
        /// Метод для изменения строки в CustomersListBox.
        /// </summary>
        /// <param name="customers">Список объектов класса <see cref="Customer"/>.</param>
        private void ListBoxLineChange(List<Customer> customers)
        {
            CustomersListBox.Items.Clear();
            for (int i = 0; i < customers.Count; i++)
            {
                CustomersListBox.Items.Add(StringToListBox(customers[i]));
            }
        }
    }
}
