using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.ViewModel
{
    public partial class DataAPI : ObservableObject
    {
        public string PriceBaseCurrency { get; set; }


        public string PriceTargetCurrency { get; set; }

        public void Go(string selectedTargetCurrency, string selectedBaseCurrency)
        {
            var request = new GetRequest($"https://api.currencyapi.com/v3/latest?apikey=cur_live_mSHf8s7IvElHCuzAKMCm64WvEU4sl2JwwiPBZQ0Y&currencies={selectedTargetCurrency}%2C{selectedBaseCurrency}&base_currency={selectedBaseCurrency}");
            request.Run();

            var response = request.Response;

            var json = JObject.Parse(response);

            var data = json["data"];

            var baseCurrency = data[$"{selectedBaseCurrency}"];

            PriceBaseCurrency = baseCurrency["value"].ToString();

            var targetCurrency = data[$"{selectedTargetCurrency}"];

            PriceTargetCurrency = targetCurrency["value"].ToString();

        }
    }
}
