Console.WriteLine("DESAFIO!");

ExecutarDesafio();

static void ExecutarDesafio()
{
    int[] Vetor = new int[5];

    for (int i = 0; i < 5; i++)
    {
        Console.Write($"Digite o vetor {i + 1}:");
        Vetor[i] = int.Parse(Console.ReadLine());
    }

    int Soma, Quantidade;
    
    Soma = SomaPares(Vetor);
    Quantidade = ContaImpares(Vetor);

    Console.WriteLine();
    Console.WriteLine($"Soma dos números pares: {Soma}");
    Console.WriteLine($"Quantidade de números impares: {Quantidade}");

    Console.ReadKey(); 

    int SomaPares(int[] Vetor)
    {
        int Soma = 0;             
        for (int i = 0; i < 5; i++)
        {
            if (Vetor[i] % 2 == 0) // Ele é par?
                Soma += Vetor[i];     // Então soma
        }
        return Soma;
    }

    int ContaImpares(int[] Vetor)
    {
        int Quantidade = 0;
        for (int i = 0; i < Vetor.Length; i++)
        {
            if (Vetor[i] % 2 != 0) //Ele é impar?
                Quantidade++; // Então acumula
        }

        return Quantidade;
    }

}

