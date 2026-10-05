class Produto
{
    private string nome;
    private string codigo;
    private decimal preco;
    public int QuantidadeEstoque { get; private set; }
    public bool EstoqueBaixo
    {
        get
        {
            return QuantidadeEstoque <= 5;
        }
    }
    public Produto(string Nome, string Codigo, decimal Preco, int QuantidadeEstoque)
    {
        if (QuantidadeEstoque < 0)
        {
            throw new ArgumentException("A quantidade em estoque não pode ser negativa.");
        }
        this.QuantidadeEstoque = QuantidadeEstoque;
        this.Nome = Nome;
        this.Codigo = Codigo;
        this.Preco = Preco;
    }
    public string Nome
    {
        get { return nome; }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O nome do produto não pode ser vazio.");
            }
            nome = value;
        }
    }
    public string Codigo
    {
        get { return codigo; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O código do produto não pode ser vazio.");
            }
            codigo = value;
        }
    }
    public decimal Preco
    {
        get { return preco; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("O preço não pode ser negativo.");
            }
            preco = value;
        }
    }

    public void AdicionarEstoque(int Quantidade)
    {
        if (Quantidade < 0)
        {
            throw new ArgumentException("A quantidade a ser adicionada não pode ser negativa.");
        }
        QuantidadeEstoque += Quantidade;
    }

    public void RemoverEstoque(int Quantidade)
    {
        if (Quantidade < 0)
        {
            throw new ArgumentException("A quantidade a ser removida não pode ser negativa.");
        }
        if (Quantidade > QuantidadeEstoque)
        {
            throw new ArgumentException("A quantidade a ser removida não pode ser maior que a quantidade em estoque.");
        }
        QuantidadeEstoque -= Quantidade;
    }
}

class Program
{
    static void Main()
    {
        Produto produto = new Produto("Produto 1", "COD001", 10.99m, 10);
        try
        {
            produto.AdicionarEstoque(20);
            Console.WriteLine(produto.QuantidadeEstoque);
            produto.RemoverEstoque(10);
            Console.WriteLine(produto.QuantidadeEstoque);
            Console.WriteLine(produto.EstoqueBaixo);
            //produto.QuantidadeEstoque = 500;
            produto.RemoverEstoque(30);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        try
        {
            Console.WriteLine(produto.QuantidadeEstoque);
            produto.RemoverEstoque(16);
            Console.WriteLine(produto.EstoqueBaixo);
            Produto produto2 = new Produto("", "COD002", 15.99m, 3);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}

// Quantidade de Estoque deve possuir Private Set , para que não seja possível alterar diretamente a quantidade de estoque de fora da classe Produto.
// A quantidade de estoque só pode ser alterada através dos métodos AdicionarEstoque e RemoverEstoque, que possuem validações para garantir que a quantidade
// não seja negativa e que não seja removida mais do que o disponível em estoque.