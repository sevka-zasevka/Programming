using System.Text.RegularExpressions;
using System.Windows.Forms;

class Contact
{
    private string _name;
    private string _surname;

    public string Name 
    { 
        get => _name; 
        set
        {
            AssertStringContainsOnlyLetters(value, "Неверно введено имя");
            _name = value;
        }
    }

    public string Surname 
    {
        get => _surname;
        set
        {
            AssertStringContainsOnlyLetters(value, "Неверно введена фамилия");
            _surname = value;
        }
    }

    public string TelefonNamber { get; set; }

    private void AssertStringContainsOnlyLetters(string value, string mass)
    {
        char[] valueChar = value.ToCharArray();
        for (int i = 0; i< valueChar.Length; i++)
        {
            if (valueChar[i] <= 65 || valueChar[i] >= 90 || valueChar[i] <= 97 || valueChar[i] >= 122)
            {
                throw new ArgumentException(mass);
            }
        }
    }
    public Contact()
    {

    }

    public Contact(string name, string surname, string telefonNamber)
    {
        Name = name;
        Surname = surname;
        TelefonNamber = telefonNamber;
    }
}
