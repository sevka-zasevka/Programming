namespace Programming.Model.Class
{
    /// <summary>
    /// Класс, хранящий длину, ширину, цвет, координаты центра и уникальный идентификатор прямоугольника.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Счетчик всех созданных прямоугольников
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Длина прямоугольника, только положительное значение.
        /// </summary>
        private int _length;

        /// <summary>
        /// Ширина прямоугольника, только положительное значение.
        /// </summary>
        private int _width;

        /// <summary>
        /// Возвращает и задает длину прямоугольника, только положительное значение.
        /// </summary>
        public int Length
        {
            get => _length;
            set
            {
                Validator.AssertOnPositiveValue(value, "Length.Rectangle");
                _length = value;
            }
        }

        /// <summary>
        /// Возвращает и задает ширину прямоугольника, только положительное значение.
        /// </summary>
        public int Width
        {
            get => _width;
            set
            {
                Validator.AssertOnPositiveValue(value, "Width.Rectangle");
                _width = value;
            }
        }


        /// <summary>
        /// Возращает и задает цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает и задает координаты центра прямоугольника, класс <see cref="Point2D">
        /// </summary>
        public Point2D Centre { get; set; }

        /// <summary>
        /// Возвращает количество созданных экземпляров класса <see cref="Rectangle">
        /// </summary>
        public static int AllRectanglesCount => _allRectanglesCount;

        /// <summary>
        /// Возращает уникальный индентификатор прямоугольника.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Rectangle">
        /// </summary>
        public Rectangle()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle">
        /// </summary>
        /// <param name="length">Длина прямоугольника, только положительные значения.</param>
        /// <param name="width">Ширина прямоугольника, только положительное значение.</param>
        /// <param name="color">Цвет прямоугольника.</param>
        /// <param name="x">Координата центра прямоугольника по x, только полодительные значения.</param>
        /// <param name="y">Координата центра прямоуглольника по y, только полодительные значения.</param>
        public Rectangle(int length, int width, string color, int x, int y)
        {
            Length = length;
            Width = width;
            Color = color;
            Centre = new Point2D(x, y);
            _allRectanglesCount++;
            Id = AllRectanglesCount;
        }
    }
}