namespace LB6;

public class Product
{
    private string productName;
    private string productDescription;
    private double price;

    public Product(string productName, string productDescription, double price)
    {
        this.productName = productName;
        this.productDescription = productDescription;
        this.price = price;
    }

    public Product()
    {
        productName = "Noname";
        productDescription = "Noname";
        price = 0.0;
    }
    public string ProductName
    {
        get => productName;
        set => productName = value;
    }

    public string ProductDescription
    {
        get => productDescription;
        set => productDescription = value;
    }

    public double Price
    {
        get => price;
        set => price = value;
    }

    public override string ToString()
    {
        return $"Product: {ProductName}, Description: {ProductDescription}, Price: {Price:C2}";
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Product other)
            return false;

        return ProductName == other.ProductName &&
               ProductDescription == other.ProductDescription &&
               Price == other.Price;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(ProductName, ProductDescription, Price);
    }
}