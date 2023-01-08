namespace DesafioFinal
{
    public class VetorPersonalizado
    {
        private const int TamanhoPadrao = 10;
        private int[] _vetor;

        public VetorPersonalizado(int tamanho)
        {
            _vetor = new int[tamanho];
        }

        public VetorPersonalizado()
        {
            _vetor = new int[TamanhoPadrao];
        }

        public VetorPersonalizado(int tamanho, int valorAleatorioMinimo, int valorAleatorioMaximo)
        {
            _vetor = CriarVetorValoresAletatorios(tamanho, valorAleatorioMinimo, valorAleatorioMaximo);
        }

        public VetorPersonalizado(int valorAleatorioMinimo, int valorAleatorioMaximo)
        {
            _vetor = CriarVetorValoresAletatorios(TamanhoPadrao, valorAleatorioMinimo, valorAleatorioMaximo);
        }

        private int[] CriarVetorValoresAletatorios(int tamanho, int valorAleatorioMinimo, int valorAleatorioMaximo)
        {
            int[] vetorValoresAleatorios = new int[tamanho];

            Random geradorValoresAleatorios = new Random();
            int valorAleatorioMaximoInclusivo = valorAleatorioMaximo + 1;

            for (int i = 0; i < vetorValoresAleatorios.Length; i++)
            {
                int valorAleatorio = geradorValoresAleatorios.Next(valorAleatorioMinimo, valorAleatorioMaximoInclusivo);

                vetorValoresAleatorios[i] = valorAleatorio;
            }

            return vetorValoresAleatorios;
        }

        public void ListarElementos()
        {
            Console.WriteLine("\n=== OS ELEMENTOS DO VETOR SÃO: ===");

            int ultimaPosicao = _vetor.Length - 1;

            for (int i = 0; i < _vetor.Length; i++)
            {
                Console.Write(_vetor[i]);

                bool ultimoElemento = i == ultimaPosicao;

                if (!ultimoElemento)
                {
                    Console.Write(",");
                }
            }

            Console.WriteLine("\n\n");
        }

        public void InserirElemento(int posicao, int valor)
        {
            _vetor[posicao] = valor;
        }

        public int RecuperarElemento(int posicao)
        {
            return _vetor[posicao];
        }

        public int RecuperarMaior()
        {
            int maiorValor = 0;

            foreach (var valor in _vetor)
            {
                if (valor > maiorValor)
                {
                    maiorValor = valor;
                }
            }

            return maiorValor;
        }

        public int RecuperarMenor()
        {
            int menorValor = _vetor[0];

            for (int i = 1; i < _vetor.Length; i++)
            {
                if (_vetor[i] < menorValor)
                {
                    menorValor = _vetor[i];
                }
            }

            return menorValor;
        }
    }
}
