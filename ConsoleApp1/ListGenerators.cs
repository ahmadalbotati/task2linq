public class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }

    public override string ToString() => $"{ProductName} - {Category} - {UnitPrice} - {UnitsInStock}";
}

public class Order
{
    public int OrderID { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Total { get; set; }
}

public class Customer
{
    public string CustomerID { get; set; }
    public string CompanyName { get; set; }
    public string Country { get; set; }
    public List<Order> Orders { get; set; }
}

public static class ListGenerators
{
    public static List<Product> ProductList = new List<Product>
    {
        new Product { ProductID = 1, ProductName = "Chai", Category = "Beverages", UnitPrice = 18m, UnitsInStock = 39 },
        new Product { ProductID = 2, ProductName = "Chang", Category = "Beverages", UnitPrice = 19m, UnitsInStock = 17 },
        new Product { ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments", UnitPrice = 10m, UnitsInStock = 13 },
        new Product { ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments", UnitPrice = 22m, UnitsInStock = 53 },
        new Product { ProductID = 5, ProductName = "Ikura", Category = "Seafood", UnitPrice = 31m, UnitsInStock = 31 },
        new Product { ProductID = 6, ProductName = "Konbu", Category = "Seafood", UnitPrice = 6m, UnitsInStock = 0 },
        new Product { ProductID = 7, ProductName = "Guarana Fantastica", Category = "Beverages", UnitPrice = 4.5m, UnitsInStock = 20 },
        new Product { ProductID = 8, ProductName = "Sasquatch Ale", Category = "Beverages", UnitPrice = 14m, UnitsInStock = 111 },
        new Product { ProductID = 9, ProductName = "Steeleye Stout", Category = "Beverages", UnitPrice = 18m, UnitsInStock = 20 },
        new Product { ProductID = 10, ProductName = "Grandma's Boysenberry Spread", Category = "Condiments", UnitPrice = 25m, UnitsInStock = 120 },
        new Product { ProductID = 11, ProductName = "Gula Malacca", Category = "Condiments", UnitPrice = 19.45m, UnitsInStock = 27 },
        new Product { ProductID = 18, ProductName = "Carnarvon Tigers", Category = "Seafood", UnitPrice = 62.5m, UnitsInStock = 42 }
    };

    public static List<Customer> CustomerList = new List<Customer>
    {
        new Customer { CustomerID = "ALFKI", CompanyName = "Alfreds Futterkiste", Country = "Germany", Orders = new List<Order> { new Order { OrderID = 1, OrderDate = new DateTime(1996, 5, 10), Total = 800m }, new Order { OrderID = 2, OrderDate = new DateTime(1997, 8, 25), Total = 450m } } },
        new Customer { CustomerID = "ANATR", CompanyName = "Ana Trujillo", Country = "Mexico", Orders = new List<Order> { new Order { OrderID = 3, OrderDate = new DateTime(1998, 3, 4), Total = 300m } } },
        new Customer { CustomerID = "BERGS", CompanyName = "Berglunds snabbkop", Country = "Sweden", Orders = new List<Order> { new Order { OrderID = 4, OrderDate = new DateTime(1997, 1, 15), Total = 620m } } },
        new Customer { CustomerID = "BLAUS", CompanyName = "Blauer See Delikatessen", Country = "Germany", Orders = new List<Order> { new Order { OrderID = 5, OrderDate = new DateTime(1998, 6, 1), Total = 150m } } }
    };
}