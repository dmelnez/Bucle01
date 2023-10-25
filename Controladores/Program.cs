using Bucle01;
using Bucle01.Servicios;
using System.ComponentModel.Design;

/// <summary>
/// Clase Principal por la cual el programa se Inicia
/// <autor>25/10/2023 - DMN</autor>
/// </summary>
class Program
{
    /// <summary>
    /// Metodo por el cual la aplicacion se inicializa
    /// <autor>25/10/2023 - DMN</autor>
    /// </summary>
    /// <param name="args"></param>
    public static void Main(String[] args)
    {

        MenuInterfaz mi = new MenuImplementacion();

        int valorIntro = mi.pedirNum();

        PideInterfaz mi1 = new PideImplementacion();

        int resultado = mi1.calculo(valorIntro);
    }
}