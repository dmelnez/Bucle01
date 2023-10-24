using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle01.Servicios
{
    internal class PideImplementacion : PideInterfaz
    {
       public int calculo( )
        {
            MenuInterfaz mi1 = new MenuImplementacion();
            int i = mi1.pedirNum();

            for (i = i; i <= 10; ++i)
            {
                Console.WriteLine(i);
            }
                return i;
              
            
        }
    }
}
