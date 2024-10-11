using SimpleTrade.WPF.State.Navigators;
using SimpleTrade.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleTrade.WPF.Commands
{
    public class UpdatedCurrentViewModelCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private INavigator _navigator;
        public UpdatedCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
           if(parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;
                switch (viewType)
                {
                    case ViewType.Home:
                        _navigator.CurrentViewModel = new HomeViewModel();
                        break;
                    case ViewType.Portfolio:
                        _navigator.CurrentViewModel = new PortfolioViewModel();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
