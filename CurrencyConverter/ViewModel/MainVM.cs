using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json.Linq;
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
    public partial class MainVM : ObservableObject, INotifyPropertyChanged
    {
        [ObservableProperty]
        private string _baseCurrency;

        [ObservableProperty]
        private string _targetCurrency;

        public string[] Currencies  { get; set;} = {"RUB", "USD"};


        private string _priceBaseCurrency;

        private string _priceTargetCurrency;

        public string PriceBaseCurrency 
        {
            get => _priceBaseCurrency;
            set
            {
                _priceBaseCurrency = value;
                OnPropertyChanged();
            }
        }
        
        public string PriceTargetCurrency 
        {
            get => _priceTargetCurrency;
            set
            {
                _priceTargetCurrency = value;
                OnPropertyChanged();
            }
        }

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
            BaseCurrency = "USD";

            TargetCurrency = "RUB";

        }

        [RelayCommand]
        private void Apply()
        {
            var dataAPI = new DataAPI();
            dataAPI.Go(selectedTargetCurrency, selectedBaseCurrency);
            PriceBaseCurrency = dataAPI.PriceBaseCurrency;
            PriceTargetCurrency = dataAPI.PriceTargetCurrency;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
