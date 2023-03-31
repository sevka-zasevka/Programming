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
        private Rectangle[] _rectangles = new Rectangle[5];
        private Rectangle _currentRectangle = new Rectangle();
        private Random _random = new Random();
        private Movie[] _movies = new Movie[5];
        private Movie _currentMovie = new Movie();
        public MainForm()
        {
            Rectangle exampleRectangle = new Rectangle();
            Movie exampleMovie = new Movie();
            InitializeComponent();
            EnumsListBox.SetSelected(0, true);
            string[] titlesMovie = { "The End", "A new beginning", "Adventure 2", "End:Last part 2", "Middle: End of story"};

            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Rectangle(RandDoubleValue(), RandDoubleValue(), Enum.GetName(typeof(Colors), _random.Next(1, 7)), _random.Next(0, 100), _random.Next(0, 100));
            }

            for (int i = 0; i < _movies.Length; i++)
            {
                _movies[i] = new Movie(titlesMovie[i], _random.Next(1, 7200), _random.Next(1990, DateTime.Now.Year), Enum.GetName(typeof(Genre), _random.Next(1, 6)), RandRate());
            }
        }

        private double RandDoubleValue()
        {
            double value = _random.Next(100, 10000);
            value = value / 100;
            return value;
        }

        private double RandRate()
        {
            double value = _random.Next(100, 1000);
            value = value / 100;
            return value;
        }

        //Вкладка Enums

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

        private void GoSeasonButton_Click(object sender, EventArgs e)
        {
            string selectedSeason = SeasonComboBox.SelectedItem.ToString();
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

        //Вкладка Classes

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[value];
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color.ToString();
            CoordinateXTextBox.Text = _currentRectangle.Centre.X.ToString();
            CoordinateYTextBox.Text = _currentRectangle.Centre.Y.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();
            if (_currentRectangle != _rectangles[value]) 
            {
                _rectangles[value] = _currentRectangle; 
            }
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double newLength = Convert.ToDouble(LengthTextBox.Text);
                _currentRectangle.Length = newLength;
                LengthTextBox.BackColor = Color.White;
            }
            catch
            {
                LengthTextBox.BackColor = Color.LightPink;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double newWidth = Convert.ToDouble(WidthTextBox.Text);
                _currentRectangle.Width = newWidth;
                WidthTextBox.BackColor = Color.White;
            }
            catch
            {
                WidthTextBox.BackColor = Color.LightPink;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            string newColor = Convert.ToString(ColorTextBox.Text);
            _currentRectangle.Color = newColor;
        }

        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            double maxWidth = 0;
            int indexMaxWidth = -1;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth) 
                { 
                    maxWidth = rectangles[i].Width; 
                    indexMaxWidth = i;
                }
            }
            return indexMaxWidth;
        }

        private void FindRectangelButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = MovieListBox.SelectedIndex;
            _currentMovie = _movies[value];
            TitleTextBox.Text = _currentMovie.Title.ToString();
            DurationInMinutesTextBox.Text = _currentMovie.DurationInMinutes.ToString();
            YearOfIssueTextBox.Text = _currentMovie.YearOfIssue.ToString();
            GenreTextBox.Text = _currentMovie.Genre.ToString();
            RatingTextBox.Text = _currentMovie.Rate.ToString();
            if (_currentMovie != _movies[value]) { _movies[value] = _currentMovie; }
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            string newTitle = Convert.ToString(TitleTextBox.Text);
            _currentMovie.Title = newTitle;
        }

        private void DurationInMinutesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int newDurationInMinutes = Convert.ToInt32(DurationInMinutesTextBox.Text);
                _currentMovie.DurationInMinutes = newDurationInMinutes;
                DurationInMinutesTextBox.BackColor = Color.White;
            }
            catch
            {
                DurationInMinutesTextBox.BackColor = Color.LightPink;
            }
        }

        private void YearOfIssueTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int newYearOfIssue = Convert.ToInt32(YearOfIssueTextBox.Text);
                _currentMovie.YearOfIssue = newYearOfIssue;
                YearOfIssueTextBox.BackColor = Color.White;
            }
            catch
            {
                YearOfIssueTextBox.BackColor = Color.LightPink;
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            string newGenre = Convert.ToString(GenreTextBox.Text);
            _currentMovie.Genre = newGenre;
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double newRate = Convert.ToDouble(RatingTextBox.Text);
                _currentMovie.Rate = newRate;
                RatingTextBox.BackColor = Color.White;
            }
            catch
            {
                RatingTextBox.BackColor = Color.LightPink;
            }
        }

        private int FindMovieWithMaxRate(Movie[] movies)
        {
            double maxRate = 0;
            int indexMaxRate = -1;
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].Rate > maxRate)
                {
                    maxRate = movies[i].Rate;
                    indexMaxRate = i;
                }
            }
            return indexMaxRate;
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            MovieListBox.SelectedIndex = FindMovieWithMaxRate(_movies);
        }
    }
}