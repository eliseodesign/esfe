using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ESFE.GuiaSecuenciales_EliseoArevalo.Ejer8
{
  public class Program
  {
    static void Main(string[] args)
    {
      double precio; 
      Console.WriteLine("Introduzca e precio del artículo sin IVA");

      precio = Convert.ToDouble( Console.ReadLine() );

      if(precio > 0 )
      {
        Console.WriteLine("Sin IVA: " + precio);
        Console.WriteLine("+IVA de: " + precio * 0.13);
        Console.WriteLine("TOTAL  : " + (precio + (precio * 0.13)));
      }
      else
      {
        Console.WriteLine("El precio debe ser mayor a 0");
      }
    }
  }
}