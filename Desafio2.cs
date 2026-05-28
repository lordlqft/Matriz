/* Desafio: Criar uma matriz de números e ordenar os números em ordem decrescente */



/*
int[,] matriz = new int[5, 2];
for (int linha = 0; linha < 5; linha++)
{
    for (int coluna = 0; coluna < 2; coluna++)
    {
        Console.Write($"Digite um número: ");
        matriz[linha, coluna] = int.Parse(Console.ReadLine()!);
    }
}

Console.WriteLine();

for (int l1 = 0; l1 < 5; l1++)
{
    for (int c1 = 0; c1 < 2; c1++)
    {
        for (int l2 = 0; l2 < 5; l2++)
        {
            for (int c2 = 0; c2 < 2; c2++)
            {
                if (matriz[l1, c1] > matriz[l2, c2])
                {
                    int troca = matriz[l1, c1];
                    matriz[l1, c1] = matriz[l2, c2];
                    matriz[l2, c2] = troca;
                }
            }
        }
    }
}

for (int linha = 0; linha < 5; linha++)
{
    for (int coluna = 0; coluna < 2; coluna++)
    {
        Console.Write(matriz[linha, coluna] + "\t");
    }
}
*/