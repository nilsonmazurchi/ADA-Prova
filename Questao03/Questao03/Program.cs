using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        // Divide a frase em palavras usando espaços como delimitadores
        string[] palavras = frase.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '"' }, StringSplitOptions.RemoveEmptyEntries);

        // Inicializa contadores
        int maiusculas = 0;
        int minusculas = 0;
        int comecaMaiuscula = 0;
        int comecaMinuscula = 0;

        // Itera sobre cada palavra na frase
        foreach (string palavra in palavras)
        {
            // Verifica se a palavra é toda maiúscula
            if (EhTodaMaiuscula(palavra))
            {
                maiusculas++;
            }
            // Verifica se a palavra é toda minúscula
            else if (EhTodaMinuscula(palavra))
            {
                minusculas++;
            }
            // Verifica se a palavra começa com letra maiúscula
            else if (ComecaComMaiuscula(palavra))
            {
                comecaMaiuscula++;
            }
            // A palavra começa com letra minúscula
            else
            {
                comecaMinuscula++;
            }
        }

        // Exibe os resultados
        Console.WriteLine($"Palavras com todas as letras maiúsculas: {maiusculas}");
        Console.WriteLine($"Palavras com todas as letras minúsculas: {minusculas}");
        Console.WriteLine($"Palavras que começam com letra maiúscula: {comecaMaiuscula}");
        Console.WriteLine($"Palavras que começam com letra minúscula: {comecaMinuscula}");
        Console.WriteLine($"Total de palavras: {palavras.Length}");
    }

    // Verifica se a palavra é toda maiúscula
    static bool EhTodaMaiuscula(string palavra)
    {
        return palavra.All(char.IsUpper);
    }

    // Verifica se a palavra é toda minúscula
    static bool EhTodaMinuscula(string palavra)
    {
        return palavra.All(char.IsLower);
    }

    // Verifica se a palavra começa com letra maiúscula
    static bool ComecaComMaiuscula(string palavra)
    {
        return char.IsUpper(palavra[0]) && palavra.Substring(1).All(char.IsLower);
    }
}
