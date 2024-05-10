using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;
using Path = System.IO.Path;

namespace View.Model.Services
{
    /// <summary>
    /// Класс для сериализации и десериализации объектов класса <see cref="Contact"/>.
    /// </summary>
    public class ContactSerializer
    {
        /// <summary>
        /// Название файла.
        /// </summary>
        public static string FileName { get; set; }

        /// <summary>
        /// Осуществляет запись данных в файл.
        /// </summary>
        /// <param name="contacts">Kонтакт.</param>
        public static void SaveToFile(ObservableCollection<Contact> contacts)
        {
            string directoryName =
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contacts");
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryName);
            if (!directoryInfo.Exists)
            {
                Directory.CreateDirectory(directoryName);
            }
            FileName = Path.Combine(directoryName, "contacts.json");
            File.WriteAllText(FileName, string.Empty);
            for (int i = 0; i < contacts.Count; i++)
            {
                File.AppendAllText(FileName, JsonConvert.SerializeObject(contacts[i]));

            }
        }

        /// <summary>
        /// Осуществляет выгрузку данных из файла.
        /// </summary>
        /// <returns>Возвращает контакт.</returns>
        public static ObservableCollection<Contact> LoadFromFile()
        {
            string directoryName =
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contacts");
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryName);
            if (!directoryInfo.Exists)
            {
                Directory.CreateDirectory(directoryName);
            }
            FileName = Path.Combine(directoryName, "contacts.json");
            FileInfo fileInfo = new FileInfo(FileName);
            if (fileInfo.Exists)
            {
                ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();
                JsonTextReader reader = new JsonTextReader(new StreamReader(FileName));
                reader.SupportMultipleContent = true;
                while (reader.Read())
                {
                    JsonSerializer serializer = new JsonSerializer();
                    Contact loadedContact = serializer.Deserialize<Contact>(reader);
                    contacts.Add(loadedContact);
                }
                reader.Close();
                return contacts;
            }
            else
            {
                File.WriteAllText(FileName, string.Empty);
                return new ObservableCollection<Contact>();
            }
        }
    }
}

