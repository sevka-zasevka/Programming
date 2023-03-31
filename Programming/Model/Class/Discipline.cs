class Discipline
{
    private int _numberOfclasses;

    public string Name { get; set; }

    public string TeacherName { get; set; }
    public int NumberOfclasses
    {
        get => _numberOfclasses; 
        set 
        {
            Validator.AssertOnPositiveValue(value, "NumberOfclasses.Discipline");
            _numberOfclasses = value; 
        }
    }

    public Discipline()
    { 

    }

    public Discipline(string name, string teacherName, int numberOfclasses)
    {
        Name = name;
        TeacherName = teacherName;
        NumberOfclasses = numberOfclasses;
    }
    
}
