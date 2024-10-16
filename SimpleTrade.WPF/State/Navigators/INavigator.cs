﻿using SimpleTrade.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleTrade.WPF.State.Navigators
{
    public enum ViewType
    {
        Home,
            Portfolio
    }
    public interface INavigator
    {

        ViewModelBase CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get;  }
    }
}
