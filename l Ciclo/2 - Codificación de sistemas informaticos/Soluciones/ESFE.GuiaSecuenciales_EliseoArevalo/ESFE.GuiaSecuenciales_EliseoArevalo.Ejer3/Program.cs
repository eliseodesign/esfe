﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ESFE.GuiaSecuenciales_EliseoArevalo.Ejer3{
  public class Program{
    static void Main(string[] args){
      byte CANB, CANH, CANP;
      double APAGAR;
      string linea;
      const double PRECIOB = 0.8;
      const double PRECIOH = 2;
      const double PRECIOP = 1.2;
      Console.WriteLine("CANTIDAD DE HAMBURGESA"); linea = Console.ReadLine();
      CANH = byte.Parse(linea);
      Console.WriteLine("CANTIDAD DE PAPAS"); linea = Console.ReadLine();
      CANP = byte.Parse(linea);
      Console.WriteLine("CANTIDAD DE BEBIDAS"); linea = Console.ReadLine();
      CANB = byte.Parse(linea);
      APAGAR = ((CANH * PRECIOH) + (CANP * PRECIOP) + (CANB * PRECIOB));
      Console.WriteLine("VALOR A PAGAR: " + APAGAR);
      Console.WriteLine("Pulse una Tecla: "); Console.ReadLine();
    }
  }
}