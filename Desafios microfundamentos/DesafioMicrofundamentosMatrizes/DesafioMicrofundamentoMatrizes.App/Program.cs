using System;

Console.WriteLine("DESAFIO MATRIZES!");

ExecutarDesafioMatrizes();

static void ExecutarDesafioMatrizes()
{
    Console.WriteLine("Qual o tamanho da Matriz Quadrática?");
    int tamanho = int.Parse(Console.ReadLine());

    int[,] matriz = new int[tamanho, tamanho];  // declarei a matriz, com tamanho parametrizado

    for (int i = 0; i < tamanho; i++) // passando por todas as linhas
    {
        for (int j = 0; j < tamanho; j++) // passando por todos as colunas
        {
            Console.Write($"Digite o valor dos elementos da Matriz {i + 1}, {j + 1}: ");
            matriz[i, j] = int.Parse(Console.ReadLine()); // lendo o valor do elemento da matriz
        }

    }

    Console.WriteLine();
    Console.WriteLine("Os valores da diagonal principal são: ");

    int[] diagonalPrincipal = ValoresDiagonal(matriz, tamanho); // armazena os valores da diagonal,passando os dois parametros 

    for (int i = 0; i < tamanho; i++)
    {
        Console.WriteLine($"{diagonalPrincipal[i]}");
    }

    Console.ReadKey();
}
// Metódo para receber qualquer tamanho de matriz
static int[] ValoresDiagonal(int[,] matriz, int tamanho)
{
    int[] diagonalPrincipal = new int[tamanho];

    for (int i = 0; i < tamanho; i++)
    {
        for (int j = 0; j < tamanho; j++)
        {
            if (i == j)  // São iguais em linha e coluna?
                diagonalPrincipal[i] = matriz[i, j];
        }
    }

    return diagonalPrincipal;
}