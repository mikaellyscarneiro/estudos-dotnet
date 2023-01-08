
class Veiculo
{
    private string? _Nome;
    public string? Nome
    {
        get { return _Nome; }
        set { _Nome = value; }
    }
    private string? _Marca;
    public string? Marca
    {
        get { return _Marca; }
        set { _Marca = value; }
    }
    private string? _Ano;
    public string? Ano
    {
        get { return _Ano; }
        set { _Ano = value; }
    }

    private string? _Placa;
    public string? Placa
    {
        get { return _Placa; }
        set { _Placa = value; }
    }
}

class Programa

{ 
    static void Main(string[] args)

    {
        LeituraDados();

        static void LeituraDados()
        {

            Veiculo[] Cadastro = new Veiculo[2];

            for (int i=0; i < Cadastro.Length; i++)
            {
                Veiculo x = new Veiculo();

                Console.Write("Qual o nome do veiculo?");
                x.Nome = Console.ReadLine();

                Console.Write("Qual a marca do veiculo?");
                x.Marca = Console.ReadLine();

                Console.Write("Qual é o ano de fabricação do veiculo?");
                x.Ano= Console.ReadLine();

                Console.Write("Qual a placa do veiculo?");
                x.Placa = Console.ReadLine();
                Console.WriteLine();

                Cadastro[i] = x;
            }
            ListarDados(Cadastro);
        }

        static void ListarDados(Veiculo[] Cadastro)
        {

            foreach (Veiculo V in Cadastro)
            {

                Console.WriteLine($" Marca: {V.Marca}");
                Console.WriteLine($"Nome: {V.Nome}");
                Console.WriteLine($"Placa: {V.Placa}");
                Console.WriteLine($"Ano: {V.Ano}");

            }

            Console.ReadKey();

        }

    }
}

