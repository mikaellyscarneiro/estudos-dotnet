namespace DesafioFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("####### DESAFIO VETOR ######");

            CriarVetorTamanhoInformado();
            CriarVetorTamanhoPadrao();
            CriarVetorTamanhoInformadoAleatorio();
            CriarVetorTamanhoPadraoAleatorio();
        }

        static void CriarVetorTamanhoInformado()
        {
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("Vetor com tamanho informado pelo usuário");
            Console.WriteLine("--------------------------------------------------\n");

            Console.WriteLine("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            VetorPersonalizado vetor = new VetorPersonalizado(tamanho);
            vetor.ListarElementos();

            ExibirMaiorMenor(vetor.RecuperarMenor(), vetor.RecuperarMaior());
        }

        static void CriarVetorTamanhoPadrao()
        {
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("Vetor com tamanho padrão");
            Console.WriteLine("--------------------------------------------------\n");

            VetorPersonalizado vetor = new VetorPersonalizado();
            vetor.ListarElementos();

            ExibirMaiorMenor(vetor.RecuperarMenor(), vetor.RecuperarMaior());
        }

        static void CriarVetorTamanhoInformadoAleatorio()
        {
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("Vetor com tamanho informado pelo usuário e \nvalores aleatórios");
            Console.WriteLine("--------------------------------------------------\n");

            Console.WriteLine("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor mínimo: ");
            int valorAleatorioMinimo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor máximo: ");
            int valorAleatorioMaximo = int.Parse(Console.ReadLine());

            VetorPersonalizado vetor = new VetorPersonalizado(tamanho, valorAleatorioMinimo, valorAleatorioMaximo);
            vetor.ListarElementos();

            ExibirMaiorMenor(vetor.RecuperarMenor(), vetor.RecuperarMaior());
        }

        static void CriarVetorTamanhoPadraoAleatorio()
        {
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("Vetor com tamanho padrão e valores aleatórios");
            Console.WriteLine("--------------------------------------------------\n");

            Console.WriteLine("Digite o valor mínimo: ");
            int valorAleatorioMinimo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor máximo: ");
            int valorAleatorioMaximo = int.Parse(Console.ReadLine());

            VetorPersonalizado vetor = new VetorPersonalizado(valorAleatorioMinimo, valorAleatorioMaximo);
            vetor.ListarElementos();

            //ExibirMaiorMenor(vetor.RecuperarMenor(), vetor.RecuperarMaior());
            ExibirMaiorMenor(vetor);
        }

        // Forma 1 de exibir menor e maior
        static void ExibirMaiorMenor(int menorValor, int maiorValor)
        {
            Console.WriteLine($"O menor valor do vetor é: {menorValor}");
            Console.WriteLine($"O maior valor do vetor é: {maiorValor}");
        }

        // Forma 2 de exibir menor e maior
        static void ExibirMaiorMenor(VetorPersonalizado vetor)
        {
            Console.WriteLine($"O menor valor do vetor é: {vetor.RecuperarMenor()}");
            Console.WriteLine($"O maior valor do vetor é: {vetor.RecuperarMaior()}");
        }
    }
}