namespace LB6;

public class Toy : Product
{
    private string ageCategory;
    private string placeOfManufacture;

    public Toy(string productName, string productDescription, double price, string ageCategory, string placeOfManufacture)
    : base(productName, productDescription, price)
    {
        this.ageCategory = ageCategory;
        this.placeOfManufacture = placeOfManufacture;
    }
    public string AgeCategory
    {
        get => ageCategory;
        set => ageCategory = value;
    }

    public string PlaceOfManufacture
    {
        get => placeOfManufacture;
        set => placeOfManufacture = value;
    }

    public override string ToString()
    {
        return base.ToString() + $", Age category: {AgeCategory}, Place of manufacture: {PlaceOfManufacture}";;
    }
}