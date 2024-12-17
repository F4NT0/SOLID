namespace Solid._02_OCP.Good;

public class DiscountHealth : Discount
{
    public override decimal Calculator(decimal price) => price * 0.2m;
}