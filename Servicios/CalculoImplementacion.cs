using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle03.Servicios
{
    internal class CalculoImplementacion : CalculoInterfaz
    {

        public int calculo(int valorin)
        {
            

            for (int i = 1; i < valorin; i++) 
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("" + j);
                }
                Console.WriteLine("");
            }
         return valorin;
        }
    }
}


   
