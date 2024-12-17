namespace Solid.Bad;

/**
 * Este é um exemplo ruim porque o Print e Save podem ser um repository
 * Não precisando ter que o Report criar um método para isso
 */
public class Report
{
    public void Print()
    {
    }

    public void Generate()
    {
    }

    public void Save()
    {
    }
}