using System.Windows.Input;

/// <summary>
/// 
/// </summary>
public class RelayCommand : ICommand
{
    /// <summary>
    /// Делегат команды.
    /// </summary>
    private Action<object> execute;

    /// <summary>
    /// Делегат проверки возможности выполнения команды.
    /// </summary>
    private Func<object, bool> canExecute;

    /// <summary>
    /// Событие интерфейса ICommand 
    /// (подписывается на событие при создании 
    /// и отписывается от него при удалении)
    /// </summary>
    public event EventHandler CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }

    /// <summary>
    /// Конструктор класса <see cref="RelayCommand"/>.
    /// </summary>
    /// <param name="execute">Делегат команды.</param>
    /// <param name="canExecute">Делегат функции проверки 
    /// возможности выполнения</param>
    public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
    {
        this.execute = execute;
        this.canExecute = canExecute;
    }

    /// <summary>
    /// Метод, проверяющий возможность выполнения команды.
    /// </summary>
    /// <param name="parameter">Объект, которые несет в себе смысл можно или нет.</param>
    /// <returns>Булевое значение можно выполнить команду или нет.</returns>
    public bool CanExecute(object parameter)
    {
        return this.canExecute == null || this.canExecute(parameter);
    }

    /// <summary>
    /// Метод, выполняет команду.
    /// </summary>
    /// <param name="parameter">Объект(команда).</param>
    public void Execute(object parameter)
    {
        this.execute(parameter);
    }
}