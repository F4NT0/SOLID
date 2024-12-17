namespace Solid._02_OCP.Good;

public class DiscountBeauty : Discount
{
    public override decimal Calculator(decimal price) => price * 0.3m;
}