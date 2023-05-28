using Microsoft.VisualBasic.Devices;
using System;
using System.Drawing;
using System.Globalization;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using MoviApp.Class;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public Movie CurrentMovie = new Movie();
        public List<Movie> Movies = new List<Movie> { };
        public int Count = 1;
        public MainForm()
        {
            InitializeComponent();
            for (int i = 0;i < Enum.GetNames(typeof(Genres)).Length; i++)
            {
                GenreComboBox.Items.Add(Enum.GetName(typeof(Genres), i));
            }
            Movies = ProjectSerializer.LoadFromFile();
            foreach(Movie movies in Movies)
            {
                MoviesListBox.Items.Add(LineToListBox(movies));
            }
            ApplyButton.Visible = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie("Movie" + Count.ToString(), 1, 0, 0, 0);
            Count++;
            Movies.Add(movie);
            ChangeTextBoxColor(false);
            WriteInTextBox(movie);
            if (ApplyButton.Visible == false)
            {
                MoviesListBox.Items.Add(LineToListBox(movie));
                UpdateFile(Movies);
                ChangeTextBoxColor(true);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int selectMovie = MoviesListBox.SelectedIndex;
            if (selectMovie != -1)
            {
                MoviesListBox.SelectedIndex = -1;
                Movies.RemoveAt(selectMovie);
                MoviesListBox.Items.RemoveAt(selectMovie);
                UpdateFile(Movies);
            }
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectMovie = MoviesListBox.SelectedIndex;
            if (selectMovie != -1)
            {
                CurrentMovie = Movies[selectMovie];
                WriteInTextBox(CurrentMovie);
            }
            else
            {
                TitleTextBox.Clear();
                ReleaseTextBox.Clear();
                RateTextBox.Clear();
                DurationTextBox.Clear();
                GenreComboBox.SelectedIndex = -1;
            }
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectMovie = MoviesListBox.SelectedIndex;
            if (selectMovie == -1)
            {
                TitleTextBox.BackColor = Color.White;
            }
            else
            {
                CurrentMovie = Movies[selectMovie];
                try
                {
                    string newTitle = TitleTextBox.Text.ToString();
                    if (newTitle != CurrentMovie.Title)
                    {
                        CurrentMovie.Title = newTitle;
                        TitleTextBox.BackColor = Color.White;
                        ValidationTitleLable.Visible = false;
                        int currentSelection = TitleTextBox.SelectionStart;
                        MoviesListBox.Items[selectMovie] = LineToListBox(CurrentMovie);
                        TitleTextBox.Focus();
                        TitleTextBox.SelectionStart = currentSelection;
                        Movies[selectMovie] = CurrentMovie;
                    }
                }
                catch
                {
                    TitleTextBox.BackColor = Color.LightPink;
                    ValidationTitleLable.Visible = true;
                }
            }
            UpdateFile(Movies);
        }


        private void ReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectMovie = MoviesListBox.SelectedIndex;
            if (selectMovie == -1)
            {
                ReleaseTextBox.BackColor = Color.White;
            }
            else
            {
                CurrentMovie = Movies[selectMovie];
                try
                {
                    int newYear = Convert.ToInt32(ReleaseTextBox.Text);
                    if (newYear != CurrentMovie.YearOfIssue)
                    {
                        CurrentMovie.YearOfIssue = newYear;
                        ReleaseTextBox.BackColor = Color.White;
                        ValidationYearLabel.Visible = false;
                        int currentSelection = ReleaseTextBox.SelectionStart;
                        MoviesListBox.Items[selectMovie] = LineToListBox(CurrentMovie);
                        ReleaseTextBox.Focus();
                        ReleaseTextBox.SelectionStart = currentSelection;
                        Movies[selectMovie] = CurrentMovie;
                    }
                }
                catch
                {
                    ReleaseTextBox.BackColor = Color.LightPink;
                    ValidationYearLabel.Visible = true;
                }
            }
            UpdateFile(Movies);
        }

        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectMovie = MoviesListBox.SelectedIndex;
            if (selectMovie != -1) 
            {
                CurrentMovie = Movies[selectMovie];
                int selectGanre = GenreComboBox.SelectedIndex;
                if (selectGanre != -1 && selectGanre != CurrentMovie.Genre)
                {
                    CurrentMovie.Genre = selectGanre;
                    MoviesListBox.Items[selectMovie] = LineToListBox(CurrentMovie);
                    Movies[selectMovie] = CurrentMovie;
                }
            }
            UpdateFile(Movies);
        }

        private void RateTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectMovie = MoviesListBox.SelectedIndex;
            if (selectMovie == -1)
            {
                RateTextBox.BackColor = Color.White;
            }
            else
            {
                CurrentMovie = Movies[selectMovie];
                try
                {
                    double newRate = Convert.ToDouble(RateTextBox.Text);
                    if (newRate != CurrentMovie.Rate)
                    {
                        CurrentMovie.Rate = newRate;
                        RateTextBox.BackColor = Color.White;
                        ValidationRateLabel.Visible = false;
                        int currentSelection = RateTextBox.SelectionStart;
                        MoviesListBox.Items[selectMovie] = LineToListBox(CurrentMovie);
                        RateTextBox.Focus();
                        RateTextBox.SelectionStart = currentSelection;
                        Movies[selectMovie] = CurrentMovie;
                    }
                }
                catch
                {
                    RateTextBox.BackColor = Color.LightPink;
                    ValidationRateLabel.Visible = true;
                }
            }
            UpdateFile(Movies);
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectMovie = MoviesListBox.SelectedIndex;
            if (selectMovie == -1)
            {
                DurationTextBox.BackColor = Color.White;
            }
            else
            {
                CurrentMovie = Movies[selectMovie];
                try
                {
                    int newDur = Convert.ToInt32(DurationTextBox.Text);
                    if (newDur != CurrentMovie.Duration)
                    {
                        CurrentMovie.Duration = newDur;
                        DurationTextBox.BackColor = Color.White;
                        ValidationDurationLabel.Visible = false;
                        int currentSelection = DurationTextBox.SelectionStart;
                        MoviesListBox.Items[selectMovie] = LineToListBox(CurrentMovie);
                        DurationTextBox.Focus();
                        DurationTextBox.SelectionStart = currentSelection;
                        Movies[selectMovie] = CurrentMovie;
                    }
                }
                catch
                {
                    DurationTextBox.BackColor = Color.LightPink;
                    ValidationDurationLabel.Visible = true;
                }
            }
            UpdateFile(Movies);
        }
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (TitleTextBox.ReadOnly == true)
            {
                ChangeTextBoxColor(false);
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            int selected = MoviesListBox.SelectedIndex;
            ChangeTextBoxColor(true);
            Sort(Movies);
            for (int i = 0; i < Movies.Count; i++)
            {
                if (Movies[i] == CurrentMovie)
                {
                    MoviesListBox.SelectedIndex = i;
                }
            }
            ApplyButton.Visible = false;
        }

        /// <summary>
        /// ћетод дл€ создани€ строки в MoviesListBox.
        /// </summary>
        /// <param name="movie">Ёкземпл€р класса <see cref="Movie"/> на основе которого создаетс€ строка.</param>
        /// <returns></returns>
        public string LineToListBox(Movie movie)
        {
            string line = movie.Title + "/" + movie.YearOfIssue.ToString() + "/" + GetGenre(movie);
            return line;
        }

        /// <summary>
        /// ћетод дл€ получени€ названи€ жанра.
        /// </summary>
        /// <param name="movie">Ёкземпл€р класса <see cref="Movie"/> жанр которого нужно получить.</param>
        /// <returns></returns>
        public string GetGenre(Movie movie) 
        {
            return Enum.GetName(typeof(Genres), movie.Genre);
        }

        /// <summary>
        /// ћетод дл€ сериаллизации в файл коллекции элементов.
        /// </summary>
        /// <param name="movies"> оллекци€ элементов класса <see cref="Movie"/>, сериаллизуема€ в файл.</param>
        public void UpdateFile(List<Movie> movies)
        {
            ProjectSerializer.SaveToFile(movies);
        }

        /// <summary>
        /// ћетод дл€ сортировки коллекции эллементов класса <see cref="Movie"/> 
        /// в алфавитном пор€дке и пересериализации в файл.
        /// </summary>
        /// <param name="movies">—ортируема€ коллекци€ элементов класса <see cref="Movie"/>.</param>
        public void Sort(List<Movie> movies)
        {
            movies.Sort((left, right) => left.Title.CompareTo(right.Title));
            MoviesListBox.Items.Clear();
            foreach (Movie movie in movies) 
            {
                MoviesListBox.Items.Add(LineToListBox(movie));
            }
            UpdateFile(movies);
        }

        /// <summary>
        /// ћетод дл€ изменени€ модификатора доступа у TextBox и TextBox.BackColor.
        /// </summary>
        /// <param name="flag">ѕоказатель изменени€ модификаторов доступа.</param>
        public void ChangeTextBoxColor(bool flag)
        {
            if (flag)
            {
                TitleTextBox.ReadOnly = true;
                TitleTextBox.BackColor = Color.LightGray;
                ReleaseTextBox.ReadOnly = true;
                ReleaseTextBox.BackColor = Color.LightGray;
                RateTextBox.ReadOnly = true;
                RateTextBox.BackColor = Color.LightGray;
                DurationTextBox.ReadOnly = true;
                DurationTextBox.BackColor = Color.LightGray;
                GenreComboBox.BackColor = Color.LightGray;
            }
            else
            {
                TitleTextBox.ReadOnly = false;
                TitleTextBox.BackColor = Color.White;
                ReleaseTextBox.ReadOnly = false;
                ReleaseTextBox.BackColor = Color.White;
                RateTextBox.ReadOnly = false;
                RateTextBox.BackColor = Color.White;
                DurationTextBox.ReadOnly = false;
                DurationTextBox.BackColor = Color.White;
                GenreComboBox.BackColor = Color.White;
                ApplyButton.Visible = true;
            }
        }

        /// <summary>
        /// ћетод дл€ записи данных экземпл€ра класса <see cref="Movie"/>
        /// в соответствующие TextBox.
        /// </summary>
        /// <param name="movie">Ёкземпл€р класса <see cref="Movie"/>.</param>
        public void WriteInTextBox(Movie movie)
        {
            TitleTextBox.Text = movie.Title.ToString();
            ReleaseTextBox.Text = movie.YearOfIssue.ToString();
            RateTextBox.Text = movie.Rate.ToString();
            DurationTextBox.Text = movie.Duration.ToString();
            GenreComboBox.SelectedIndex = movie.Genre;
        }
    }
}