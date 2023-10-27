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

            int valors; /*Creacion de la Variable que contendra el valor de i, cambiando asi su valor, en el incremento de la varible i*/
            i = valorin;

            for (i =i; i <= 10; ++i) /*Creacion de un "for", el cual recoge el valor introducido y calcula sus anteriores*/
            {

                
                Console.WriteLine(i + valors);
                return i;
              
            }

            return i;         
           
              
            
        }
    }
}
