using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 numero;
            numero = Convert.ToInt16(!(21 > 21));
            Console.WriteLine(numero);
        }
    }
}

/*
A expressão 21 > 21 é avaliada como false, porque 21 não é maior que 21. 
Em seguida, o operador de negação lógica "!" inverte o valor, transformando false em true. 
Em C#, quando você converte um valor booleano true para int, ele se torna 1. 
Portanto, numero será igual a 1 e é isso que será exibido no terminal.
*/