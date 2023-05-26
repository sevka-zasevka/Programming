using MoviesApp;
using Programming.Model.Class;
using System;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public Movie _movieExample = new Movie();
        public List<Movie> movies = new List<Movie> { };
        public MainForm()
        {
            InitializeComponent();
            for (int i = 0;i < Enum.GetNames(typeof(Genre)).Length; i++)
            {
                GenreComboBox.Items.Add(Enum.GetName(typeof(Genre), i));
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReleaseTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}