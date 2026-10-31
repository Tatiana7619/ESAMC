using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Insira seu nome: "); 
        string nome = Console.ReadLine();

        Console.Write("Insira a data e hora do seu compromisso (Siga o formato: dd/MM/yyyy HH:mm): ");
        DateTime compromisso = DateTime.Parse(Console.ReadLine());

        TimeSpan diasrestantes = compromisso - DateTime.Now;

        string diadasemana = compromisso.ToString("dddd", new CultureInfo("pt-BR"));

        string mensagem = string.Format("Olá, {0}!\nSeu compromisso será em {1} dias, na {2}.\nData Marcada: {3} às {4}", nome, diasrestantes.Days, diadasemana,
                                        compromisso.ToString("dd/MM/yyyy"), compromisso.ToString("HH:mm"));

        Console.WriteLine(mensagem);

    }
}
