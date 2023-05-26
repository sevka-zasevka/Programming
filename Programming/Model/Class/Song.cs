namespace Programming.Model.Class
{
    /// <summary>
    /// Класс, хранящий автора, исполнителя, альбом, жанр ипродолжительность в минутах песни.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Продолжительность в минутах, только положительные значения.
        /// </summary>
        private int _durationInMinutes;

        /// <summary>
        /// Возвращает и задает автора песни.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Возвращает и задает исполнителя песни.
        /// </summary>
        public string Singer { get; set; }

        /// <summary>
        /// Возвращает и задает альбом песни.
        /// </summary>
        public string Albom { get; set; }

        /// <summary>
        /// Возвращает и задает жанр песни.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает проделжительность в минутах песни, только полодительные значения.
        /// </summary>
        public int DurationInMinutes
        {
            get => _durationInMinutes;
            set
            {
                Validator.AssertOnPositiveValue(value, "DurationInMinutes.Song");
                _durationInMinutes = value;
            }
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Song">.
        /// </summary>
        public Song()
        {

        }

        /// <summary>
        /// Создает экземпляр класс <see cref="Song">.
        /// </summary>
        /// <param name="author">Автор песни.</param>
        /// <param name="singer">Исполнитель песни.</param>
        /// <param name="albom">Альбом песни.</param>
        /// <param name="genre">Жанр песни.</param>
        /// <param name="durationInMinutes">Продолжительность песни в минутах, только положительные значения.</param>
        public Song(string author, string singer, string albom, string genre, int durationInMinutes)
        {
            Author = author;
            Singer = singer;
            Albom = albom;
            Genre = genre;
            DurationInMinutes = durationInMinutes;
        }

    }
}
