class Products
{
    int id;
    String name;
    double price;

    public static void Main(string[] args)
    {
        List<Products> products = new List<Products>();
        products.Add(new Products { id = 1, name = "Keyboard", price = 350.00 });
        products.Add(new Products { id = 2, name = "Mouse", price = 180.00 });
        products.Add(new Products { id = 3, name = "Monitor", price = 2200.00 });
        double maxprice;
        maxprice = -9999;
        foreach (var product in products)
        {
            if (product.price > maxprice)
            {
                maxprice = product.price;
            }
            Console.WriteLine($"ID: {product.id}, Name: {product.name}, Price: {product.price}");
        }
        Console.WriteLine($"Maximum price: {maxprice}");
    }
}
