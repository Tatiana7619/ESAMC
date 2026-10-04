class Pessoa
{
    public string Nome { get; private set; }
    public int Idade { get; set; }
    public string Email { get; set; }

    public Pessoa(string Nome)
    {
        this.Nome = Nome;
    }
}

class Program
{
    static void Main()
    {
        Pessoa pessoa = new Pessoa("Landim");
        //pessoa.Nome = "Lucas"; Não é possível atribuir um valor à propriedade somente leitura.
        pessoa.Idade = 25;
        pessoa.Email = "landim@example.com";
        Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Email: {pessoa.Email}");
        pessoa.Idade = 30;
        Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Email: {pessoa.Email}");
    }
}
