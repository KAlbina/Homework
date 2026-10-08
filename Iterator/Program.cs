using Iterator;

var products = new List<Product>
{
    new Product("Молоко", 2),
    new Product("Кефир", 0),      
    new Product("Сыр", 10),
    new Product("Йогурт", -3),    
    new Product("Яблоки", 5)
};

Console.WriteLine(" отд класс-итератор:");
foreach (Product product in new Fridge(products))
    Console.WriteLine($"  {product.Name}, осталось дней: {product.DaysLeft}");

Console.WriteLine();
Console.WriteLine("yield return:");
foreach (Product product in new FridgeYield(products))
    Console.WriteLine($"  {product.Name}, осталось дней: {product.DaysLeft}");
