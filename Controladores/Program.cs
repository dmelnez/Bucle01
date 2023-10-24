using Bucle01;
using Bucle01.Servicios;
using System.ComponentModel.Design;

class Program
{
    public static void Main(String[] args)
    {

        MenuInterfaz mi = new MenuImplementacion();

        int valorIntro = mi.pedirNum();

        PideInterfaz mi1 = new PideImplementacion();

        int resultado = mi1.calculo();
    }
}