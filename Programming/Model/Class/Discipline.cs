/// <summary>
/// Класс, хранящий номер аудитории, название предмета и фамилию педагога.
/// /// </summary>
class Discipline
{
    /// <summary>
    /// Номер аудитории, только позитивное значение.
    /// </summary>
    private int _numberOfclasses;

    /// <summary>
    /// Возвращает и задает название дисциплины.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Возвращает и задает фамилию педпгога.
    /// </summary>
    public string TeacherSurname { get; set; }

    /// <summary>
    /// Возвращает и задает аудиторию, только положительное значение.
    /// </summary>
    public int NumberOfclasses
    {
        get => _numberOfclasses; 
        set 
        {
            Validator.AssertOnPositiveValue(value, "NumberOfclasses.Discipline");
            _numberOfclasses = value; 
        }
    }

    /// <summary>
    /// Создает пустой экземпляр класса <see cref="Discipline">.
    /// </summary>
    public Discipline()
    { 

    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Discipline">.
    /// </summary>
    /// <param name="name"> Название дисциплины.</param>
    /// <param name="teacherName">Фамилия педагога. </param>
    /// <param name="numberOfclasses">Номер аудитории, только положительное значение.</param>
    public Discipline(string name, string teacherName, int numberOfclasses)
    {
        Name = name;
        TeacherSurname = teacherName;
        NumberOfclasses = numberOfclasses;
    }
    
}
