using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    public class DataStructuresTest
    {
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
/*            public float unadjustedVolume { get; set; }
            public float change { get; set; }
            public float changePercent { get; set; }
            public float vwap { get; set; }
            public string label { get; set; }
            public float changeOverTime { get; set; }*/
        }
    }
}
