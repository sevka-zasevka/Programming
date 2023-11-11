namespace ObjectOrientedPractices.Model
{
    /// <summary>
    /// Перечисление. хранящее статус заказа.
    /// </summary>
    internal enum OrderStatus
    {
        /// <summary>
        /// Новый заказ.
        /// </summary>
        New,
        /// <summary>
        /// Обрабатывается.
        /// </summary>
        Processing,
        /// <summary>
        /// Сщбирается на складе.
        /// </summary>
        Assembly, 
        /// <summary>
        /// Отправлен.
        /// </summary>
        Sent,
        /// <summary>
        /// Доставлен.
        /// </summary>
        Delivered,
        /// <summary>
        /// Возврат.
        /// </summary>
        Returned,
        /// <summary>
        /// Отменен(сo стороны магазина).
        /// </summary>
        Abandoned
    }
}
