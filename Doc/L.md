# Liskov Substitution Principle (LSP)

---



Esse princípio afirma que objetos de uma classe derivada devem poder substituir objetos de sua classe base sem alterar a funcionalidade do programa.



## Benefícios

----



- __Consistência e Confiabilidade__: Classes derivadas devem manter o comportamento esperado da classe base.

- __Polimorfismo Seguro__: Permite que substituições sejam feitas sem quebrar o código.



## Exemplo de violação do LSP

---



O Princípio de Substituição de Liskov (LSP) afirma que objetos de uma classe derivada devem poder substituir objetos de uma classe base sem alterar o comportamento esperado do programa. No exemplo abaixo, temos uma classe `BankAccount` e uma classe derivada `SavingsAccount` que substitui o método `Withdraw`.

```csharp
public class BankAccount
{
    // virtual: posso ou não substituir essa classe
    public virtual void Withdraw(decimal amount)
    {
        // Implementação vazia
    }
}

public class SavingsAccount : BankAccount
{
    public decimal Balance { get; set; }

    public override void Withdraw(decimal amount)
    {
        if (Balance < amount)
        {
            throw new Exception("Insufficient balance");
        }
        Balance -= amount;
        Console.WriteLine($"Withdraw: {amount}");
    }
}
```

### O problema

- A classe `SavingsAccount` altera o comportamento do método `Withdraw` de uma maneira que não é compatível com a classe base `BankAccount`. Se um código espera que `BankAccount` permita saques sem restrições, a substituição por `SavingsAccount` pode causar exceções inesperadas devido ao saldo insuficiente.

- Isso viola o LSP porque `SavingsAccount` não pode ser usada de forma intercambiável com `BankAccount` sem alterar o comportamento esperado do método `Withdraw`.



## Exemplo correto do LSP

---



- Criamos a classe base abstrata com os métodos abstratos:

```csharp
public abstract class BankAccount
{
    public decimal Balance { get; protected set; } // protected evita de alterar o valor
    
    public abstract void Withdraw(decimal amount);
}
```

- Agora criamos a classe derivada de BankAccount:

```csharp
public class SavingsAccount : BankAccount
{
    public override void Withdraw(decimal amount)
    {
        // implementação dessa classe
    }
}
```

### Explicação

- **Classe Base (`BankAccount`)**: É uma classe abstrata que define um método abstrato `Withdraw`. Isso garante que todas as classes derivadas implementem sua própria lógica de saque. O uso de `protected` no `Balance` impede que o saldo seja alterado diretamente fora da classe ou de suas derivadas, mantendo a integridade dos dados.

- **Classe Derivada (`SavingsAccount`)**: Implementa o método `Withdraw` com a lógica específica para contas de poupança. A implementação pode incluir verificações de saldo, taxas de saque, etc.

### Porque é a melhor forma?

Cada classe derivada (`SavingsAccount`) pode ser usada de forma intercambiável com a classe base `BankAccount` sem alterar o comportamento esperado do método `Withdraw`. Isso respeita o LSP, pois qualquer instância de `BankAccount` pode ser substituída por uma instância de `SavingsAccount` sem causar comportamentos inesperados.



### Como podemos chamar essa classe?

No nosso `Program.cs` podemos criar uma instância da classe abstrata e depois definir seu valor a partir de qualquer uma das classes derivadas:

```csharp
BankAccount account;
account = new SavingsAccount();
```

## Revisão

---



- __Confiabilidade__: Evita comportamentos inesperados ao substituir classes base por derivadas.

- __Polimorfismo Correto__: Classes derivadas mantêm o contrato da classe base.

- __Dica__: Certifique-se de que as classes derivadas respeitam o comportamento esperado da classe base.

- __Pergunte-se__: "Essa classe derivada pode realmente substituir a classe base sem problemas?"
