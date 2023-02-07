using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace WeatherStack
{
    public class HttpHelper
    {
        public string JSON_Convert(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            var response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            var json = reader.ReadToEnd();
            return json;
        }
    }
}
