using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número inteiro (N1): ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o segundo número inteiro (N2): ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        // Verifica se N2 é zero para evitar divisão por zero
        if (n2 == 0)
        {
            Console.WriteLine("Não é possível dividir por zero.");
        }
        // Verifica se a divisão não é exata
        else if (!VerifDivisaoExata(n1, n2))
        {
            Console.WriteLine("Não existe resultado inteiro para divisão.");
        }
        else
        {
            // Calcula e imprime a multiplicação de N1 por N2 usando adição repetida
            int multiplicacao = Multiplicacao(n1, n2);
            Console.WriteLine($"Multiplicação: {multiplicacao}");

            // Calcula e imprime a divisão inteira de N1 por N2 usando subtração repetida
            int divisao = DivInteira(n1, n2);
            Console.WriteLine($"Divisão Inteira: {divisao}");
        }
    }

    // Função para verificar se a divisão é exata
    static bool VerifDivisaoExata(int n1, int n2)
    {
        return n1 % n2 == 0;
    }

    // Função para calcular multiplicação usando adição repetida
    static int Multiplicacao(int n1, int n2)
    {
        int resultado = 0;
        for (int i = 0; i < Math.Abs(n2); i++)
        {
            resultado += n1;
        }

        // Ajusta o sinal do resultado de acordo com os sinais de N1 e N2
        if ((n1 < 0 && n2 > 0) || (n1 > 0 && n2 < 0))
        {
            resultado = -resultado;
        }

        return resultado;
    }

    // Função para calcular divisão inteira usando subtração repetida
    static int DivInteira(int n1, int n2)
    {
        int resultado = 0;
        int absN1 = Math.Abs(n1);
        int absN2 = Math.Abs(n2);

        while (absN1 >= absN2)
        {
            absN1 -= absN2;
            resultado++;
        }

        // Ajusta o sinal do resultado de acordo com os sinais de N1 e N2
        if ((n1 < 0 && n2 > 0) || (n1 > 0 && n2 < 0))
        {
            resultado = -resultado;
        }

        return resultado;
    }
}
