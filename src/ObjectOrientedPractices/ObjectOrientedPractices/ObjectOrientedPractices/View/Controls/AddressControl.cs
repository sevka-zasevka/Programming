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
using ObjectOrientedPractices.View.Tabs;

namespace ObjectOrientedPractices.View.Controls
{
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Выбранный адрес класса <see cref="Address"/>.
        /// </summary>
        private Address _selectedAddress;
        /// <summary>
        /// Флаг.
        /// </summary>
        private string _flag = "null";

        /// <summary>
        /// Возвращает и задаёт адрес.
        /// </summary>
        public Address SelectedAddress
        {
            get
            {
                return _selectedAddress;
            }
            set
            {
                _selectedAddress = value;
                Print();
            }
        }

        public Address ChangedAddress
        {
            get
            {
                return _selectedAddress;
            }
            set
            {
                _selectedAddress = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт значение флага.
        /// </summary>
        public string Flag
        {
            get => _flag;
            set
            {
                _flag = value;
                if(_flag == "Add")
                {
                    EnabledTextBox(true);
                }
                if(_flag == "Ok")
                {
                    EnabledTextBox(false);
                }
                if (_flag =="Remove")
                {
                    EnabledTextBox(false);
                    TextBoxClear();
                }
                if(_flag == "Change")
                {
                    EnabledTextBox(true);
                }
                if(_flag == "Cancel")
                {
                    EnabledTextBox(false);
                }
            }
        }
        public AddressControl()
        {
            InitializeComponent();
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                int newIndex = Convert.ToInt32(PostIndexTextBox.Text);
                ChangedAddress.Index = newIndex;
                PostIndexTextBox.BackColor = Color.White;
                ValidationPostIndexLabel.Visible = false;
                int currentSelection = PostIndexTextBox.SelectionStart;
                PostIndexTextBox.Focus();
                PostIndexTextBox.SelectionStart = currentSelection;
            }

            catch
            {
                PostIndexTextBox.BackColor = Color.LightPink;
                ValidationPostIndexLabel.Visible = true;
            }

        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string newCountry = CountryTextBox.Text.ToString();
                ChangedAddress.Country = newCountry;
                CountryTextBox.BackColor = Color.White;
                ValidationCountryLabel.Visible = false;
                int currentSelection = CountryTextBox.SelectionStart;
                CountryTextBox.Focus();
                CountryTextBox.SelectionStart = currentSelection;
            }

            catch
            {
                CountryTextBox.BackColor = Color.LightPink;
                ValidationCountryLabel.Visible = true;
            }

        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string newCity = CityTextBox.Text.ToString();
                ChangedAddress.City = newCity;
                CityTextBox.BackColor = Color.White;
                ValidationCityLabel.Visible = false;
                int currentSelection = CityTextBox.SelectionStart;
                CityTextBox.Focus();
                CityTextBox.SelectionStart = currentSelection;
            }

            catch
            {
                CityTextBox.BackColor = Color.LightPink;
                ValidationCityLabel.Visible = true;
            }

        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string newStreet = StreetTextBox.Text.ToString();
                ChangedAddress.Street = newStreet;
                StreetTextBox.BackColor = Color.White;
                ValidationStreetLabel.Visible = false;
                int currentSelection = StreetTextBox.SelectionStart;
                StreetTextBox.Focus();
                StreetTextBox.SelectionStart = currentSelection;
            }

            catch
            {
                StreetTextBox.BackColor = Color.LightPink;
                ValidationStreetLabel.Visible = true;
            }

        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string newBuild = BuildingTextBox.Text.ToString();
                ChangedAddress.Building = newBuild;
                BuildingTextBox.BackColor = Color.White;
                ValidationBuildingLabel.Visible = false;
                int currentSelection = BuildingTextBox.SelectionStart;
                BuildingTextBox.Focus();
                BuildingTextBox.SelectionStart = currentSelection;
            }

            catch
            {
                BuildingTextBox.BackColor = Color.LightPink;
                ValidationBuildingLabel.Visible = true;
            }

        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string newApart = ApartmentTextBox.Text.ToString();
                ChangedAddress.Apartment = newApart;
                ApartmentTextBox.BackColor = Color.White;
                ValidationApartmentLabel.Visible = false;
                int currentSelection = ApartmentTextBox.SelectionStart;
                ApartmentTextBox.Focus();
                ApartmentTextBox.SelectionStart = currentSelection;
            }

            catch
            {
                ApartmentTextBox.BackColor = Color.LightPink;
                ValidationApartmentLabel.Visible = true;
            }


        }

        /// <summary>
        /// Метод, который записывает значение SelectedAddress в тектовые поля.
        /// </summary>
        private void Print()
        {
            if (SelectedAddress == null)
            {
                return;
            }
            if (SelectedAddress.Index != 0)
            {
                PostIndexTextBox.Text = SelectedAddress.Index.ToString();
            }
            CountryTextBox.Text = SelectedAddress.Country;
            CityTextBox.Text = SelectedAddress.City;
            StreetTextBox.Text = SelectedAddress.Street;
            BuildingTextBox.Text = SelectedAddress.Building;
            ApartmentTextBox.Text = SelectedAddress.Apartment;

        }

        /// <summary>
        /// Метод регулирует возможность редактирование тектовых полей.
        /// </summary>
        private void EnabledTextBox(bool flag)
        {
            PostIndexTextBox.Enabled = flag;
            CountryTextBox.Enabled = flag;
            CityTextBox.Enabled = flag;
            StreetTextBox.Enabled = flag;
            BuildingTextBox.Enabled = flag;
            ApartmentTextBox.Enabled = flag;
        }

        /// <summary>
        /// Метод очищает тектовые поля.
        /// </summary>
        private void TextBoxClear()
        {
            PostIndexTextBox.Clear();
            PostIndexTextBox.BackColor = Color.WhiteSmoke;
            ValidationPostIndexLabel.Visible = false;
            CountryTextBox.Clear();
            CountryTextBox.BackColor = Color.WhiteSmoke;
            ValidationCountryLabel.Visible = false;
            CityTextBox.Clear();
            CityTextBox.BackColor = Color.WhiteSmoke;
            ValidationCityLabel.Visible = false;
            StreetTextBox.Clear();
            StreetTextBox.BackColor = Color.WhiteSmoke;
            ValidationStreetLabel.Visible = false;
            BuildingTextBox.Clear();
            BuildingTextBox.BackColor = Color.WhiteSmoke;
            ValidationBuildingLabel.Visible = false;
            ApartmentTextBox.Clear();
            ApartmentTextBox.BackColor = Color.WhiteSmoke;
            ValidationApartmentLabel.Visible = false;
        }

    }
}
