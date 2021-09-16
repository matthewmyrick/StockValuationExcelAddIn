using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Testing
{
    public class Program
    {
        public static Database database = new Database();
        public static Requests requests = new Requests();
        static void Main(string[] args)
        {
            string test = requests.test().Result;
            DataStructuresTest.HistoricalPricesWrapper testList = JsonConvert.DeserializeObject<DataStructuresTest.HistoricalPricesWrapper>(test);
            Console.WriteLine(testList.symbol);
            Console.WriteLine(testList.historical);
            /*            foreach (var i in testList.historical)
                        {

                        }*/
        }
    }
}
