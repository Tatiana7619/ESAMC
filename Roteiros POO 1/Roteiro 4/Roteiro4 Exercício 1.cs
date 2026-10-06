public class Veiculo
{
    public string Marca;
    public string Modelo;
    public int NumeroDeRodas;
    
    public void ExibirDados()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Número de Rodas: {NumeroDeRodas}");

    }
    
}
public class Carro: Veiculo
{
    public int NumeroDePortas;
    public void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"Número de Portas: {NumeroDePortas}");
    }
}
public class Moto:Veiculo {
    public bool PossuiBagageiro;
    public void ExibirDaddos()
    {
        base.ExibirDados();
        Console.WriteLine($"Possui Bagageiro: {PossuiBagageiro}");
    }
    }
public class Program
{
    public static void Main(string[] args)
    {
        Carro carro = new Carro();
        carro.Marca = "Toyota";
        carro.Modelo = "Corolla";
        carro.NumeroDeRodas = 4;
        carro.NumeroDePortas = 4;
        Moto moto = new Moto();
        moto.Marca = "Honda";
        moto.Modelo = "CB500";
        moto.NumeroDeRodas = 2;
        moto.PossuiBagageiro = true;
        Console.WriteLine("Dados do Carro:");
        carro.ExibirDados();
        Console.WriteLine("\nDados da Moto:");
        moto.ExibirDaddos();
    }
}
