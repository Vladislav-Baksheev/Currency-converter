using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.ViewModel
{
    public class MainVM : ObservableObject
    {
        private CurrencyVM _currentCurrency;

        public ObservableCollection<CurrencyVM> Currencies = new ObservableCollection<CurrencyVM>();
    }
}
