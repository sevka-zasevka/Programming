using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Programming
{
    public partial class MainForm : Form
    {
        Type currentCategory;
        public MainForm()
        {
            InitializeComponent();
            listBoxEnums.SetSelected(0, true);
        }

        private void listBoxEnums_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = listBoxEnums.SelectedItem.ToString();
            listBoxValue.Items.Clear();
            switch (selectedCategory)
            {
                case "Colors":
                    currentCategory = typeof(Colors);
                    foreach (int i in Enum.GetValues(currentCategory))
                        listBoxValue.Items.Add(Enum.GetName(currentCategory, i));
                    break;
                case "EducationForm":
                    currentCategory = typeof(EducationForm);
                    foreach (int i in Enum.GetValues(currentCategory))
                        listBoxValue.Items.Add(Enum.GetName(currentCategory, i));
                    break;
                case "Genre":
                    currentCategory = typeof(Genre);
                    foreach (int i in Enum.GetValues(currentCategory))
                        listBoxValue.Items.Add(Enum.GetName(currentCategory, i));
                    break;
                case "Manufactures":
                    currentCategory = typeof(Manufactures);
                    foreach (int i in Enum.GetValues(currentCategory))
                        listBoxValue.Items.Add(Enum.GetName(currentCategory, i));
                    break;
                case "Season":
                    currentCategory = typeof(Season);
                    foreach (int i in Enum.GetValues(currentCategory))
                        listBoxValue.Items.Add(Enum.GetName(currentCategory, i));
                    break;
                case "Weekday":
                    currentCategory = typeof(Weekday);
                    foreach (int i in Enum.GetValues(currentCategory))
                        listBoxValue.Items.Add(Enum.GetName(currentCategory, i));
                    break;
            }
        }

        private void listBoxValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = listBoxValue.SelectedIndex;
            textBoxValue.Text = value.ToString();
        }

        private void buttonParse_Click(object sender, EventArgs e)
        {
            if (textBoxWeekday.Text == "") return;
            bool flag = false;
            string message;
            string parsedWeekday = textBoxWeekday.Text;
            currentCategory = typeof(Weekday);
            foreach (string weekdayName in Enum.GetNames(currentCategory))
                if (parsedWeekday == weekdayName)
                {
                    message = "Ёто день недели (";
                    string partMess = weekdayName.ToString();
                    int v = (int)Enum.Parse(currentCategory, weekdayName);
                    string valueWeekday = v.ToString();
                    message = message + partMess + " = " + valueWeekday + ")";
                    textBoxWeekdayMessage.Text = message.ToString();
                    flag = true;
                }
            if(flag==false)
            {
                message = "Ќет такого дн€ недели";
                textBoxWeekdayMessage.Text = message.ToString();
            }

        }

        private void buttonGoSeason_Click(object sender, EventArgs e)
        {
            string selectedSeason = comboBoxSeason.SelectedItem.ToString();
            groupBoxSeason.BackColor = Color.White;
            buttonGoSeason.BackColor = Color.LightGray;
            switch (selectedSeason)
            {
                case "Winter":
                    MessageBox.Show("„увствуетс€ похолодание");
                    break;
                case "Spring":
                    groupBoxSeason.BackColor = Color.GreenYellow;
                    break;
                case "Summer":
                    MessageBox.Show("я тоже люблю лето");
                    buttonGoSeason.BackColor = Color.Green;
                    break;
                case "Fall":
                    MessageBox.Show("We fell in love in October");
                    groupBoxSeason.BackColor = Color.MediumVioletRed;
                    break;
            }
        }
    }
 
}