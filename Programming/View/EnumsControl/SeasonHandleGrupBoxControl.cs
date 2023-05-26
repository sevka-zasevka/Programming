using Programming.Model.Class;

namespace Programming.View.EnumsControl
{
    /// <summary>
    /// Предоставляет методы для выбора из выпадающего списка один из элементов
    /// и, при нажатии на кнопку, измения внешнего вида окна.
    /// </summary>
    public partial class SeasonHandleGrupBoxControl : UserControl
    {
        public SeasonHandleGrupBoxControl()
        {
            InitializeComponent();
        }

        private void GoSeasonButton_Click(object sender, EventArgs e)
        {
            string selectedSeason = "";
            if (SeasonComboBox.SelectedItem == null)
            {
                SeasonComboBox.BackColor = AppColors.Lightpink;
            }
            else
            {
                SeasonComboBox.BackColor = AppColors.White;
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
