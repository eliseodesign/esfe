﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ESFE.GuiaSecuenciales_EliseoArevalo.Ejer1{
  public class Program{
    static void Main(string[] args){
      int NUM1, NUM2;
      double RESUL;
      string linea;
      Console.WriteLine("NÚMERO 1 :"); linea = Console.ReadLine();
      NUM1 = int.Parse(linea);
      Console.WriteLine("NÚMERO 2 :"); linea = Console.ReadLine();
      NUM2 = int.Parse(linea);
      RESUL = (NUM1 + NUM2) * (NUM1 - NUM2);
      Console.WriteLine();
      Console.WriteLine("El resultado es: " + RESUL);
      Console.ReadLine();
    }
  }
}