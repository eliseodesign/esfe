using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ESFE.GuiaSecuenciales_EliseoArevalo.Ejer10
{
  public class Program
  {
    static void Main(string[] args)
    {
    
      int nacimiento;
      int anioActual = DateTime.Now.Year;
      System.Console.WriteLine("Digite su año de nacimiento");
      nacimiento = Convert.ToInt32( Console.ReadLine() );
      int edad = anioActual - nacimiento;
      if(edad < 100)
      {
        if(edad > 0){
          Console.WriteLine("La edad es de: " + edad);
        }
        else
        {
          Console.WriteLine("Osea que aun no naces????");
        }
      }
      else
      {
        Console.WriteLine("Tienes mas de 100 años????");
      }
    }
  }
}