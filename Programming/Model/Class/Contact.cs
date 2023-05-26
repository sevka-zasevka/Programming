namespace Programming.Model.Class
{
    /// <summary>
    /// Класс хранящий имя, фамилию и телефонный номер человека.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Имя человека, только буквы.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия человека, только буквы.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возвращает и задает имя человека.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                AssertStringContainsOnlyLetters(value, "Неверно введено имя");
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает фамилию человека.
        /// </summary>
        public string Surname
        {
            get => _surname;
            set
            {
                AssertStringContainsOnlyLetters(value, "Неверно введена фамилия");
                _surname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона человека.
        /// </summary>
        public string TelefonNamber { get; set; }

        /// <summary>
        /// Проверяет, что строка состоит только из букв.
        /// </summary>
        /// <param name="value">Проверяемая строка. </param>
        /// <param name="mass">Возвращаемый текст ошибки.</param>
        /// <exception cref="ArgumentException"></exception>
        private void AssertStringContainsOnlyLetters(string value, string mass)
        {
            char[] valueChar = value.ToCharArray();
            for (int i = 0; i < valueChar.Length; i++)
            {
                if (valueChar[i] <= 65 || valueChar[i] >= 90 || valueChar[i] <= 97 || valueChar[i] >= 122)
                {
                    throw new ArgumentException(mass);
                }
            }
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Contact">
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact">
        /// </summary>
        /// <param name="name">Имя, только буквы.</param>
        /// <param name="surname">Фамилияб только буквы.</param>
        /// <param name="telefonNamber">Номер телефона.</param>
        public Contact(string name, string surname, string telefonNamber)
        {
            Name = name;
            Surname = surname;
            TelefonNamber = telefonNamber;
        }
    }
}
