class Movie
{
    private int _durationInMinutes;
    private int _yearOfIssue;
    private double _rate;

    public string Title { get; set; }

    public int DurationInMinutes
    {
        get => _durationInMinutes; 
        set 
        {
            Validator.AssertOnPositiveValue(value, "DurationInMinutes.Movie");
            _durationInMinutes = value;
        }
    }

    public int YearOfIssue
    {
        get => _yearOfIssue; 
        set 
        {
            Validator.AssertValueInRange(value, 1990, DateTime.Now.Year, "YearOfIssue.Movie");
            _yearOfIssue = value; 
        }
    }

    public string Genre { get; set; }

    public double Rate
    {
        get => _rate; 
        set
        {
            Validator.AssertValueInRange(value, 0, 10, "Rate.Movie");
            _rate = value; 
        }
    }

    public Movie()
    {

    }

    public Movie(string title, int durationInMinutes, int yearOfIssue, string genre, double rate)
    {
        Title =  title;
        DurationInMinutes = durationInMinutes;
        YearOfIssue = yearOfIssue;
        Genre = genre;
        Rate = rate;
    }
}
