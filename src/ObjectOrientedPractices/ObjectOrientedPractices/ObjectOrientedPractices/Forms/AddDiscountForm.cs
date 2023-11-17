using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractices.Model;
using ObjectOrientedPractices.Model.Discounts;
using ObjectOrientedPractices.Model.Enums;

namespace ObjectOrientedPractices.Forms
{
    internal partial class AddDiscountForm : Form
    {
        private Category _selectCategory;
        private Customer _currentCustomer;

        public Category SelectCategory
        {
            get { return _selectCategory; }
            set { _selectCategory = value; }
        }

        public Customer CurrentCustomer
        {
            get { return _currentCustomer; }
            set { _currentCustomer = value; }
        }
        public AddDiscountForm()
        {
            InitializeComponent();
            foreach (string category in Enum.GetNames(typeof(Category)))
            {
                CategoryComboBox.Items.Add(category.ToString());
            }
            CategoryComboBox.SelectedIndex = 0;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            PercentDiscount discount = new PercentDiscount();
            discount.Category = (Category)CategoryComboBox.SelectedIndex;
            bool flag = false;
            foreach(IDiscount prdis in _currentCustomer.Discounts )
            {
                if (prdis is PercentDiscount pers)
                {
                    if (discount.Category == pers.Category)
                    {
                        flag = true;
                    }
                }
            }
            if (!flag)
            {
                _currentCustomer.Discounts.Add(discount);
                DialogResult = DialogResult.OK;
                this.Close();
                flag = false;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
                flag = false;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            SelectCategory = (Category)0;
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
