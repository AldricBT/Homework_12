using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Homework_12.Infrastructure.Commands.Base
{
    internal abstract class Command : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value; //добавляем обработчик событий
            remove => CommandManager.RequerySuggested -= value; //удаляем обработчик событий
        }

        /// <summary>
        /// Проверяет можно ли выполнить команду, если нет то ложь
        /// </summary>
        /// <param _name="parameter"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public abstract bool CanExecute(object parameter);

        public abstract void Execute(object parameter);
    }
}
