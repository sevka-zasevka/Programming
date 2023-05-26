using Microsoft.VisualBasic.Devices;
using MoviesApp;
using Programming.Model.Class;
using System;
using System.Drawing;
using System.Globalization;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public Movie CurrentMovie = new Movie();
        public List<Movie> Movies = new List<Movie> { };
        public int Count = 1;
        public string FilePath = "../../../Movies.txt";
        public MainForm()
        {
            InitializeComponent();
            for (int i = 0;i < Enum.GetNames(typeof(Genres)).Length; i++)
            {
                GenreComboBox.Items.Add(Enum.GetName(typeof(Genres), i));
            }

            StreamReader Movie = File.OpenText(FilePath);
            foreach(string line in Movie.ReadToEnd().Split("\n"))
            {
                Movie movie = new Movie();
                string[] description;
                description = line.Split(" ");
                movie.Title= description[0];
                movie.YearOfIssue = Convert.ToInt32(description[1]);
                movie.Genre = Convert.ToInt32(description[2]);
                movie.Rate = Convert.ToDouble(description[3]);
                movie.Duration = Convert.ToInt32(description[4]);
                Movies.Add(movie);
                MoviesListBox.Items.Add(LineToListBox(movie));
            }
            Movie.Close();
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie("Фильм" + Count.ToString(), 1, 0, 0, 0);
            Count++;
            Movies.Add(movie);
            MoviesListBox.Items.Add(LineToListBox(movie));
            UpdateFile(Movies);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int selectMovie = MoviesListBox.SelectedIndex;
            MoviesListBox.SelectedIndex = -1;
            Movies.RemoveAt(selectMovie);
            MoviesListBox.Items.RemoveAt(selectMovie);
            UpdateFile(Movies);
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectMovie = MoviesListBox.SelectedIndex;
            if (selectMovie != -1)
            {
                CurrentMovie = Movies[selectMovie];
                TitleTextBox.Text = CurrentMovie.Title.ToString();
                ReleaseTextBox.Text = CurrentMovie.YearOfIssue.ToString();
                RateTextBox.Text = CurrentMovie.Rate.ToString();
                DurationTextBox.Text = CurrentMovie.Duration.ToString();
                GenreComboBox.SelectedIndex = CurrentMovie.Genre;
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
                        int currentSelection = TitleTextBox.SelectionStart;
                        MoviesListBox.Items[selectMovie] = LineToListBox(CurrentMovie);
                        TitleTextBox.Focus();
                        TitleTextBox.SelectionStart = currentSelection;
                        Movies[selectMovie] = CurrentMovie;
                    }
                }
                catch
                {
                    TitleTextBox.BackColor = Color.HotPink;
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
                }
            }
            UpdateFile(Movies);
        }

        public string LineToListBox(Movie movie)
        {
            string line = movie.Title + "/" + movie.YearOfIssue.ToString() + "/" + GetGanre(movie);
            return line;
        }

        public string GetGanre(Movie movie) 
        {
            return Enum.GetName(typeof(Genres), movie.Genre);
        }

        public string FileLine(Movie movie)
        {
            return movie.Title+" "+movie.YearOfIssue.ToString()+" "+movie.Genre.ToString()+" "+movie.Rate.ToString()+" "+movie.Duration.ToString()+" ";
        }

        public void UpdateFile(List<Movie> movies)
        {
            string text = "";
            int i = movies.Count;
            int j = 0;
            foreach (Movie movie in movies) 
            {
                j++;
                if (j != i)
                {
                    text += FileLine(movie) + "\n";
                }
                else
                {
                    text += FileLine(movie);
                }
            }
            StreamWriter ChangeFile = File.CreateText(FilePath);
            ChangeFile.Write(text);
            ChangeFile.Close();
        }
    }
}