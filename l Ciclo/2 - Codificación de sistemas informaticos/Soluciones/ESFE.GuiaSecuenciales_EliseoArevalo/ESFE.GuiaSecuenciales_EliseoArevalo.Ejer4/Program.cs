using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ESFE.GuiaSecuenciales_EliseoArevalo.Ejer4
{
  public class Program
  {
    static void Main(string[] args)
    {
      double BASE, ALTURA, RESUL;
      string linea;
      Console.Write("Digite la base :"); linea = Console.ReadLine();
      BASE = double.Parse(linea);
      Console.Write("Digite la altura :"); linea = Console.ReadLine();
      ALTURA = double.Parse(linea);
      RESUL = (BASE * ALTURA) / 2;
      Console.WriteLine("AREA DE TRIANGULO :" + String.Format("{0:####.00}", RESUL));
      Console.WriteLine("AREA DE TRIANGULO :" + String.Format("{0:c}", RESUL));
      Console.WriteLine("AREA DE TRIANGULO :" + String.Format("{0:f}", RESUL));
      Console.WriteLine("AREA DE TRIANGULO :" + String.Format("{0:G}", RESUL));
      Console.WriteLine();
      Console.WriteLine("HOY ES: " + String.Format("HOY ES {0:F}", DateTime.Now));
      // Cambie la siguiente linea dado que no funciona 
      // Console.WriteLine("HOY ES: " + String.Format("HOY ES {0.dddd}{0:dd/MM/yyy}", DateTime.Now));
      Console.WriteLine("HOY ES: " + String.Format("HOY ES {0:dddd dd/MM/yyyy}", DateTime.Now));
      Console.Write("Pulse una tecla:"); Console.ReadLine();
    }
  }
}