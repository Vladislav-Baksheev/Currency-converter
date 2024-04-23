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

        public string Name
        {
            get => Currency.Name;
            set => SetProperty(Currency.Name, 
                value, Currency, 
                (currency, sourceName) => 
                Currency.Name = sourceName, 
                true);
        }

        public CurrencyVM() 
        { 

        }
    }
}
