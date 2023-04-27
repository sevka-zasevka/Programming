using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.EnumsControl
{
    public partial class SeasonHandleGrupBoxControl : UserControl
    {
        public SeasonHandleGrupBoxControl()
        {
            InitializeComponent();
        }

        private void GoSeasonButton_Click(object sender, EventArgs e)
        {
            string selectedSeason = "";
            if (SeasonComboBox.SelectedItem.ToString() == null)
            {
                SeasonComboBox.BackColor = Color.LightPink;
            }
            else
            {
                selectedSeason = SeasonComboBox.SelectedItem.ToString();
            }

            SeasonGroupBox.BackColor = Color.White;
            GoSeasonButton.BackColor = Color.LightGray;
            switch (selectedSeason)
            {
                case "Winter":
                    MessageBox.Show("Чувствуется похолодание");
                    break;
                case "Spring":
                    SeasonGroupBox.BackColor = Color.GreenYellow;
                    break;
                case "Summer":
                    MessageBox.Show("Я тоже люблю лето");
                    GoSeasonButton.BackColor = Color.Green;
                    break;
                case "Fall":
                    MessageBox.Show("We fell in love in October");
                    SeasonGroupBox.BackColor = Color.MediumVioletRed;
                    break;
            }
        }
    }
}
