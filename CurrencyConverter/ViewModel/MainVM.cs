using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using View.Model;

namespace View.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        private string _baseCurrency;

        private string _targetCurrency;

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string[] Currencies  { get; set;} = {"RUB", "USD"};

        public string selectedBaseCurrency 
        { 
            get => _baseCurrency; 

            set
            {
                if(value != _baseCurrency)
                {
                    if (!string.IsNullOrEmpty(_baseCurrency))
                    {
                        _baseCurrency = value;
                        NotifyPropertyChanged();
                    }
                }                     
            }
        }
        public string selectedTargetCurrency
        {
            get => _targetCurrency;

            set
            {
                if (value != _targetCurrency)
                {
                    if (!string.IsNullOrEmpty(_targetCurrency))
                    {
                        _targetCurrency = value;
                        NotifyPropertyChanged();
                    }
                }
            }
        }

        public MainVM() 
        {
            _baseCurrency = "RUB";

            _targetCurrency = "USD";

            //var request = new GetRequest($"https://api.currencyapi.com/v3/latest?apikey=cur_live_mSHf8s7IvElHCuzAKMCm64WvEU4sl2JwwiPBZQ0Y&currencies={_targetCurrency}&base_currency={_baseCurrency}");
            //request.Run();
        }
    }
}
