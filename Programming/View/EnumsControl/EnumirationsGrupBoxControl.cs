using Programming.Model.Class;

namespace Programming.View.EnumsControl
{
    /// <summary>
    /// Предоставляет методы для обозревания списка перечислений и доступа к информации в перечислениях.
    /// </summary>
    public partial class EnumirationsGrupBoxControl : UserControl
    {
        /// <summary>
        /// Переменная для хранения выбранной категории.
        /// </summary>
        public Type _currentCategory;

        public EnumirationsGrupBoxControl()
        {
            InitializeComponent();


            EnumsListBox.SetSelected(0, true);
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var category = new Dictionary<string, Type>
            {
                ["Colors"] = typeof(Colors),
                ["EducationForm"] = typeof(EducationForm),
                ["Genre"] = typeof(Genre),
                ["Manufactures"] = typeof(Manufactures),
                ["Season"] = typeof(Season),
                ["Weekday"] = typeof(Weekday),
            };

            string selectedCategory = EnumsListBox.SelectedItem.ToString();
            ValueListBox.Items.Clear();
            _currentCategory = category[selectedCategory];
            foreach (int i in Enum.GetValues(_currentCategory))
            {
                ValueListBox.Items.Add(Enum.GetName(_currentCategory, i));
            }

            ValueTextBox.Text = "1";
        }

        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = ValueListBox.SelectedIndex;
            int j = 0;

            foreach (int i in Enum.GetValues(_currentCategory))
            {
                if (j == value)
                {
                    ValueTextBox.Text = i.ToString();
                    break;
                }

                j++;
            }

        }
    }
}
