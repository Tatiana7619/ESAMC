public class Pessoa
{
    public string Nome;

}
public class Casa
{
    private Pessoa morador;
    public void ExibirMorador()
    {
        if (morador != null)
        {
            Console.WriteLine($"O Morador da casa é: {morador.Nome}");
        }
        else { Console.WriteLine("A casa não tem morador."); }
    }
    public void AdicionarMorador(Pessoa pessoa)
    {
        morador = pessoa;

    }

}

public class Program
{
    public static void Main()
    {
        Pessoa pessoa = new Pessoa();
        pessoa.Nome = "Matheusinho";

        Casa casa = new Casa();
        casa.AdicionarMorador(pessoa);
        casa.ExibirMorador();
    }
}
