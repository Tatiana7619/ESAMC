class Program
{
    static void Main()
    {
        string produto1 = "Caderno";
        decimal precoP1 = 24.90m;
        int quantidadeP1 = 12;
        
        string produto2 = "Mochila";
        decimal precoP2 = 159.99m;
        int quantidadeP2 = 4;

        string produto3 = "Caneta";
        decimal precoP3 = 3.50m;
        int quantidadeP3 = 25;

        decimal total1 = precoP1 * quantidadeP1;
        decimal total2 = precoP2 * quantidadeP2;
        decimal total3 = precoP3 * quantidadeP3;

        decimal subtotal = total1 + total2 + total3;
        decimal desconto = subtotal * 0.10m;
        decimal totalfinal = subtotal - desconto;

        Console.WriteLine($"Lista de Produtos".PadLeft(43));
        Console.WriteLine(new string('-', 70));

        Console.WriteLine($"{"Produto",-15} {"Preço",15} {"Quantidade",12} {"Total",12}");
        Console.WriteLine(new string('-', 70));

        Console.WriteLine($"{produto1,-15} {precoP1,15:C} {quantidadeP1,10:D4} {total1,15:C}");
        Console.WriteLine($"{produto2,-15} {precoP2,15:C} {quantidadeP2,10:D4} {total2,15:C}");
        Console.WriteLine($"{produto3,-15} {precoP3,15:C} {quantidadeP3,10:D4} {total3,15:C}");

        Console.WriteLine(new string('-', 70));

        Console.WriteLine($"{"Subtotal:",-22}{subtotal,15:N}");
        Console.WriteLine($"Desconto ({0.10m:P}): {desconto,16:F2}");
        Console.WriteLine($"{"Total final:",-22}{totalfinal,15:C}");

        Console.WriteLine(new string('-', 70));
    }
}
