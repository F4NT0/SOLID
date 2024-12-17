// EXEMPLO DE OCP (Open/Closed Principle)
using System;
using Solid._02_OCP.Good;

// Exemplo 1 - Criar um novo desconto específico e calcular ele
var discount = new DiscountEletronics();
Console.WriteLine(discount.Calculator(100m));

// Exemplo 2: Criar um Discount do abstrato vazio e depois definir o tipo
Discount discount2;
discount2 = new DiscountBeauty();
Console.WriteLine(discount2.Calculator(100m));