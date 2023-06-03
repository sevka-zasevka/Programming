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
        // TODO: XML
        // TODO: private
        public Movie CurrentMovie = new Movie();
        public List<Movie> Movies = new List<Movie>();
        public int Count = 1;
        public Movie CloneMovie;
        public bool ChangeFlag = false;
        public bool AddFlag = false;
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
            MoviesListBox.Items.Add(LineToListBox(movie));
            MoviesListBox.SelectedIndex = (MoviesListBox.Items.Count) - 1;
            ChangeTextBoxColor(false);
            Visible(false);
            AddFlag = true;
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
            // TODO: selectMovieIndex
            int selectMovie = MoviesListBox.SelectedIndex;
            if (selectMovie != -1)
            {
                if (!ChangeFlag && !AddFlag)
                {
                    CurrentMovie = Movies[selectMovie];
                    WriteInTextBox(CurrentMovie);
                }
            }
            else
            {
                TitleTextBox.Clear();
                ReleaseTextBox.Clear();
                RateTextBox.Clear();
                DurationTextBox.Clear();
                GenreComboBox.SelectedIndex = -1;
                ChangeTextBoxColor(true);
            }
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectMovie = MoviesListBox.SelectedIndex;
            if (selectMovie != -1)
            {
                // TODO: дубль
                if (ChangeFlag)
                {
                    try
                    {
                        string newTitle = TitleTextBox.Text.ToString();
                        if (newTitle != CurrentMovie.Title)
                        {
                            CurrentMovie.Title = newTitle;
                            TitleTextBox.BackColor = Color.White;
                            ValidationTitleLable.Visible = false;
                            int currentSelection = TitleTextBox.SelectionStart;
                            TitleTextBox.Focus();
                            TitleTextBox.SelectionStart = currentSelection;
                            if (!ChangeFlag)
                            {
                                Movies[selectMovie] = CurrentMovie;
                            }
                        }
                    }
                    catch
                    {
                        TitleTextBox.BackColor = Color.LightPink;
                        ValidationTitleLable.Visible = true;
                        ApplyButton.Visible = false;
                    }
                }
                if (AddFlag)
                {
                    try
                    {
                        string newTitle = TitleTextBox.Text.ToString();
                        if (newTitle != CurrentMovie.Title)
                        {
                            CurrentMovie.Title = newTitle;
                            TitleTextBox.BackColor = Color.White;
                            ValidationTitleLable.Visible = false;
                            int currentSelection = TitleTextBox.SelectionStart;
                            TitleTextBox.Focus();
                            TitleTextBox.SelectionStart = currentSelection;
                        }
                    }
                    catch
                    {
                        TitleTextBox.BackColor = Color.LightPink;
                        ValidationTitleLable.Visible = true;
                        ApplyButton.Visible = false;
                    }
                }
            }
        }


        private void ReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectMovie = MoviesListBox.SelectedIndex;
            if (selectMovie != -1)
            {
                if (ChangeFlag)
                {
                    // TODO: дубль
                    try
                    {
                        int newYear = Convert.ToInt32(ReleaseTextBox.Text);
                        if (newYear != CloneMovie.YearOfIssue)
                        {
                            CloneMovie.YearOfIssue = newYear;
                            ReleaseTextBox.BackColor = Color.White;
                            ValidationYearLabel.Visible = false;
                            int currentSelection = ReleaseTextBox.SelectionStart;
                            ReleaseTextBox.Focus();
                            ReleaseTextBox.SelectionStart = currentSelection;
                        }
                    }
                    catch
                    {
                        ReleaseTextBox.BackColor = Color.LightPink;
                        ValidationYearLabel.Visible = true;
                        ApplyButton.Visible = false;
                    }
                }
                if (AddFlag)
                {
                    try
                    {
                        int newYear = Convert.ToInt32(ReleaseTextBox.Text);
                        if (newYear != CloneMovie.YearOfIssue)
                        {
                            CloneMovie.YearOfIssue = newYear;
                            ReleaseTextBox.BackColor = Color.White;
                            ValidationYearLabel.Visible = false;
                            int currentSelection = ReleaseTextBox.SelectionStart;
                            ReleaseTextBox.Focus();
                            ReleaseTextBox.SelectionStart = currentSelection;
                        }
                    }
                    catch
                    {
                        ReleaseTextBox.BackColor = Color.LightPink;
                        ValidationYearLabel.Visible = true;
                        ApplyButton.Visible = false;
                    }
                }

            }
        }

        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectMovie = MoviesListBox.SelectedIndex;
            if (selectMovie != -1)
            {
                // TODO: дубль
                if (ChangeFlag)
                {
                    int selectGanre = GenreComboBox.SelectedIndex;
                    if (selectGanre != -1 && selectGanre != CurrentMovie.Genre)
                    {
                        CurrentMovie.Genre = selectGanre;
                    }
                }
                if (AddFlag)
                {

                    int selectGanre = GenreComboBox.SelectedIndex;
                    if (selectGanre != -1 && selectGanre != CurrentMovie.Genre)
                    {
                        CurrentMovie.Genre = selectGanre;
                    }
                }
            }
        }

        private void RateTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectMovie = MoviesListBox.SelectedIndex;
            if (selectMovie != -1)
            {
                // TODO: дубль
                if (ChangeFlag)
                {
                    try
                    {
                        double newRate = Convert.ToDouble(RateTextBox.Text);
                        if (newRate != CurrentMovie.Rate)
                        {
                            CurrentMovie.Rate = newRate;
                            RateTextBox.BackColor = Color.White;
                            ValidationRateLabel.Visible = false;
                            int currentSelection = RateTextBox.SelectionStart;
                            RateTextBox.Focus();
                            RateTextBox.SelectionStart = currentSelection;
                        }
                    }
                    catch
                    {
                        RateTextBox.BackColor = Color.LightPink;
                        ValidationRateLabel.Visible = true;
                        ApplyButton.Visible = false;
                    }
                }
                if(AddFlag)
                {
                    try
                    {
                        double newRate = Convert.ToDouble(RateTextBox.Text);
                        if (newRate != CurrentMovie.Rate)
                        {
                            CurrentMovie.Rate = newRate;
                            RateTextBox.BackColor = Color.White;
                            ValidationRateLabel.Visible = false;
                            int currentSelection = RateTextBox.SelectionStart;
                            RateTextBox.Focus();
                            RateTextBox.SelectionStart = currentSelection;
                        }
                    }
                    catch
                    {
                        RateTextBox.BackColor = Color.LightPink;
                        ValidationRateLabel.Visible = true;
                        ApplyButton.Visible = false;
                    }
                }
            }
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectMovie = MoviesListBox.SelectedIndex;
            if (selectMovie != -1)
            {
                if (ChangeFlag)
                {
                    try
                    {
                        int newDur = Convert.ToInt32(DurationTextBox.Text);
                        if (newDur != CurrentMovie.Duration)
                        {
                            CurrentMovie.Duration = newDur;
                            DurationTextBox.BackColor = Color.White;
                            ValidationDurationLabel.Visible = false;
                            int currentSelection = DurationTextBox.SelectionStart;
                            DurationTextBox.Focus();
                            DurationTextBox.SelectionStart = currentSelection;
                        }
                    }
                    catch
                    {
                        DurationTextBox.BackColor = Color.LightPink;
                        ValidationDurationLabel.Visible = true;
                        ApplyButton.Visible = false;
                    }
                }
                if (AddFlag)
                {
                    try
                    {
                        int newDur = Convert.ToInt32(DurationTextBox.Text);
                        if (newDur != CurrentMovie.Duration)
                        {
                            CurrentMovie.Duration = newDur;
                            DurationTextBox.BackColor = Color.White;
                            ValidationDurationLabel.Visible = false;
                            int currentSelection = DurationTextBox.SelectionStart;
                            DurationTextBox.Focus();
                            DurationTextBox.SelectionStart = currentSelection;
                        }
                    }
                    catch
                    {
                        DurationTextBox.BackColor = Color.LightPink;
                        ValidationDurationLabel.Visible = true;
                        ApplyButton.Visible = false;
                    }
                }

            }
        }
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            int selected = MoviesListBox.SelectedIndex;
            if (selected != -1)
            {
                // TODO: дубль
                ChangeFlag = true;
                Visible(false);
                ApplyButton.Visible = true;
                CancelButton.Visible = true;
                CloneMovie = Movie.Clone(Movies[selected]);
                ChangeTextBoxColor(false);
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            int selected = MoviesListBox.SelectedIndex;
            if (ChangeFlag)
            {
                Movies[selected] = CloneMovie;
                MoviesListBox.Items.Add(LineToListBox(Movies[selected]));
                ChangeTextBoxColor(true);
                Sort(Movies);
                for (int i = 0; i < Movies.Count; i++)
                {
                    if (Movies[i] == CurrentMovie)
                    {
                        MoviesListBox.SelectedIndex = i;
                    }
                }
                // TODO: дубль
                ApplyButton.Visible = false;
                CancelButton.Visible = false;
                Visible(true);
                ChangeFlag = false;
            }
            if (AddFlag)
            {
                Movies[selected] = CloneMovie;
                MoviesListBox.Items.Add(LineToListBox(Movies[selected]));
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
                CancelButton.Visible = false;
                Visible(true);
                AddFlag = false;
            }
        }

        // TODO: private methods
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
        /// –ешение вз€то с сайта <see href="https://shorturl.at/wEHK3"/>
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
                // TODO: дубль
                var backColor = flag ? Color.LightGray : Color.White;
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
                CancelButton.Visible = true;
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

        // TODO: XML
        // TODO: flag => isVivible
        public void Visible(bool flag)
        {
            AddButton.Visible = flag;
            ChangeButton.Visible = flag;
            DeleteButton.Visible = flag;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            int selected = MoviesListBox.SelectedIndex;
            MoviesListBox.Items.RemoveAt(selected);
            Movies.RemoveAt(selected);
            ChangeTextBoxColor(true);
            ApplyButton.Visible = false;
            CancelButton.Visible = false;
            Visible(true);
            ChangeFlag = false;
            AddFlag = false;
            UpdateFile(Movies);
        }
    }
}