using System;

class Program
{
    static void Main()
    {
        // Inicializamos as contagens
        int pares = 0;
        int impares = 0;
        int positivos = 0;
        int negativos = 0;

        // Arrays para armazenar os valores
        int[] numDigitados = new int[5];

        // Pedimos ao usuário para inserir 5 valores inteiros (exceto zero)
        for (int i = 0; i < 5;)
        {
            Console.Write("Digite um número inteiro (exceto zero): ");
            int numDigitado = Convert.ToInt32(Console.ReadLine());

            // Verificamos se o valor é zero
            if ( numDigitado == 0)
            {
                Console.WriteLine("Zero não é um valor válido. Por favor, digite novamente.");
            }
            else
            {
                // Armazenamos o valor no array
                numDigitados[i] = numDigitado;

                // Verificamos se o número é par ou ímpar
                if (numDigitado % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }

                // Verificamos se o número é positivo ou negativo
                if (numDigitado > 0)
                {
                    positivos++;
                }
                else
                {
                    negativos++;
                }

                i++; // Apenas incrementamos o contador quando um valor válido é fornecido
            }
        }

        // Exibimos os resultados
        Console.WriteLine("Valores digitados:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(numDigitados[i] + " ");
        }

        Console.WriteLine("\nQuantidade de números pares: " + pares);
        Console.WriteLine("Quantidade de números ímpares: " + impares);
        Console.WriteLine("Quantidade de números positivos: " + positivos);
        Console.WriteLine("Quantidade de números negativos: " + negativos);
    }
}
