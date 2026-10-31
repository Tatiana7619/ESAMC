class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Insira seu CPF: ");
            string CPF = Console.ReadLine();


            CPF = CPF.Trim().Replace(".", "").Replace("-", "");

            bool Possui11digitos = CPF.Length == 11;
            if(!Possui11digitos)
            {
                throw new ArgumentException("O CPF deve conter 11 dígitos");
            }

            for(int i = 0; i<CPF.Length; i++)
            {
                if (!char.IsDigit(CPF[i]))
                    {
                    throw new ArgumentException("O CPF deve conter apenas números");
                }
            }

            string CPFFormatado = CPF.Substring(0, 3) + "." +
                                  CPF.Substring(3, 3) + "." +
                                  CPF.Substring(6, 3) + "-" +
                                  CPF.Substring(9, 2);

            Console.WriteLine($"CPF formatado: {CPFFormatado}");
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}
