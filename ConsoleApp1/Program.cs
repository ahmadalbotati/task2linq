using static ListGenerators;
var b1 = ProductList.OrderByDescending(p => p.UnitPrice).Take(3);
foreach (var p in b1)
    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

var b2 = ProductList.Skip(5).Take(5);
foreach (var p in b2)
    Console.WriteLine(p.ProductName);

var b3 = ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25);
foreach (var p in b3)
    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

var b4 = ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);
Console.WriteLine(b4);

int[] ids = { 3, 9, 13, 18 };
var b5 = ids.Contains(9);
Console.WriteLine(b5);

var b6 = ProductList.GroupBy(p => p.Category);
foreach (var g in b6)
    Console.WriteLine($"{g.Key} - {g.Count()}");

var b7 = ProductList.GroupBy(p => p.Category);
foreach (var g in b7)
{
    Console.WriteLine(g.Key);
    foreach (var name in g.Select(p => p.ProductName))
        Console.WriteLine(name);
}

var b8 = ProductList.GroupBy(p => p.Category).Where(g => g.Count() > 3).Select(g => g.Key);
foreach (var c in b8)
    Console.WriteLine(c);

var b9 = from c in CustomerList
         group c by c.Country into g
         select new { Country = g.Key, Count = g.Count(), TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total)) };
foreach (var item in b9)
    Console.WriteLine($"{item.Country} - {item.Count} - {item.TotalOrderValue}");

var b10 = ProductList.Sum(p => p.UnitsInStock);
Console.WriteLine(b10);

var min = ProductList.Min(p => p.UnitPrice);
var max = ProductList.Max(p => p.UnitPrice);
Console.WriteLine($"{min} - {max}");

var b12 = ProductList.Select(p => p.Category).Distinct();
foreach (var c in b12)
    Console.WriteLine(c);

int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
int[] setB = { 3, 6, 9, 12, 15, 13 };
var b13 = setA.Except(setB);
foreach (var n in b13)
    Console.WriteLine(n);

string[] list1 = { "Germany", "France", "UK", "Spain" };
string[] list2 = { "france", "SPAIN", "Italy" };
var b14 = list1.Except(list2, StringComparer.OrdinalIgnoreCase);
foreach (var c in b14)
    Console.WriteLine(c);

var dict = ProductList.ToDictionary(p => p.ProductID);
Console.WriteLine(dict[18]);

var b16 = ProductList.First(p => p.UnitPrice > 50);
Console.WriteLine(b16);

var b17 = ProductList.FirstOrDefault(p => p.UnitPrice > 500);
Console.WriteLine(b17?.ToString() ?? "null");

var b18 = Enumerable.Range(1, 10).Select(i => $"7 x {i} = {7 * i}");
foreach (var row in b18)
    Console.WriteLine(row);

var b19 = Enumerable.Range(1, 30).Where(n => n % 2 == 0);
foreach (var n in b19)
    Console.WriteLine(n);

var b20 = ProductList.Take(3).Select(p => p.ProductName)
    .Concat(CustomerList.Take(3).Select(c => c.CompanyName));
foreach (var s in b20)
    Console.WriteLine(s);

var b21 = ProductList.Zip(CustomerList, (p, c) => $"{p.ProductName} sold to {c.CompanyName}");
foreach (var s in b21)
    Console.WriteLine(s);