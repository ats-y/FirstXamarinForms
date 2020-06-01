using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebServiceTutorial
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// RESTサービス。
        /// 本クラスから外部RESTサービスにアクセスするために利用する。
        /// </summary>
        private readonly RestService _restService;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainPage()
        {
            InitializeComponent();

            // RESTサービスを生成。
            _restService = new RestService();
        }

        /// <summary>
        /// GET WEATHERボタンクリックのイベントハンドラ
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cityEntry.Text))
            {
                // 画面で入力された内容にあった天気情報を取得するURIを作成する。
                string uri = GenerateRequestUri(Constants.OpenWeatherMapEndpoint);

                // 作成したURIで天気を取得する。
                WeatherData weatherData = await _restService.GetWeatherDataAsync(uri);

                // 取得した天気を画面に表示する。
                BindingContext = weatherData;
            }
        }

        /// <summary>
        /// 指定した場所の天気を取得するURIを作成する。
        /// </summary>
        /// <param name="endpoint">REST APIエンドポイント</param>
        /// <returns>天気を取得するAPI</returns>
        private string GenerateRequestUri(string endpoint)
        {
            string requestUri = endpoint;
            //requestUri += $"?q={cityEntry.Text}";
            requestUri += $"?q=";
            requestUri += cityEntry.Text; // Entryに入力された都市名の文字列を連結。
            requestUri += "&units=imperial"; // or units=metric
            //requestUri += $"&APPID={Constants.OpenWeatherMapAPIKey}";
            requestUri += $"&APPID=";
            requestUri += Constants.OpenWeatherMapAPIKey;

            Debug.WriteLine($"Request URI:{requestUri}");
            return requestUri;
        }
    }
}
