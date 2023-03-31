class Song
{
    private int _durationInMinutes;

    public string Author { get; set; }

    public string Singer { get; set; }

    public string Albom { get; set; }

    public string Genre { get; set; }

    public int DurationInMinutes
    {
        get => _durationInMinutes; 
        set 
        {
            Validator.AssertOnPositiveValue(value, "DurationInMinutes.Song");
            _durationInMinutes = value; 
        }
    }

    public Song()
    {

    }

    public Song(string author, string singer, string albom, string genre, int durationInMinutes)
    {
        Author = author;
        Singer = singer;
        Albom = albom;
        Genre = genre;
        DurationInMinutes = durationInMinutes;
    }
    
}
