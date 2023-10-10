using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = -5; i <= 7; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
/*
Alternativa E
O loop for inicia com i igual a -5 e continua enquanto i for menor ou igual a 7. 
Em cada iteração, i é incrementado por 3. Calculando as iterações:
i começa em -5. É menor ou igual a 7. Resultado: -5;
i é incrementado por 3. i agora é -2. É menor ou igual a 7. Resultado: -2;
i é incrementado por 3. i agora é 1. É menor ou igual a 7. Resultado: 1;
i é incrementado por 3. i agora é 4. É menor ou igual a 7. Resultado: 4;
i é incrementado por 3. i agora é 7. É menor ou igual a 7. Resultado: 7.
*/