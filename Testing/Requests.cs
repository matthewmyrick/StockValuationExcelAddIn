using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Testing
{
    public class Requests
    {

        public async Task<string> test()
        {
            var client = new HttpClient();
            String responseString = await client.GetStringAsync("https://financialmodelingprep.com/api/v3/historical-price-full/AAPL?timeseries=5&apikey=7e0134732ec908ce5bc75bc77a64c8a2");
            Console.WriteLine(responseString);
            return responseString;
        }
    }
}
