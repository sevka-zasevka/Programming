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
                SeasonComboBox.BackColor = AppColors.Lightpink;
            }
            else
            {
                selectedSeason = SeasonComboBox.SelectedItem.ToString();
            }

            SeasonGroupBox.BackColor = AppColors.White;
            GoSeasonButton.BackColor = AppColors.Gray;
            switch (selectedSeason)
            {
                case "Winter":
                    MessageBox.Show("Чувствуется похолодание");
                    break;
                case "Spring":
                    SeasonGroupBox.BackColor = AppColors.Green;
                    break;
                case "Summer":
                    MessageBox.Show("Я тоже люблю лето");
                    GoSeasonButton.BackColor = AppColors.Green;
                    break;
                case "Fall":
                    MessageBox.Show("We fell in love in October");
                    SeasonGroupBox.BackColor = AppColors.Pink;
                    break;
            }
        }
    }
}
