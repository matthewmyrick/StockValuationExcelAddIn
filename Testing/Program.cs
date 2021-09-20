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
            DataStructuresTest.HistoricalPricesWrapper testList = requests.test().Result;

            Console.WriteLine(testList.symbol);
            foreach (var i in testList.historical)
            {
                Console.WriteLine(i.close);
            }
            /*            Console.WriteLine(testList.historical);*/
        }
    }
}
