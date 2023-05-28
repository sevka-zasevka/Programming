using Newtonsoft.Json;

namespace MoviApp.Class
{
    /// <summary>
    /// Содержит методы для сериаллизации и десериализации
    /// </summary>
    public static class ProjectSerializer
    {
        // TODO: убрать абсолютные пути
        private static string _file = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MoviesApp/Movies.json");
        //private string _file = "C:/Users/evsev/AppData/Roaming/MovieApp/Movies.json";
        // public string File { get; set; }
        public static void SaveToFile(List<Movie> movie)
        {
            var filePath = Path.GetDirectoryName(_file);
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(_file))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, movie);
            }

        }

        public static List<Movie> LoadFromFile()
        {
            if (!File.Exists(_file))
            {
                return new List<Movie>();
            }

            return JsonConvert.DeserializeObject<List<Movie>>(File.ReadAllText(_file));

            var movie = new List<Movie>();
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(_file))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                movie = (List<Movie>)serializer.Deserialize(reader);
            }
            return movie;
        }
    }
}
