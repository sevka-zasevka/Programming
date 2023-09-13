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
        private List<Customer> Customers = new List<Customer>();
        private Customer SelectedItem = new Customer("Name", "Adress");
        private int Index;
        private int Count = 1;
        private bool AddCheck;
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

        private string StringToListBox(Customer customer)
        {
            return customer.Id + ":" + customer.Fullname;
        }

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

        private void CleanTextBox()
        {
            IdTextBox.Clear();
            FullNameTextBox.Clear();
            AdressTextBox.Clear();
        }

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
