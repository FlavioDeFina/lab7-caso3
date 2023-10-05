using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_caso3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el final de los años: ");
            int años = int.Parse(Console.ReadLine());
            int inicio = 1900;

            for (int i = inicio;i <= años; i++) 
            {
                if ((i %4==0 && i%100 !=0)||(i %400 == 0)) 
                {
                    Console.WriteLine("aqui hay un años bisiesto: "+i);
                }
            }
            Console.ReadKey();
        }
    }
}
