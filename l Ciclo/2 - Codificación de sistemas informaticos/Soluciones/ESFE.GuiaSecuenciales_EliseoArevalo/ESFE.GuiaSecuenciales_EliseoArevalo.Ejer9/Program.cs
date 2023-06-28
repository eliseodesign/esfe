using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ESFE.GuiaSecuenciales_EliseoArevalo.Ejer9
{
  public class Program
  {
    static void Main(string[] args)
    {
      double acumulador = 0;
      const int alumnos = 3;
      for(int i = 1; i <= alumnos; i++){{
        Console.WriteLine("Introduca nota del alumno " + i);
        double nota = Convert.ToDouble( Console.ReadLine() );
        if(nota < 0)
        {
          i--;
          Console.WriteLine("Valor invalido");
        }
        else
        {
          acumulador += nota;
        }
      }}
      Console.WriteLine("El promedio de {0} alumnos es de {1}", alumnos, acumulador/alumnos);
    }
  }
}