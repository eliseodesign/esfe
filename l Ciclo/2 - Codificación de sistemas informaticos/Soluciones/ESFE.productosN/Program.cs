using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ESFE.GuiaSecuenciales_EliseoArevalo.Ejer10
{
  public class Program
  {
    /// <summary>
    /// Punto de entrada del programa. Calcula el valor total a pagar por N productos.
    /// </summary>
    static void Main(string[] args)
    {

      try
      {
        // Declaramos las variables necesarias para el programa
        int n, i = 1; 
        double precio, cantidad, total = 0; 
        Console.Write("Ingrese la cantidad de productos a comprar: ");
        n = Convert.ToInt32(Console.ReadLine());

        // Iniciamos un bucle do-while que se ejecutará al menos una vez
        do
        {
          // Pedimos al usuario que ingrese el precio y cantidad del producto actual
          Console.Write("Ingrese el precio del producto {0}: $", i);
          precio = Convert.ToDouble(Console.ReadLine());

          Console.Write("Ingrese la cantidad del producto {0}: ", i); 
          cantidad = Convert.ToDouble(Console.ReadLine()); Console.WriteLine();
          // Sumamos el valor del producto actual al total
          total += precio * cantidad;
          // Aumentamos el contador del bucle
          i++;
          // El bucle do-while se ejecuta mientras no hayamos ingresado todos los productos deseados
        } while (i <= n);

        // Mostramos el valor total a pagar por todos los productos ingresados
        Console.WriteLine("El valor a pagar por los {0} productos es: ${1}", n, total);

        // Esperamos a que el usuario presione una tecla para salir del programa
        Console.ReadLine();
      }
      catch (Exception e)
      {
        System.Console.WriteLine("Se producto el siguiente error {0}", e.Message);
      }
    }
  }
}