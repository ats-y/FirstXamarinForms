using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebServiceTutorial
{
    /// <summary>
    /// RESTサービスアクセスクラス。
    /// </summary>
    public class RestService
    {
        /// <summary>
        /// RESTサービスに要求をだめに利用するHTTPクライアント。
        /// </summary>
        private HttpClient _client;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public RestService()
        {
            _client = new HttpClient();
        }

        /// <summary>
        /// 天気を取得する。
        /// </summary>
        /// <param name="uri">天気を</param>
        /// <returns>取得した天気データ</returns>
        public async Task<WeatherData> GetWeatherDataAsync(string uri)
        {
            WeatherData weatherData = null;
            try
            {
                // HTTPリクエスト
                HttpResponseMessage response = await _client.GetAsync(uri);

                // HTTP応答が「成功」だったら天気情報を取り出す。
                if (response.IsSuccessStatusCode)
                {
                    // HTTP応答からHTTPコンテンツを文字列で取得する。
                    HttpContent result = response.Content;
                    string content = await result.ReadAsStringAsync();
                    Debug.WriteLine(content);

                    // HTTPコンテンツ文字列（JSON）から
                    // WeatherDataクラスのオブジェクトを生成する。
                    // （JsonをWeatherDataオブジェクトにデシリアライズする）
                    weatherData = JsonConvert.DeserializeObject<WeatherData>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\tERROR {0}", ex.Message);
            }

            return weatherData;
        }
    }
}
