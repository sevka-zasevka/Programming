namespace Programming.Model.Class
{
    /// <summary>
    /// Класс, хранящий внешний и внутренний радиусы, координаты центра и уникальный индентификатор кольца.
    /// </summary>
    public class Ring
    {

        /// <summary>
        /// Счетчик всех созданных экземпляров класса <see cref="Ring">
        /// </summary>
        private static int _allRingsCount;

        /// <summary>
        /// Внешний радиус кольца, только положительные значения. Должен быть больше внутреннего радиуса. 
        /// </summary>
        private int _outerRadius;

        /// <summary>
        /// Внутренний радиус кольца, только положительные значания. Должен быть меньше внешнего радиуса.
        /// </summary>
        private int _innerRadius;

        /// <summary>
        /// Возвращает и задает внешний радиус кольца, только положительные значения и больше внутреннего радиуса.
        /// </summary>
        public int OuterRadius
        {
            get => _outerRadius;
            set
            {
                Validator.AssertValueInRange(value, InnerRadius++, int.MaxValue, "OuterRadius.Ring");
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задает внутренний радиус кольца, только полодительные значения и меньше внешнего радиуса.
        /// </summary>
        public int InnerRadius
        {
            get => _innerRadius;
            set
            {
                Validator.AssertValueInRange(value, 1, OuterRadius--, "OuterRadius.Ring");
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Координаты центра кольца, реализовано через класс <see cref="Point2D">.
        /// </summary>
        public Point2D Centre { get; set; }

        /// <summary>
        /// Возвращает количество всех созданных экземпляров класса <see cref="Ring">.
        /// </summary>
        public static int AllRingsCount => _allRingsCount;

        /// <summary>
        /// Возвращает значение уникального индентификатора кольца.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Метод, считающий площадь кольца.
        /// </summary>
        /// <param name="ring">Кольцо <see cref="Ring">.</param>
        /// <returns>Площадь кольца.</returns>
        private static double Area(Ring ring)
        {
            double area = Math.PI * (ring.OuterRadius ^ 2) - Math.PI * (ring.InnerRadius ^ 2);
            return area;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Ring">.
        /// </summary>
        public Ring()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Ring">.
        /// </summary>
        /// <param name="outerRadius">Внешний радиус прямоугольника, положительное значение больше внутреннего радиуса.</param>
        /// <param name="innerRadius">Внутренний радиус прямоугольника, полодительное значение мельше внешнего радиуса.</param>
        /// <param name="x">Координата центра кольца по x, только положительные значения.</param>
        /// <param name="y">Координата центра кольца по y, тольеко положительные значения.</param>
        public Ring(int outerRadius, int innerRadius, int x, int y)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Centre = new Point2D(x, y);
            _allRingsCount++;
            Id = AllRingsCount;
        }
    }
}
