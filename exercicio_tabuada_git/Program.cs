using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_tabuada_git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, x;
            Console.Write("Digite um numero para saber sua tabuada até 10: ");
            num = int.Parse(Console.ReadLine());


            for (x = 1; x <= 10; x++) // para inverter ondem, apenas mudar regra do contador p/ (x = 10; x >=1; x--;)
            {
                Console.WriteLine(num + " X " + x + " = " + num * x);
            }

            Console.ReadKey();
        }
    }
}
