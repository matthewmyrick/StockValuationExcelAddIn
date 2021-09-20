using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockValuationExcelAddIn
{
    public class Config
    {
        static Database db = new Database();
        public String BASE_URL = "https://financialmodelingprep.com";
        public class Urls
        {
            static Config config = new Config();
            
            // Historical Prices url Confgis
            public string HISTORICAL_PRICES(string symbol, string timeframe, int limit)
            {
                String API = db.GetApi();
                if (timeframe == "daily")
                {
                    return String.Format(
                        config.BASE_URL + "/api/v3/historical-price-full/{0}?timeseries={1}&apikey={2}", symbol.ToUpper(), limit, API
                        );
                }
                else
                {
                    return "String URL Error";
                }

            }

            // DCF url Configs 
            public String DCF_URL_CURRENT(String symbol)
            {
                String API = db.GetApi();
                return String.Format(
                    config.BASE_URL + "/api/v3/discounted-cash-flow/{0}&apikey={1}", symbol.ToUpper(), API
                    );
            }

            // DCF Historical Prices
            public String DCF_URL_HISTORICAL(String symbol, String timeframe, int limit)
            {
                String API = db.GetApi();
                if (timeframe == "day")
                {
                    return String.Format(
                    config.BASE_URL + "/api/v3/historical-discounted-cash-flow-statement/{0}?limit={1}&apikey={2}",
                    symbol.ToUpper(), limit.ToString(), API
                    );
                }
                else if (timeframe == "quarterly")
                {
                    return String.Format(
                    config.BASE_URL + "/api/v3/historical-discounted-cash-flow-statement/{0}?period=quarter&limit={1}&apikey={2}", 
                    symbol.ToUpper(), limit.ToString(), API);
                }
                else if (timeframe == "yearly")
                {
                    return String.Format(
                    config.BASE_URL + "/api/v3/historical-discounted-cash-flow-statement/{0}?limit={1}&apikey={2}", 
                    symbol.ToUpper(), limit.ToString(), API);
                }
                else
                {
                    return "String URL Error";
                }
            }
        }
    }
}
