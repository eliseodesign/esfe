using System;
namespace ESFE.Ejercicios
  {

  public class Triangulo
  {

    public void Verificar()
    {
      Console.WriteLine("QUE TRIANGULO ES");

      Console.WriteLine("Introduce primer lado");
      double primero = Convert.ToDouble( Console.ReadLine() );

      Console.WriteLine("Introduce segundo lado");
      double segundo = Convert.ToDouble( Console.ReadLine() );

      Console.WriteLine("Introduce tercer lado");
      double tercero = Convert.ToDouble( Console.ReadLine() );

      if(primero > 0 && segundo > 0 && tercero >0)
      {
        if(primero == segundo && segundo == tercero)
      {
        Console.WriteLine("Es Equilatero");
      }
      else if(primero != segundo && segundo != tercero && tercero != primero)
      {
        Console.WriteLine("Es Escaleno");
      }
      else
      {
        Console.WriteLine("Es Isóceles");
      }
      }
    }

  }
}