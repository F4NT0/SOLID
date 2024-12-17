namespace Solid._02_OCP.Good;

public class DiscountFashion : Discount
{
    public override decimal Calculator(decimal price) => price * 0.5m;
}