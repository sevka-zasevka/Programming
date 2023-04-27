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
    public partial class WeekdayParsingGrupBoxControl : UserControl
    {

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
