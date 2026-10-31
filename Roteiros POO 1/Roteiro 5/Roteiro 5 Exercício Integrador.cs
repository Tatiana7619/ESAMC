class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Cadastro de Evento\n".PadLeft(43));

            Console.WriteLine("Insira as informações abaixo: \n");

            Console.Write("Nome do Evento: ");
            string NomeEvento = Console.ReadLine();

            Console.Write("Data do Evento (dd/MM/yyyy): ");
            DateTime DataEvento = DateTime.Parse(Console.ReadLine());

            Console.Write("Valor do Ingresso: R$ ");
            decimal valoringresso = Convert.ToDecimal(Console.ReadLine());

            if (valoringresso < 0)
            {
                throw new ArgumentException("O valor do ingresso não pode ser negativo");

            }

            Console.Write("Categoria do Ingresso(vip,comum): ");
            string Categoria = Console.ReadLine().ToUpper().Trim();

            decimal desconto = 0m;

            if (Categoria.Contains("VIP"))
            {
                Categoria = "VIP";
                desconto = 0.10m;
            }
            else if (Categoria.Contains("COMUM"))
            {
                Categoria = "COMUM";
                desconto = 0.05m;
            }
            else
            {
                throw new ArgumentException("Categoria inválida");
            }

            decimal ValorFinal = Math.Round(valoringresso * (1 - desconto), 2);

            DateTime hoje = DateTime.Today;
            int DiasRestantes = (DataEvento.Date - hoje).Days;

            if (DiasRestantes < 0)
            {
                Console.WriteLine("A data do evento já passou");
                return;
            }

            Console.WriteLine("\n" + new string('-', 55));

            Console.WriteLine("Ingresso".PadLeft(30));

            Console.WriteLine(new string('=', 55));

            Console.WriteLine(
                String.Format("{0,-20} {1,-30}", "EVENTO:", NomeEvento)
            );

            Console.WriteLine(
                String.Format("{0,-20} {1,-30}", "DATA:", DataEvento.ToString("dd/MM/yyyy"))
            );

            Console.WriteLine(
                String.Format("{0,-20} {1,-30}", "CATEGORIA:", Categoria)
            );

            Console.WriteLine(
                String.Format("{0,-20} {1,-30:C}", "VALOR ORIGINAL:", valoringresso)
            );

            Console.WriteLine(
                String.Format("{0,-20} {1,-30:P0}", "DESCONTO:", desconto)
            );

            Console.WriteLine(
                String.Format("{0,-20} {1,-30:C}", "VALOR FINAL:", ValorFinal)
            );

            Console.WriteLine(
                String.Format("{0,-20} {1,-30}", "DIAS RESTANTES:", DiasRestantes)
            );

            Console.WriteLine(new string('-', 55));

        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Formato inválido: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}