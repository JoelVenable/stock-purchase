# Advanced Challenge: Stock Purchase Report

### Setup

```
mkdir -p ~/workspace/csharp/exercises/stocks && cd $_
dotnet new console
```

### Instructions

A block of publicly traded stock has a variety of attributes, we'll look at a few of them. A stock has a ticker symbol and a company name. Create a simple dictionary with ticker symbols and company names in the `Main` method.

##### Example

```cs
Dictionary<string, string> stocks = new Dictionary<string, string>();
stocks.Add("GM", "General Motors");
stocks.Add("CAT", "Caterpillar");
// Add a few more of your favorite stocks
```

To find a value in a Dictionary, you can use square bracket notation much like JavaScript object key lookups.

```cs
string GM = stocks["GM"];   <--- "General Motors"
```

Next, create a data structure to record how many stock purchases were made for each company over time. In this Dictionary, the key will be the ticker symbol, and the value will be a collection of numbers representing how much the investor paid.

#### JavaScript Equivalent

```js
{
    "AAPL": [1214.90, 2881.95],
    "GM": [4892.12],
    "MSFT": [934.21, 9025.23, 4013.89],
    "TWTR": [180.44, 298.01, 9092.45],
}
```

How would you define this structure using C# data types? Once you've determined how to define the data structure, you need to add purchases for a few companies. Start with three companies, and 1-3 purchases for each one.

Once you've added your stocks and purchases, produce a total ownership report that computes the total amount of money spent by the investor on each stock. Note that the final report has the full company name, not the ticker symbol. You must use the ticker symbol and square bracket notation to get the full company name from the `stocks` Dictionary.

This is the basic relational database join algorithm between two tables.

![stock report output](./images/stock-report-output.gif)

```cs
Dictionary<string, string> stocks = new Dictionary<string, string>();
stocks.Add("GM", "General Motors");
// Add a few more of your favorite stocks

foreach (var stock in portfolio)
{
    Console.WriteLine($"Investor has spent a total of {total spend} on the stock for {display the full business name}");
}
```
