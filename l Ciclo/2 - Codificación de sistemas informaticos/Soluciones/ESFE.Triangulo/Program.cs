using System;
namespace ESFE.Triangulo.Consola
  {

  ///<sumary>
  ///Ecnontrar el area de un rectangulo A = B * H
  ///<sumary>
  internal class Progra
  {
    static void Main(string[] args)
    {
      

      int acumulador = 0;

      int numero = 0;

      while(numero >= 0)
      {
        System.Console.WriteLine("Ingrese valor: ");
        numero = Convert.ToInt32( Console.ReadLine());

        acumulador = acumulador + numero;
      }
      
      System.Console.WriteLine("El total fue " + acumulador);
      

    }
  } 
}