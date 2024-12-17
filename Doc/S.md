# Single Responsibility Principle (SRP)

- Uma classe deve ter apenas uma responsabilidade e uma razão para mudar.

## Benefícios

- **Manutenção facilitada**: Classes com uma responsabilidade específica são mais fáceis de entender e modificar
- **Reutilização e Testes**: Classes focadas em uma única responsabilidade são mais reutilizáveis e fáceis de testar.

## Má prática

- Uma classe que lida com lógica de negócios e também se encarrega de salvar dados no banco

## Exemplo ruim

Não devemos ter uma classe que faça mais de uma coisa, cada classe deve ter uma responsabilidade específica.

```csharp
public class Relatorio 
{
    public void GeraRelatorio()
    {
        // ...
    }

    public void SalvaRelatorio()
    {
       // ...
    }
}
```

## Exemplo bom

Divida as responsabilidades em duas classes especializadas

```csharp
// CLASSE DE GERAÇÃO DE RELATÓRIO
public class GeraRelatorio
{
    public string Gerar()
    {
        // ...
    }
}

// CLASSE DE SALVAMENTO DE RELATÓRIO
public class SalvaRelatorio
{
    public void Salvar()
    {
        // ...
    }
}
```
