namespace Programming.Model.Class
{
    /// <summary>
    /// Класс, хранящий название, жанр, рейтинг, год выпуска и продолжительность в минутах.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Продолжительность в минутах, только положительное значение.
        /// </summary>
        private int _durationInMinutes;

        /// <summary>
        /// Год выпуска, с 1990г. до настоящего года.
        /// </summary>
        private int _yearOfIssue;

        /// <summary>
        /// Рейтинг фильма, от 0 до 10.
        /// </summary>
        private double _rate;

        /// <summary>
        /// Возвращает и задает название фильма.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительности в минутах, только положотельное значение.
        /// </summary>
        public int DurationInMinutes
        {
            get => _durationInMinutes;
            set
            {
                Validator.AssertOnPositiveValue(value, "DurationInMinutes.Movie");
                _durationInMinutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задает год выпуска фильма, от 1990г. до настоящего года.
        /// </summary>
        public int YearOfIssue
        {
            get => _yearOfIssue;
            set
            {
                Validator.AssertValueInRange(value, 1990, DateTime.Now.Year, "YearOfIssue.Movie");
                _yearOfIssue = value;
            }
        }

        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает рейтинг фильма, от 0 до 10.
        /// </summary>
        public double Rate
        {
            get => _rate;
            set
            {
                Validator.AssertValueInRange(value, 0, 10, "Rate.Movie");
                _rate = value;
            }
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Movie">
        /// </summary>
        public Movie()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Movie">.
        /// </summary>
        /// <param name="title">Название фильма.</param>
        /// <param name="durationInMinutes">Продолжительность фильма в минутах.</param>
        /// <param name="yearOfIssue">Год выпуска фильма, с 1990г. до настоящего года.</param>
        /// <param name="genre">Жанр фильма.</param>
        /// <param name="rate">Рейтинг фильма, от 0 до 10.</param>
        public Movie(string title, int durationInMinutes, int yearOfIssue, string genre, double rate)
        {
            Title = title;
            DurationInMinutes = durationInMinutes;
            YearOfIssue = yearOfIssue;
            Genre = genre;
            Rate = rate;
        }
    }
}
