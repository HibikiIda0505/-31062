using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static 卒業制作_31062.WetherData;

namespace 卒業制作_31062
{
    class OwmApi
    {
        public string ApiKey { get; private set; }
        public string EndPointUrl { get; private set; }
        public string Json { get; private set; }

        public OwmApi(string apiKey)
        {
            ApiKey = apiKey;

        }

        public OwmApi()
        {
            EndPointUrl = "http://api.openweathermap.org/data/2.5/weather?zip=371-0026,jp&appid=bfe7b4b14827e0da6384743c71b50195";
        }

        public Root GetWeather()
        {
            var parm = new Dictionary<string, string>();
            parm["main"] = "Weather";
            parm["apiKey"] = "ApiKey";

            var url = EndPointUrl;
                
            // JSON-DLを取得する
            var client = new WebClient()
            {
                Encoding = System.Text.Encoding.UTF8
            };
            Json = client.DownloadString(url);

            return JsonConvert.DeserializeObject<Root>(Json);
        }
    }
}
