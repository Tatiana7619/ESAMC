using System.Data;
using System.Reflection.Metadata.Ecma335;

class ContaBancaria
{
    private decimal saldo;

    public ContaBancaria()
    {
        saldo = 1000;
    }
    public decimal Saldo
    {
        get{

            return saldo;
        }

        set{ 
            throw new ArgumentException("Saldo não pode ser alterado");
           }
            
    }  
    
}

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria conta = new ContaBancaria();
        Console.WriteLine("Saldo inicial: " + conta.Saldo);
        try
        {
            conta.Saldo = 100;
            Console.WriteLine("Saldo após depósito: " + conta.Saldo);
            conta.Saldo = -50; // Isso deve lançar uma exceção
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }
}
