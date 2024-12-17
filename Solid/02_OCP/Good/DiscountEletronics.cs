namespace Solid._02_OCP.Good;

public class DiscountEletronics : Discount
{
    public override decimal Calculator(decimal price) => price * 0.1m;
}