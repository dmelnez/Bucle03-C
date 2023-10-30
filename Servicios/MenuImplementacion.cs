using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle03.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int pideNum()
        {
            int valorI;
            Console.WriteLine("Introduzca un Valor Mayor a 0");
            valorI = Convert.ToInt32(Console.ReadLine());
            return valorI;
        }


    }
}
