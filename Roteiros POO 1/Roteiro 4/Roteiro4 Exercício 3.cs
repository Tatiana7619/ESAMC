public interface IVeiculo
{
    void Mover();

}
public class Carro: IVeiculo
{
    public void Mover()
    {
        Console.WriteLine("O carro está se movendo.");
    }
}
public class Bicicleta: IVeiculo
{
    public void Mover()
    {
        Console.WriteLine("A Bicicleta está se movendo.");
    }

}
public class Program
{
    public static void Main()
    {
        Carro carro = new Carro();
        Bicicleta bicicleta = new Bicicleta();
        carro.Mover();
        bicicleta.Mover();

    }
}
