using System;
using System.Collections.Generic;

namespace stock_purchase
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<string, string> stocks = new Dictionary<string, string>();
      stocks.Add("GM", "General Motors");
      stocks.Add("CAT", "Caterpillar");


      var aapl = new KeyValuePair<string, List<double>>("AAPL", new List<double>() {
             1214.90, 2991.95
        });

      var gm = new KeyValuePair<string, List<double>>("GM", new List<double>() {
        4892.12
    });
      var msft = new KeyValuePair<string, List<double>>("MSFT", new List<double>() {
           934.21, 9025.23, 4013.89
    });
      var twtr = new KeyValuePair<string, List<double>>("TWTR", new List<double>() {
        180.44, 298.01, 9092.45
    });
      var stockTrades = new List<KeyValuePair<string, List<double>>>() {
        aapl,
        gm,
        msft,
        twtr
    };


      stockTrades.ForEach(stock =>
      {
        double moneyInvested = 0;  // init to 0
        stock.Value.ForEach(purchase => moneyInvested += purchase);

        Console.WriteLine($"{stock.Key}: ${moneyInvested}");

      });


    }
  }
}
