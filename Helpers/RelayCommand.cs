using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace datacollection.Helpers
{
    /// <summary>
    /// 一个简单的继电器命令实现，适用于 WPF 中的绑定场景。
    /// </summary>
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;

        /// <summary>
        /// 构造函数：无参数限制版本
        /// </summary>
        /// <param name="execute">执行动作</param>
        public RelayCommand(Action<object> execute) : this(execute, null) { }

        /// <summary>
        /// 构造函数：带是否可以执行的判断逻辑
        /// </summary>
        /// <param name="execute">执行动作</param>
        /// <param name="canExecute">是否允许执行的条件判断</param>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        #region ICommand Members

        bool ICommand.CanExecute(object parameter) => _canExecute == null || _canExecute(parameter);

        void ICommand.Execute(object parameter) => _execute(parameter);

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        #endregion
    }
}
