class Program
{
    static void Main() 
    {
        while (true)
        {
            try
            {
                Console.Write("Insira um número Inteiro: ");
                int numero = int.Parse(Console.ReadLine());

                Console.WriteLine($"O número digitado foi: {numero}");
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nValor Inválido. Por favor, insira um número inteiro válido.\n");
            }
        }
    }
}