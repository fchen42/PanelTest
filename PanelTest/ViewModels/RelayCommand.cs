using System;
using System.Windows.Input;

namespace PanelTest.ViewModels
{
    public class RelayCommand : ICommand
    {
        #region Private Members

        private readonly Action _action;

        #endregion

        #region Public Events

        public event EventHandler CanExecuteChanged = (sender, args) => { };

        #endregion

        #region Constructor

        public RelayCommand(Action action)
        {
            _action = action;
        }

        #endregion

        #region Command Methods

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) => _action();

        #endregion

    }
}