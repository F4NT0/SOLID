# Open Closed Principle (OCP)

---

Afirmação desse princípio é "Aberta para extensão, mas fechado para modificação".

## Benefícios

---

- __Facilidade de Extensão__: Novas funcionalidades podem ser adicionadas sem alterar o código existente.

- __Redução de Bugs__: Minimiza o risco de introduzir erros em funcionalidades já implementadas.

## Mau Exemplo

---

__Problema__: Adicionar um novo tipo de produto, como "Alimentos", precisamos modificar a classe Discount, violando o OCP.

```csharp
public class Discount
{
    public double Discount(string productType, double value)
    {
        if (productType == "Eletronico")
        {
            return value * 0.1;
        }
        else if (productType == "Roupas")
        {
            return value * 0.2;
        }
        else {
            return 0;
        }
    }
}
```

## Bom Exemplo

---

Devemos utilizar o __Polimorfismo__ de Orientados a Objetos para estender o comportamento sem modificar a classe base.

__Solução__: Novos tipos de desconto podem ser adicionados criando novas classes, sem modificar a classe Discount original.

```csharp
// Classe principal abstrata (não pode ser instanciada)
// As outras classes herdam dela (herança)
public abstract class Discount
{
    public abstract double Calculator(double value);
}

// Classe do tipo Eletronico
public class DiscountEletronico : Discount // estendendo a classe no C#
{
    public override double Calculator(double value) => value * 0.1;
}

// Classe do tipo Roupas
public class DiscountRoupas : Discount
{
    public override double Calculator(double value) => value * 0.2;
}

// Caso queira adicionar o Alimentos
public class DiscountAlimentos : Discount
{
    public override double Calculator(double value) => value * 0.5;
}
```

Podemos chamar qualquer uma das classes criadas no _Program.cs_ para fazer o cálculo como mostra o seguinte exemplo:

```csharp
// Chamando direto o Eletronics
var discount = new DiscountEletronics();
Console.WriteLine(discount.Calculator(100m)); // 10.0


// Criando um objeto genérico e depois definindo ele
Discount discount;
discount = new DiscountBeauty();
Console.WriteLine(discount2.Calculator(100m)); // 30.0
```

## Revisão

---

- __Grande facilidade de manutenção__: Código já existente não é alterado, evitando a introdução de novos bugs.

- __Extensibilidade__: Novos comportamentos são adicionados por meio de novas classes.

- __Dica__: Pense em como tornar o código extensível. A adição de novas funcionalidades não deve significar modificar código existente.
