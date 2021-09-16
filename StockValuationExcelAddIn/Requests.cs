using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace StockValuationExcelAddIn
{
    public class Requests
    {
        Config.Urls urls = new Config.Urls();

        // Historical Prices Requests 
        public async Task<List<DataStructures.DcfHistorical>> HistoricalPricesDaily(string symbol, String timeframe, int limit)
        {
            try
            {
                var client = new HttpClient();
                String URL = urls.HISTORICAL_PRICES_DAILY(symbol, limit);

                String responseString = await client.GetStringAsync(URL);
                List<DataStructures.DcfHistorical> responseList = JsonConvert.DeserializeObject<List<DataStructures.DcfHistorical>>(responseString);
                return responseList;
            }
            catch
            {
                MessageBox.Show("Error Getting Data.");
                List<DataStructures.DcfHistorical> errorList = new List<DataStructures.DcfHistorical>();
                return errorList;
            }
        }

        // DCF Request Data
        public async Task<List<DataStructures.DcfHistorical>> DcfRequestHistorical(string symbol, String timeframe, int limit)
        {
            try
            {
                var client = new HttpClient();
                String URL = urls.DCF_URL_HISTORICAL(symbol, timeframe, limit);

                String responseString = await client.GetStringAsync(URL);
                List<DataStructures.DcfHistorical> responseList = JsonConvert.DeserializeObject<List<DataStructures.DcfHistorical>>(responseString);
                return responseList;
            }
            catch
            {
                MessageBox.Show("Error Getting Data.");
                List<DataStructures.DcfHistorical> errorList = new List<DataStructures.DcfHistorical>();
                return errorList;
            }

        }
    }
}
