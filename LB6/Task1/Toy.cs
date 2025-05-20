namespace LB6;

public class Toy : Product
{
    private string ageCategory;
    private string placeOfManufacture;

    public Toy(string productName, string productDescription, double price, string ageCategory,
        string placeOfManufacture)
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
        return base.ToString() + $", Age category: {AgeCategory}, Place of manufacture: {PlaceOfManufacture}";
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Toy other) return false;
        return base.Equals(other) &&
               placeOfManufacture == other.PlaceOfManufacture &&
               ageCategory == other.AgeCategory;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(base.GetHashCode(), AgeCategory, PlaceOfManufacture);
    }
}