using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_LacoDeRepeticaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto - Laço de Repetição While: \r\n");

            Console.WriteLine("____________________________________________________________________ \r\n");
            Console.WriteLine("Contador de 0 a 10: \r\n");

            int contador = 0;
            while (contador <= 10)
            {                
                Console.WriteLine(contador);
                contador++;
            }
            Console.ReadLine();
        }
    }
}
