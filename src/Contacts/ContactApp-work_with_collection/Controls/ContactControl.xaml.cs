using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ContactApp_work_with_collection.Controls
{
    /// <summary>
    /// Логика взаимодействия для ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
            DataObject.AddPastingHandler(PhoneNumberTextBox, TextBoxPaste);
        }

        private void PhoneNumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text != "+" && e.Text != "-" && e.Text != "(" && e.Text != ")" && e.Text != " "
                && !Int32.TryParse(e.Text, out int value))
            {
                e.Handled = true;
            }
        }

        private void TextBoxPaste(object sender, DataObjectPastingEventArgs e)
        {
            TextBox tb = sender as TextBox;
            bool isCorrectText = false;

            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                string pasteText = e.DataObject.GetData(typeof(string)) as string;
                Regex pattern1 = new Regex(@"^\+\d{1}\s\(\d{3}\)\s\d{3}\-\d{2}-\d{2}$");
                Regex pattern2 = new Regex(@"^\+\d{1}\(\d{3}\)\d{3}\-\d{2}-\d{2}$");
                if (pattern1.IsMatch(pasteText) || pattern2.IsMatch(pasteText))
                {
                    isCorrectText = true;
                }
            }
            if (!isCorrectText)
            {
                e.CancelCommand();
            }
        }

    }
}
