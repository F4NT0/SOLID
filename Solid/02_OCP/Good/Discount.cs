namespace Solid._02_OCP.Good;

// Se eu puder fazer var discount = new Discount(); significa que criei um desconto genérico
// que vai ter que tomar decisões internas que fica ruim para mim.
// por isso ela se torna abstrata para evitar a chamada genérica dela.
public abstract class Discount
{
    public abstract decimal Calculator(decimal price); // Se o método é abstrata, ela pode ser chamada em outras 
}