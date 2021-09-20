using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockValuationExcelAddIn
{
    public class DataStructures
    {

        // dcf Historical Prices
        public class DcfHistorical
        {
            public string symbol { get; set; }
            public string date { get; set; }
            public float price { get; set; }
            public float dcf { get; set; }
        }

        // Historical Prices
        public class HistoricalPricesWrapper
        {
            public string symbol { get; set; }
            public List<HistoricalPricesData> historical { get; set; }
        }
        public class HistoricalPricesData
        {
            public string date { get; set; }
            public float open { get; set; }
            public float high { get; set; }
            public float low { get; set; }
            public float close { get; set; }
/*            public float adjClose { get; set; }*/
            public float volume { get; set; }
/*            public float unadjustedVolume { get; set; }*/
/*            public float change { get; set; }
            public float changePercent { get; set; }
            public float vwap { get; set; }
            public string label { get; set; }
            public float changeOverTime { get; set; }*/
        }
    }
}
