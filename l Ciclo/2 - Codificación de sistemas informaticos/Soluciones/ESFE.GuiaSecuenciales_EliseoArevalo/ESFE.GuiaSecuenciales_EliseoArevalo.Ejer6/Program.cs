using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ESFE.GuiaSecuenciales_EliseoArevalo.Ejer6
{
  public class Program
  {
    static void Main(string[] args)
    { 
      double BASE, ALTURA, RESUL;
      Console.Write("Digite la base :"); 
      BASE = Convert.ToDouble( Console.ReadLine() );
      Console.Write("Digite la altura :"); 
      ALTURA = Convert.ToDouble( Console.ReadLine() );
      RESUL = BASE * ALTURA;

      Console.WriteLine(
        BASE != ALTURA && (BASE > 0 && ALTURA > 0)
        ? "El Area del rectangulo es " + RESUL
        : "Valores Erroneos"
        );
    }
  }
}