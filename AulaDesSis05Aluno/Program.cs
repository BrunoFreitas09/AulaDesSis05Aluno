using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaDesSis05Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a Porcentagem da Frequência do aluno: ");
            double freq = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a média do aluno: ");
            double med = double.Parse(Console.ReadLine());

            if (freq >= 75 && med >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else if ((freq >= 75 && med < 7 | med >= 4) | (freq < 75 && med >= 7))
            {
                Console.WriteLine("Recuperação");
            }
            else 
            {
                Console.WriteLine("Repetido");
            }








            Console.ReadKey();
        }
    }
}
