using System.ComponentModel.Design;

public class Elevador
{
    private int andarAtual;
    private int totalAndares;

    public Elevador(int totalAndares)
    {
        this.totalAndares = totalAndares;
        andarAtual = 0;

    }

    public void Subir()
    {
        if (andarAtual < totalAndares){
            andarAtual++;
            Console.WriteLine($"O andar subiu para o {andarAtual}");
        }
        else
        {
            Console.WriteLine("O elevador já está no último andar");
        }
    }
    public void Descer()
    {
        if (andarAtual > 0)
        {
            andarAtual--;
            Console.WriteLine($"O andar desceu para o {andarAtual}");
        }
        else
        {
            Console.WriteLine("O elevador já está no térreo");
        }
    }

    public void ExibirAndar()
    {
        Console.WriteLine($"Andar atual: {andarAtual}");
    }
}

public class Program
{
    public static void Main(string[] args) {
        Elevador e = new Elevador(10);
        Console.WriteLine("Teste do Primeiro Elevador");
        e.Subir();
        e.Subir();
        e.ExibirAndar(); 
        e.Descer();
        e.ExibirAndar(); 
        e.Descer();
        e.Descer();
        e.ExibirAndar(); 

        Elevador e2 = new Elevador(3);
        Console.WriteLine ("Teste do segundo Elevaodor");
        e2.Descer();
        e2.ExibirAndar(); 
        e2.Subir();
        e2.Subir();
        e2.Subir();
        e2.Subir();
        e2.ExibirAndar(); 

    }
}

