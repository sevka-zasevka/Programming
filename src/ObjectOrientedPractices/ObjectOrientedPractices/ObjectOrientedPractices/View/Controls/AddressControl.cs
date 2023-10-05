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

        /// <summary>
        /// Возвращает и задаёт значение флага.
        /// </summary>
        public string Flag
        {
            get => _flag;
            set
            {
                _flag = value;
                EnabledTextBox();
                Clear();
            }
        }
        public AddressControl()
        {
            InitializeComponent();
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Flag == "Add")
            {
                try
                {
                    int newIndex = Convert.ToInt32(PostIndexTextBox.Text);
                    SelectedAddress.Index = newIndex;
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
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Flag == "Add")
            {
                try
                {
                    string newCountry = CountryTextBox.Text.ToString();
                    SelectedAddress.Country = newCountry;
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
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Flag == "Add")
            {
                try
                {
                    string newCity = CityTextBox.Text.ToString();
                    SelectedAddress.City = newCity;
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
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Flag == "Add")
            {
                try
                {
                    string newStreet = StreetTextBox.Text.ToString();
                    SelectedAddress.Street = newStreet;
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
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Flag == "Add")
            {
                try
                {
                    string newBuild = BuildingTextBox.Text.ToString();
                    SelectedAddress.Building = newBuild;
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
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Flag == "Add")
            {
                try
                {
                    string newApart = ApartmentTextBox.Text.ToString();
                    SelectedAddress.Apartment = newApart;
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
        private void EnabledTextBox()
        {
            bool flag = false;
            if (Flag == "Add")
            {
                flag = true;
            }
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
        private void Clear()
        {
            if (Flag == "Remove")
            {
                PostIndexTextBox.Clear();
                CountryTextBox.Clear();
                CityTextBox.Clear();
                StreetTextBox.Clear();
                BuildingTextBox.Clear();
                ApartmentTextBox.Clear();
            }
        }
    }
}
