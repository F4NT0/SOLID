namespace Solid._02_OCP.Bad;

// Enum de exemplo
public enum ProductType
{
    Electronics = 1,
    Health = 2,
    Beauty = 3,
    Fashion = 4
}

public class Discount
{
    public decimal Calculator(ProductType productType, decimal price)
    {
        if (productType == ProductType.Electronics)
        {
            return price * 0.2m;
        }

        if (productType == ProductType.Health)
        {
            return price * 0.3m;
        }

        if (productType == ProductType.Fashion)
        {
            return price * 0.4m;
        }

        if (productType == ProductType.Beauty)
        {
            return price * 0.5m;
        }

        return price;
    }
}