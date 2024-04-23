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
    public partial class MainVM : ObservableObject
    {
        [ObservableProperty]
        private string _baseCurrency;

        [ObservableProperty]
        private string _targetCurrency;

        public string[] Currencies  { get; set;} = {"RUB", "USD", "EUR", "BTC"};

        [ObservableProperty]
        private string _priceBaseCurrency;

        [ObservableProperty]
        private string _priceTargetCurrency;

        public MainVM() 
        {
            BaseCurrency = "USD";
            TargetCurrency = "RUB";
        }

        [RelayCommand]
        private void Apply()
        {
            var dataAPI = new DataAPI();
            dataAPI.Go(TargetCurrency, BaseCurrency);
            PriceBaseCurrency = dataAPI.PriceBaseCurrency.ToString();
            PriceTargetCurrency = dataAPI.PriceTargetCurrency.ToString();
        }
    }
}
