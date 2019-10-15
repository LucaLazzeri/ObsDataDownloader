using System;
using System.Net;
using Newtonsoft.Json.Linq;

namespace ObsDataDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string str = client.DownloadString("https://cdn.younow.com/php/api/broadcast/audience/broadcaster=0/channelId=35771221");
            JObject json = JObject.Parse(str);

            Console.WriteLine(json.ToString());

        }
    }
}
