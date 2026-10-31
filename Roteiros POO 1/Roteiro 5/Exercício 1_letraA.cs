class Program
{
    static void Main()
    {
        for(int i = 0; i<5; i++)
        {
            Console.WriteLine($"Digite o {i + 1} número decimal: ");
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine($"Número original: {num}");
            Console.WriteLine($"Arredondamento Padrão: {Math.Round(num)}");
            Console.WriteLine($"Arredondamento para baixo: {Math.Floor(num)}");
            Console.WriteLine($"Arredondamento para cima: {Math.Ceiling(num)}");
            Console.WriteLine($"Valor com Truncamento: {Math.Truncate(num)}");

        }
    }
}

