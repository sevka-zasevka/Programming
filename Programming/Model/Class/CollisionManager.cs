namespace Programming.Model.Class
{
    /// <summary>
    /// Класс для определения пересечения прямоугольников и колец.
    /// </summary>
    public static class CollisionManager
    {
        /// <summary>
        /// Метод определяющий пересечение прямоугольников.
        /// </summary>
        /// <param name="rectangle1">Первый прямоугольник, объект класса <see cref="Rectangle">.</param>
        /// <param name="rectangle2">Второй прямоугольникобъект класса <see cref="Rectangle">.</param>
        /// <returns>Вщзвращает true, если первый и второй прямоугольники пересекаются, и возвращает False, если они не пересекаются.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double sumWidth = Math.Abs(rectangle1.Width + rectangle2.Width) / 2;
            double sumLeght = Math.Abs(rectangle1.Length + rectangle2.Length) / 2;
            int dx = Math.Abs(rectangle1.Centre.X - rectangle2.Centre.X);
            int dy = Math.Abs(rectangle1.Centre.Y - rectangle2.Centre.Y);

            return dx < sumWidth && dy < sumLeght;
        }

        /// <summary>
        /// Метод определюющий пересечение колец
        /// </summary>
        /// <param name="ring1">Первое кольцо, объект класса <see cref="Ring"></param>
        /// <param name="ring2">Второе кольцо, объект класса <see cref="Ring"></param>
        /// <returns>Возвращает true, если первое и второе кольца пересекаются, и возвращает false, если они не пересекаются.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            int forx = Math.Abs(ring1.Centre.X - ring2.Centre.X);
            int fory = Math.Abs(ring1.Centre.Y - ring2.Centre.Y);
            double c = Math.Sqrt(fory ^ 2 + forx ^ 2);

            return c < ring1.OuterRadius + ring2.OuterRadius;
        }
    }
}
