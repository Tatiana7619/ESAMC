class Program
{
    static float ConverterTemperatura(string Converter)
    {
        if (float.TryParse(Converter, out float Celsius))
        {
            return Celsius;
        }

        throw new FormatException("Temperatura inválida.");
    }

    static void Main()
    {
        while (true)
        {
            try
            {
                Console.Write("Insira o valor da temperatura: ");
                string Converter = Console.ReadLine();

                float Temperatura = ConverterTemperatura(Converter);

                Console.WriteLine($"Temperatura: {Temperatura}°C");
                break;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"\nErro: {ex.Message}\n");
                Console.WriteLine("Tente Novamente!\n");
            }
        }
    }
}
