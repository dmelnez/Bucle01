using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle01.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Metodo por el cual se le pide al usuario un valor y lo devuelve
        ///  <autor>25/10/2023 - DMN</autor>
        /// </summary>
        /// <returns></returns>
        public int pedirNum( )
        {
            int valor;
            Console.WriteLine("Introduzca un Valor Mayor al 0");
            valor = Convert.ToInt32(Console.ReadLine());
            return valor;


        }


    }
}
