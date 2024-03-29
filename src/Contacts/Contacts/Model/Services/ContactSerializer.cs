using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using Newtonsoft.Json;
using Path = System.IO.Path;

namespace View.Model.Services
{
    internal class ContactSerializer
    {
        /// <summary>
        /// Название файла.
        /// </summary>
        public static string FileName { get; set; }

        /// <summary>
        /// Осуществляет запись данных в файл.
        /// </summary>
        /// <param name="contacts">Kонтакт.</param>
        public static void SaveToFile(Contact contact)
        {
            string directoryName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contacts");
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryName);
            if(!directoryInfo.Exists)
            {
                Directory.CreateDirectory(directoryName);
            }
            FileName = Path.Combine(directoryName, "contacts.json");
            File.WriteAllText(FileName, string.Empty);
            File.AppendAllText(FileName, JsonConvert.SerializeObject(contact));
        }

        /// <summary>
        /// Осуществляет выгрузку данных из файла.
        /// </summary>
        /// <returns>Возвращает контакт.</returns>
        public static Contact LoadFromFile()
        {
            var contact = new Contact();
            try
            {
                if (FileName == null)
                {
                    string directoryName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contacts");
                    FileName = Path.Combine(directoryName, "contacts.json");
                }
                using (JsonTextReader reader = new JsonTextReader(new StreamReader(FileName)))
                {
                    reader.Read();
                    JsonSerializer serializer = new JsonSerializer();
                    contact = serializer.Deserialize<Contact>(reader);
                    reader.Close();
                }

                return contact;
            }
            catch
            {
                return contact;
            }
        }
    }
}

