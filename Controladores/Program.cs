using Bucle03.Servicios;
/// <summary>
/// Clase Principal por la cual el programa se Inicia
/// <autor>30/10/2023 - DMN</autor>
/// </summary>
class Program
{
    /// <summary>
    /// Metodo por el cual la aplicacion se inicializa
    /// <autor>30/10/2023 - DMN</autor>
    /// </summary>
    /// <param name="args"></param>
    public static void Main(String[] args)
    {

        MenuInterfaz mi = new MenuImplementacion();

        int valorIntro = mi.pideNum();

        CalculoInterfaz mi1 = new CalculoImplementacion();

        int resultado = mi1.calculo(valorIntro);



    }
}