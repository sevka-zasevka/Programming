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

namespace ObjectOrientedPractices.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список объектов класса <see cref="Customer"/>.
        /// </summary>
        private List<Customer> Customers = new List<Customer>();
        /// <summary>
        /// Объект класса <see cref="Customer"/> c полным именем Name и адрeсом Adress.
        /// </summary>
        private Customer SelectedItem = new Customer("Name", "Adress");
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
        public CustomersTab()
        {
            InitializeComponent();
            FullNameValidationLabel.Visible = false;
            AdressValidationLabel.Visible = false;
            FullNameTextBox.Enabled = false;
            AdressTextBox.Enabled = false;
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
            Customer customer = new Customer("Fullname " + Count.ToString(), "Adress");
            Count++;
            Customers.Add(customer);
            CustomersListBox.Items.Add(StringToListBox(customer));
            CustomersListBox.SelectedIndex = (CustomersListBox.Items.Count) - 1;
            Index = CustomersListBox.SelectedIndex;
            SelectedItem.Fullname = Customers[Index].Fullname;
            SelectedItem.Adress = Customers[Index].Adress;
            AddCheck = true;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Index = CustomersListBox.SelectedIndex;
            if (Index != -1)
            {
                Customers.RemoveAt(Index);
                CustomersListBox.Items.RemoveAt(Index);
                CustomersListBox.SelectedIndex = -1;
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (Index != -1)
            {
                VisibleItems(false);
                SelectedItem.Fullname = Customers[Index].Fullname;
                SelectedItem.Adress = Customers[Index].Adress;
                PrintToTextBox(SelectedItem);
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Customers[Index].Fullname = SelectedItem.Fullname;
            Customers[Index].Adress = SelectedItem.Adress;
            VisibleItems(true);
            ListBoxLineChange(Customers);
            AddCheck = false;
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (AddCheck)
            {
                CustomersListBox.SelectedIndex = -1;
                Customers.RemoveAt(Index);
                CustomersListBox.Items.RemoveAt(Index);
                VisibleItems(true);
                AddCheck = false;
            }
            else
            {
                PrintToTextBox(Customers[Index]);
                VisibleItems(true);
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Index != -1)
            {
                try
                {
                    string newFullname = FullNameTextBox.Text.ToString();
                    SelectedItem.Fullname = newFullname;
                    FullNameTextBox.BackColor = Color.White;
                    FullNameValidationLabel.Visible = false;
                    int currentSelection = FullNameTextBox.SelectionStart;
                    FullNameTextBox.Focus();
                    FullNameTextBox.SelectionStart = currentSelection;
                }

                catch
                {
                    FullNameTextBox.BackColor = Color.LightPink;
                    FullNameValidationLabel.Visible = true;
                }
            }
        }

        private void AdressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Index != -1)
            {
                try
                {
                    string newAdress = AdressTextBox.Text.ToString();
                    SelectedItem.Fullname = newAdress;
                    AdressTextBox.BackColor = Color.White;
                    AdressValidationLabel.Visible = false;
                    int currentSelection = AdressTextBox.SelectionStart;
                    AdressTextBox.Focus();
                    AdressTextBox.SelectionStart = currentSelection;
                }

                catch
                {
                    AdressTextBox.BackColor = Color.LightPink;
                    AdressValidationLabel.Visible = true;
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
            AdressTextBox.Enabled = !visible;
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
        /// в текстовые поля.
        /// </summary>
        /// <param name="customer">Объект класса <see cref="Customer"/>.</param>
        private void PrintToTextBox(Customer customer)
        {
            if (AddCheck)
            {
                IdTextBox.Text = customer.Id.ToString();
                FullNameTextBox.Text = customer.Fullname.ToString();
                AdressTextBox.Text = customer.Adress.ToString();
            }
            else
            {
                IdTextBox.Text = Customers[Index].Id.ToString();
                FullNameTextBox.Text = customer.Fullname.ToString();
                AdressTextBox.Text = customer.Adress.ToString();
            }
        }

        /// <summary>
        /// Метод для очистки всех текстовых полей.
        /// </summary>
        private void CleanTextBox()
        {
            IdTextBox.Clear();
            FullNameTextBox.Clear();
            AdressTextBox.Clear();
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
