using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle01.Servicios
{
    internal class PideImplementacion : PideInterfaz
    {

        /// <summary>
        /// Metodo el cual es el encargado de calcular la suma de un valor introducido con sus anteriores
        /// <autor>24/10/2023 - DMN</autor>
        /// </summary>
        /// <returns></returns>
        public int calculo(int valorin)
        {
            MenuInterfaz mi1 = new MenuImplementacion();
            int i = valorin;

      
           
            for (i =i; i <= 10; ++i) /*Creacion de un "for", el cual recoge el valor introducido y calcula sus anteriores*/
            {

               
                Console.WriteLine(i);
                return i;
              
            }

            return i;         
           
              
            
        }
    }
}
