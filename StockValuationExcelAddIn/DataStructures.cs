using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockValuationExcelAddIn
{
    public class DataStructures
    {
        public class DcfHistorical
        {
            public string symbol { get; set; }
            public string date { get; set; }
            public float dcf { get; set; }
        }

        public class HistoricalPricesDaily
        {
            public string symbol { get; set; }
            public string historical { get; set; }
        }
    }
}
