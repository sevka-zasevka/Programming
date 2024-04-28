using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Класс для создания команд.
    /// </summary>
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// Поле для хранения команды.
        /// </summary>
        private Action<object> _execute;

        /// <summary>
        /// Поле для хранения значения фунции.
        /// </summary>
        private Func<object, bool> _canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Создает объект класса <see cref="RelayCommand">.
        /// </summary>
        /// <param name="execute">Действие, выполняемое командой.</param>
        /// <param name="canExecute">Условие выполнения команды.</param>
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            this._execute = execute;
            this._canExecute = canExecute;
        }

        /// <summary>
        /// Метод для определения может ли команда выполниться.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <returns>Всегда true</returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Метод выполняет логику команды.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        public void Execute(object parameter)
        {
            this._execute(parameter);
        }
    }
}
