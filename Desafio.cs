/*
int[,] numeros = new int[3, 3];

for (int linha = 0; linha < 3; linha++)
{
    for (int coluna = 0; coluna < 3; coluna++)
    {
        int numero;
        do
        {

            Console.Write("Digite um número de 0 a 9: ");
            numero = int.Parse(Console.ReadLine()!);
            if (numero < 0 || numero > 9)
            {
                Console.WriteLine("Valor inválido.");
            }
        }
        while (numero < 0 || numero > 9);
        numeros[linha, coluna] = numero;
    }
}

for (int linha = 0; linha < 3; linha++)
{
    for (int coluna = 0; coluna < 2; coluna++)
    {
        Console.Write(numeros[linha, coluna] + "\t");
    }
    Console.WriteLine();
}
*/