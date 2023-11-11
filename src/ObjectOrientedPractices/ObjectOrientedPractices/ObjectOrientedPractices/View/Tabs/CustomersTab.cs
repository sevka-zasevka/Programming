using ObjectOrientedPractices.Model;
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
        public Customer SelectedCustomer = new Customer("Name");
        /// <summary>
        /// Объект класса <see cref="Address"/>.
        /// </summary>
        private Address SelectedAddress = new Address();
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
        private bool NoPrint;

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
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Index = CustomersListBox.SelectedIndex;
            if (Index != -1)
            {
                PrintToTextBox(Customers[Index]);
                SelectedCustomer.Fullname = Customers[Index].Fullname;
                CloneAddress();
            }
            else
            {
                CleanTextBox();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddCheck = true;
            NoPrint = true;
            Customer customer = new Customer("Fullname " + Count.ToString());
            Count++;
            Customers.Add(customer);
            CustomersListBox.Items.Add(StringToListBox(customer));
            CustomersListBox.SelectedIndex = (CustomersListBox.Items.Count) - 1;
            Index = CustomersListBox.SelectedIndex;
            AddressControl.Flag = "Add";
            VisibleItems(false);
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
                NoPrint = true;
                SelectedCustomer.Fullname = Customers[Index].Fullname;
                SelectedCustomer.Address = Customers[Index].Address;
                PrintToTextBox(SelectedCustomer);
                AddressControl.Flag = "Change";
                VisibleItems(false);
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Customers[Index].Fullname = SelectedCustomer.Fullname;
            Customers[Index].Address.Street = SelectedAddress.Street;
            Customers[Index].Address.Building = SelectedAddress.Building;
            Customers[Index].Address.City = SelectedAddress.City;
            Customers[Index].Address.Country = SelectedAddress.Country;
            Customers[Index].Address.Index = SelectedAddress.Index;
            Customers[Index].Address.Apartment = SelectedAddress.Apartment;
            VisibleItems(true);
            ListBoxLineChange(Customers);
            AddCheck = false;
            NoPrint = false;
            AddressControl.Flag = "Ok";
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (AddCheck)
            {
                AddCheck = false;
                NoPrint = false;
                Customers.RemoveAt(Index);
                CustomersListBox.Items.RemoveAt(Index);
                VisibleItems(true);
                CustomersListBox.SelectedIndex = -1;
                AddressControl.Flag = "Remove";
            }
            else
            {
                NoPrint = false;
                VisibleItems(true);
                CustomersListBox.SelectedIndex = Index;
                AddressControl.Flag = "Cancel";
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NoPrint)
            {
                try
                {
                    string newFullname = FullNameTextBox.Text.ToString();
                    SelectedCustomer.Fullname = newFullname;
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
                CloneAddress();
                AddressControl.SelectedAddress = SelectedAddress;
            }
            else
            {
                IdTextBox.Text = Customers[Index].Id.ToString();
                FullNameTextBox.Text = customer.Fullname.ToString();
                CloneAddress();
                AddressControl.SelectedAddress = SelectedAddress;
            }
        }

        /// <summary>
        /// Метод для очистки всех текстовых полей.
        /// </summary>
        private void CleanTextBox()
        {
            IdTextBox.Clear();
            FullNameTextBox.Clear();
            FullNameTextBox.BackColor = Color.WhiteSmoke;
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

        /// <summary>
        /// Метод для создания клона объекта адресса класса <see cref="Address"/>
        /// </summary>
        private void CloneAddress()
        {
            SelectedAddress.Street = Customers[Index].Address.Street;
            SelectedAddress.Building = Customers[Index].Address.Building;
            SelectedAddress.City = Customers[Index].Address.City;
            SelectedAddress.Country = Customers[Index].Address.Country;
            SelectedAddress.Index = Customers[Index].Address.Index;
            SelectedAddress.Apartment = Customers[Index].Address.Apartment;
        }
    }
}
