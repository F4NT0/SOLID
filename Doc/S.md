# Single Responsibility Principle (SRP)

Uma classe deve ter apenas uma responsabilidade e uma única funcionalidade, um propósito mais claro e direto.

## Benefícios

---

- **Manutenção facilitada**: Classes com uma responsabilidade específica são mais fáceis de entender e modificar
- **Reutilização e Testes**: Classes focadas em uma única responsabilidade são mais reutilizáveis e fáceis de testar.

## Má prática

---

Uma classe que lida com lógica de negócios e também se encarrega de salvar dados no banco

## Exemplo ruim

---

Não devemos ter uma classe que faça mais de uma coisa, cada classe deve ter uma responsabilidade específica.

```csharp
public class Report 
{
    public void Print(){}

    public void Generate(){}

    public void Save(){}
}
```

## Exemplo bom

---

Divida as responsabilidades em classes diferentes:

- No exemplo anterior podemos pegar o **Save** e criar um _Repository_ em nosso projeto que cuida em salvar no banco de dados o projeto.

- No exemplo anterior podemos pegar o **Print** e criar um _Service_ que cuida da lógica de impressão do Report criado.

Com esse Refactor já podemos ver uma melhora em nosso projeto e assim cada classe tem seu próprio arquivo que cuida de uma única questão

```csharp
// Classe PrintService.cs
public class PrintService
{
    public void Print(Report report){...}
}

// Classe ReportRepository.cs
public class ReportRepository
{
    public void Save(Report report){...}
}

// Classe Report
public class Report
{
    public void Generate(){}
}
```

## Revisão

----

__Revisão e Clareza__ = Cada classe tem um propósito claro.

__Redução de Acoplamento__ = Cada classe pode ser alterada sem impactar outras partes desnecessariamente.

__Dica__ = `"Esta classe tem mais de uma funcionalidade?"` Se sim, hora de aplicar o SRP.
