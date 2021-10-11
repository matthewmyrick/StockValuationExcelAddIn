using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Net;

namespace StockValuationExcelAddIn
{
    public class Requests
    {
        Config.Urls urls = new Config.Urls();

        // check validity of url
        public static bool HandleUrlError(string url)
        {
            if (url == "String URL Error")
            {
                MessageBox.Show("URL Endpoint Error");
                return false;
            }
            else
            {
                return true;
            }
            
        }


        // Historical Prices Requests 
        public async Task<DataStructures.HistoricalPricesWrapper> HistoricalPrices(string symbol, string timeframe, int limit)
        {
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var client = new HttpClient();
                String URL = urls.HISTORICAL_PRICES(symbol, timeframe, limit);
                String responseString = await client.GetStringAsync(URL);
                DataStructures.HistoricalPricesWrapper response = JsonConvert.DeserializeObject<DataStructures.HistoricalPricesWrapper>(responseString);
                return response;
            }
            catch(HttpRequestException ex)
            {
                string errorMessage = ex.Message +
                        "\nPossible Errors:" +
                        "\n\t- Please check inputs" +
                        "\n\t- API key incorrect please check API settings" +
                        "\n\t- This Data Request is only for preimuim users";
                MessageBox.Show(ex.Message);
                DataStructures.HistoricalPricesWrapper errorList = new DataStructures.HistoricalPricesWrapper();
                return errorList;
            }
        }

        // DCF Request Data
        public async Task<List<DataStructures.DcfHistorical>> DcfRequestHistorical(string symbol, String timeframe, int limit)
        {

            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var client = new HttpClient();
                String URL = urls.DCF_URL_HISTORICAL(symbol, timeframe.Replace(" ", ""), limit);
                bool error = HandleUrlError(URL);
                List<DataStructures.DcfHistorical> errorList = new List<DataStructures.DcfHistorical>();
                MessageBox.Show(errorList.Count().ToString());
                if (false == error)
                {
                    return errorList;
                }
                String responseString = await client.GetStringAsync(URL);
                MessageBox.Show(responseString);
                List<DataStructures.DcfHistorical> responseList = JsonConvert.DeserializeObject<List<DataStructures.DcfHistorical>>(responseString);
                return responseList;
            }
            catch (HttpRequestException ex)
            {
                string errorMessage = ex.Message +
                    "\nPossible Errors:" +
                    "\n\t- Please check inputs" +
                    "\n\t- API key incorrect please check API settings" +
                    "\n\t- This Data Request is only for preimuim users";
                MessageBox.Show(errorMessage);
                List<DataStructures.DcfHistorical> errorList = new List<DataStructures.DcfHistorical>();
                return errorList;
            }

        }
    }
}
