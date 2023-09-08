using Programming.Model.Class;


namespace Programming.View.EnumsControl
{
    /// <summary>
    /// Для проверки дня недели.
    /// </summary>
    public partial class WeekdayParsingGrupBoxControl : UserControl
    {
        /// <summary>
        /// Переменная для хранения выбранной категории.
        /// </summary>
        public Type _currentCategory;

        public WeekdayParsingGrupBoxControl()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            if (WeekdayTextBox.Text == "") return;
            bool flag = false;
            string message;
            string parsedWeekday = WeekdayTextBox.Text;
            _currentCategory = typeof(Weekday);
            foreach (string weekdayName in Enum.GetNames(_currentCategory))
            {
                if (parsedWeekday == weekdayName)
                {
                    message = "Это день недели (";
                    string partMess = weekdayName.ToString();
                    int v = (int)Enum.Parse(_currentCategory, weekdayName);
                    string valueWeekday = v.ToString();
                    message = message + partMess + " = " + valueWeekday + ")";
                    WeekdayMessageTextBox.Text = message.ToString();
                    flag = true;
                }
            }

            if (flag == false)
            {
                message = "Нет такого дня недели";
                WeekdayMessageTextBox.Text = message.ToString();
            }

        }
    }
}
