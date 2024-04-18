using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Model;

namespace View.ViewModel
{
    public class CurrencyVM : ObservableValidator
    {
        Currency Currency = new Currency();

        public string SourceName
        {
            get => Currency.SourceName;
            set => SetProperty(Currency.SourceName, 
                value, Currency, 
                (currency, sourceName) => 
                Currency.SourceName = sourceName, 
                true);
        }

        public string TargetName
        {
            get => Currency.TargetName;
            set => SetProperty(Currency.TargetName,
                value, Currency,
                (currency, targetName) =>
                Currency.TargetName = targetName,
                true);
        }

        public double SourceValue
        {
            get => Currency.SourceValue;
            set => SetProperty(Currency.SourceValue,
                value, Currency,
                (currency, sourceValue) =>
                Currency.SourceValue = sourceValue,
                true);
        }

        public double FinalValue
        {
            get => Currency.FinalValue;
            set => SetProperty(Currency.FinalValue,
                value, Currency,
                (currency, finalValue) =>
                Currency.FinalValue = finalValue,
                true);
        }

        public CurrencyVM(Currency currency) 
        { 
            Currency = currency;
        }
    }
}
