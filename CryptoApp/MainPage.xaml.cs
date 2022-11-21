using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using RestSharp;
using CryptoApp.Models;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace CryptoApp
{
    public partial class MainPage : ContentPage
    {
        private string apiKey = "7B81FD69-45E7-473F-B965-59A560E46AC1";
        private string baseImageUrl = "https://s3.eu-central-1.amazonaws.com/bbxt-static-icons/type-id/png_64/";

        public MainPage()
        {
            InitializeComponent();

            //CoinListView.ItemsSource = GetCoins();

            var client = new RestClient("https://rest.coinapi.io/v1/assets");
            var request = new RestRequest(Method.GET);
            request.AddHeader("X-CoinAPI-Key", apiKey);
            IRestResponse response = client.Execute(request);

            Console.WriteLine(response.StatusCode);

        }

        /* private void RefreshButton_Clicked(object sender, EventArgs e)
         {
             CoinListView.ItemsSource = GetCoins();
         }


         private List<CoinDB> GetCoins()
         {
             List<CoinDB> coins;

             var client = new RestClient("https://rest.coinapi.io/v1/assets?filter_asset_id=BTC;ETH;XMR;LTC");
             var request = new RestRequest(Method.GET);
             request.AddHeader("X-CoinAPI-Key", apiKey);

             //IRestResponse response = client.Execute<List<CoinDB>>(request);
             //var CoinDB = response.Data;
            // IRestResponse response = client.Execute(request);

             var response = client.Execute(request);
             //List<CoinDB> coins = JsonConvert.DeserializeObject<List<CoinDB>>(response.Content);

             coins = JsonConvert.DeserializeObject<List<CoinDB>>(response.Content);

             foreach (var coin in coins)
             {
                 if (!String.IsNullOrEmpty(coin.id_icon))
                     coin.id_icon = baseImageUrl + coin.id_icon.Replace("_", "") + "png";
                 else
                     coin.icon_url = "";
             }

             return coins;       
         }*/
    }
}
