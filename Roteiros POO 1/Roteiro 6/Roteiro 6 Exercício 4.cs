public class IdadeInvalidaException : Exception
{
    public IdadeInvalidaException(string message) : base(message)
    {
    }
}

public class Program
{
    public static void VerificarIdade(int idade)
    {
        if (idade < 18)
        {
            throw new IdadeInvalidaException("Erro: Idade Mínima para acesso é 18 anos.");
        }

        Console.WriteLine("Acesso Permitido!");
    }
    
    public static void Main()
    {
        try
        {
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            
            VerificarIdade(idade);
        }
        catch (FormatException)
        {
            Console.WriteLine("Insira um valor válido!");
        }
        catch(IdadeInvalidaException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}