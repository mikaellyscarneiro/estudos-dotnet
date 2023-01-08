ExecutarDesafioClasses();

static void ExecutarDesafioClasses()
{
    Console.WriteLine("DESAFIO CLASSES");

    // Cadastro do nome,idade, CPF e data de nascimento.
    Pessoa[] xPessoas = new Pessoa[2];

    for (int i = 0; i < xPessoas.Length; i++)
    {
        // Cria uma nova pessoa para que possamos preencher as propriedades com valores.
        // Se não der um new, o objeto ainda não existe. Por isso precisamos dar um new para instanciar o objeto para poder usá-lo.
        Pessoa pessoa = new Pessoa(); 

        // Preenche os valores da pessoa.
        Console.Write(" Qual o seu nome? ");
        pessoa.Nome = Console.ReadLine();

        Console.Write(" Qual sua idade? ");
        pessoa.Idade = Console.ReadLine();

        Console.Write(" Qual seu CPF? ");
        pessoa.CPF = Console.ReadLine();

        Console.Write(" Qual sua data de nascimento? ");
        pessoa.Nascimento = Console.ReadLine();

        // Guarda a nova pessoa no vetor. No final, o vetor vai ter várias pessoas dentro dele, é uma lista de pessoas.
        xPessoas[i] = pessoa;
    }

    // Agora que o vetor tem várias pessoas já com dados preenchidos, vamos exibir no console através da função abaixo.
    ListarTudo(xPessoas);
}

static void ListarTudo(Pessoa[] pessoas)
{
    // O foreach é como um for, só que mais inteligente. Ele pega a pessoa de dentro do vetor
    // e joga na variável pessoa. Com isso, não precisa ficar fazendo i++, pois o foreach faz isso implicitamente.
    foreach (Pessoa pessoa in pessoas)
    {
        Console.WriteLine($"\n Seu nome é: {pessoa.Nome}, sua idade é {pessoa.Idade}, você possui o Cpf de número{pessoa.CPF} e nasceu no dia{pessoa.Nascimento}");
    }

    // Outra forma de fazer a mesma coisa.
    //for (int i = 0; i < pessoas.Length; i++)
    //{
    //    Console.WriteLine($"\n Seu nome é: {pessoas[i].Nome}, sua idade é {pessoas[i].Idade}, você possui o Cpf de número{pessoas[i].CPF} e nasceu no dia{pessoas[i].Nascimento}");
    //}

    Console.ReadKey();
}

class Pessoa
{
    public string? Nome;
    public string? Idade;
    public string? CPF;
    public string? Nascimento;
}