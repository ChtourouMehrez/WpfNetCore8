using SimpleTrade.WPF.Commands;
using SimpleTrade.WPF.Models;
using SimpleTrade.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleTrade.WPF.State.Navigators
{
    public class Navigator : ObservableObject, INavigator
    {
        private ViewModelBase _CurrentviewModel;



        public ViewModelBase? CurrentViewModel
        {
            get
            {
                return _CurrentviewModel;
            }
            set
            {
                if (_CurrentviewModel != value)
                {
                    _CurrentviewModel = value;
                    OnPropertyChanged(nameof(CurrentViewModel));
                }
            }
        }
        public ICommand UpdateCurrentViewModelCommand => new UpdatedCurrentViewModelCommand(this);

        
    }
}
