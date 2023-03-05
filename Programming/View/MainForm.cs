using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Programming
{
    public partial class MainForm : Form
    {
        public Type _currentCategory;
        public MainForm()
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
                    message = "Ёто день недели (";
                    string partMess = weekdayName.ToString();
                    int v = (int)Enum.Parse(_currentCategory, weekdayName);
                    string valueWeekday = v.ToString();
                    message = message + partMess + " = " + valueWeekday + ")";
                    WeekdayMessageTextBox.Text = message.ToString();
                    flag = true;
                }
            }

            if(flag==false)
            {
                message = "Ќет такого дн€ недели";
                WeekdayMessageTextBox.Text = message.ToString();
            }

        }

        private void GoSeasonButton_Click(object sender, EventArgs e)
        {
            string selectedSeason = SeasonComboBox.SelectedItem.ToString();
            SeasonGroupBox.BackColor = Color.White;
            GoSeasonButton.BackColor = Color.LightGray;
            switch (selectedSeason)
            {
                case "Winter":
                    MessageBox.Show("„увствуетс€ похолодание");
                    break;
                case "Spring":
                    SeasonGroupBox.BackColor = Color.GreenYellow;
                    break;
                case "Summer":
                    MessageBox.Show("я тоже люблю лето");
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