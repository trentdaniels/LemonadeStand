using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LemonadeStand
{
    public class WeatherAPI
    {
        // Members
        private int apiForecastedHigh;
        private int apiForecastedLow;
        private int apiTemperature;

        public int ApiForecastedHigh { get => apiForecastedHigh; }
        public int ApiForecastedLow { get => apiForecastedLow; }
        public int ApiTemperature { get => apiTemperature; }


        // Constructors
        public WeatherAPI()
        {
            GetWeather();
        }

        // Methods
        public void GetWeather()
        {
            HttpWebRequest request;
            HttpWebResponse response;
            string responseDataString;

            request = (HttpWebRequest)WebRequest.Create("http://query.yahooapis.com/v1/public/yql?q=select%20item%20from%20weather.forecast%20where%20woeid%20in%20(select%20woeid%20from%20geo.places(1)%20where%20text%3D%22milwaukee%2C%20wi%22)&format=json");
            request.Credentials = CredentialCache.DefaultCredentials;
            response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            responseDataString = streamReader.ReadToEnd();

            JObject json = JObject.Parse(responseDataString);

            //string date = (string)json["query"]["created"];
            apiTemperature = int.Parse((string)json["query"]["results"]["channel"]["item"]["condition"]["temp"]);
            apiForecastedLow = int.Parse((string)json["query"]["results"]["channel"]["item"]["forecast"][0]["low"]);
            apiForecastedHigh = int.Parse((string)json["query"]["results"]["channel"]["item"]["forecast"][0]["high"]);

        }


    }
}
