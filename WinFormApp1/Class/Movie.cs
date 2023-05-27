using MoviesApp;

namespace MoviApp.Class
{
    /// <summary>
    /// Класс, хранящий название, жанр, рейтинг, год выпуска и продолжительность в минутах.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Название, до 100 символов.
        /// </summary>
        private string _title;

        /// <summary>
        /// Только положительное значение.
        /// </summary>
        private int _yearOfIssue;

        /// <summary>
        /// Рейтинг фильма, не отрицательный и не больше 10.
        /// </summary>
        private double _rate;

        /// <summary>
        /// Продолжительность в минутах, только положительное значение.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Жанр фильма, не больше количества указанного в перечислении <see cref="Genre"/>.
        /// </summary>
        private int _genre;

        /// <summary>
        /// Возвращает и задает название фильма.
        /// </summary>
        public string Title
        {
            get => _title;
            set
            {
                Validator(value.Length, 0, 100, "Название Фильма меньше 100 символов.");
                _title = value;
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
                Validator(value, 0, int.MaxValue, "Год создания фильма должен быть положительным.");
                _yearOfIssue = value;
            }
        }

        public double Rate
        {
            get => _rate;
            set
            {
                Validator(value, 0, 10, "Рейтинг должен быть не отрицательным и меньше 10.");
                _rate = value;
            }
        }

        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// </summary>
        public int Genre
        {
            get => _genre;
            set
            {
                Validator(value, 0, 25, "Жанр не может не входить в перечисление Genres");
                _genre = value;
            }
        }

        /// <summary>
        /// Возвращает и задает продолжительности в минутах, только положотельное значение.
        /// </summary>
        public int Duration
        {
            get => _duration;
            set
            {
                Validator(value, 1, 300, "Подолжительность фильма от 1 до 300.");
                _duration = value;
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
        public Movie(string title, int durationInMinutes, int yearOfIssue, int genre, double rate)
        {
            Title = title;
            Duration = durationInMinutes;
            YearOfIssue = yearOfIssue;
            Genre = genre;
            Rate = rate;
        }

        /// <summary>
        /// Методот для проверки введеных значений.
        /// </summary>
        /// <param name="value">Приверяемое значение.</param>
        /// <param name="min">НИжняя граница.</param>
        /// <param name="max">Верхняя граница.</param>
        /// <param name="mass">Сообщение для выпадающего исключения.</param>
        /// <exception cref="Exception"></exception>
        private void Validator(int value, int min, int max, string mass)
        {
            if (value < min || value > max)
            {
                throw new Exception(mass);
            }
        }

        /// <summary>
        /// Методот для проверки введеных значений.
        /// </summary>
        /// <param name="value">Приверяемое значение.</param>
        /// <param name="min">НИжняя граница.</param>
        /// <param name="max">Верхняя граница.</param>
        /// <param name="mass">Сообщение для выпадающего исключения.</param>
        /// <exception cref="Exception"></exception>
        private void Validator(double value, int min, int max, string mass)
        {
            if (value < min || value > max)
            {
                throw new Exception(mass);
            }
        }

    }
}