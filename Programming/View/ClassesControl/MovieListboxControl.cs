using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.ClassesControl
{
    public partial class MovieListboxControl : UserControl
    {

        private Random _random = new Random();
        private Movie[] _movies = new Movie[5];
        private Movie _currentMovie = new Movie();

        public MovieListboxControl()
        {
            InitializeComponent();

            Movie exampleMovie = new Movie();
            string[] titlesMovie = { "The End", "A new beginning", "Adventure 2", "End:Last part 2", "Middle: End of story" };

            for (int i = 0; i < _movies.Length; i++)
            {
                _movies[i] = new Movie(titlesMovie[i], _random.Next(1, 7200), _random.Next(1990, DateTime.Now.Year), Enum.GetName(typeof(Genre), _random.Next(1, 6)), RandRate());
            }

        }

        private double RandRate()
        {
            double value = _random.Next(100, 1000);
            value = value / 100;
            return value;
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
