/// <summary>
/// Класс, хранящий продолжительность полета в минутах, пункт отправления и пункт прибытия.
/// </summary>
class Flight
{
    /// <summary>
    /// Продолжительность полета  минутах.
    /// </summary>
    private int _flightTimeInMinutes;

    /// <summary>
    /// Возвращает и задает пункт отправления.
    /// </summary>
    public string DeparturePoint { get; set; }

    /// <summary>
    /// Возвращает и задает пункт прибытия.
    /// </summary>
    public string Destination { get; set; }

    /// <summary>
    /// Возвращает и задает продолжительность полета в минутах, только положительное значение.
    /// </summary>
    public int FlightTimeInMinutes
    {
        get => _flightTimeInMinutes; 
        set 
        {
            Validator.AssertOnPositiveValue(value, "FlightTimeInMinutes.Flight");
            _flightTimeInMinutes = value; 
        }
    }

    /// <summary>
    /// Создает пустой экземпляр класса <see cref="Flight">
    /// </summary>
    public Flight()
    { 

    }

    /// <summary>
    /// Создает экземпляр класса <see cref="Flight">.
    /// </summary>
    /// <param name="departurePoint">Пункт отправления.</param>
    /// <param name="destination"> Пункт назначения.</param>
    /// <param name="flightTimeInMinutes">Продолжительность полета в минутах, только положительное значение.</param>
    public Flight(string departurePoint, string destination, int flightTimeInMinutes)
    {
        DeparturePoint = departurePoint;
        Destination = destination;
        FlightTimeInMinutes = flightTimeInMinutes;
    }
}
