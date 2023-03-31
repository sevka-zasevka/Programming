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
        string pattern = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
        char[] patternChar = pattern.ToCharArray();
        char[] valueChar = value.ToCharArray();
        for (int i = 0; i< valueChar.Length; i++)
        {
            for (int j = 0; j<patternChar.Length; j++)
            {
                if (valueChar[i] == patternChar[j])
                {
                    break;
                } 
                else
                {
                    throw new ArgumentException(mass);
                }
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
