using System;
using System.Windows.Input;


namespace FamilyBudgetSilverlightApp.ViewModel
{
    public class Command : ICommand
    {
        public Command(Action action)
        {
            executeDelegate = action;
            canExecuteDelegate = () => true;
        }

        public Command(Action action, Func<bool> func)
        {
            executeDelegate = action;
            canExecuteDelegate = func;
        }


        private Func<bool> canExecuteDelegate;
        private Action executeDelegate;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object param)
        {
            if (canExecuteDelegate != null)
            {
                return canExecuteDelegate();
            }
            return true;
        }

        public void Execute(object param)
        {
            executeDelegate();
        }
    }
}
