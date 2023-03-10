using System;
namespace ESFE.Ejercicios
  {

  public class QueTecla
  {

    public void Verificar()
    {
      char[] vocales = new char[]{"a","e","i","o", "u"};

      char tecla = Console.ReadKey().KeyChar;

      bool esVocal = false;

      foreach (char vocal in vocales){

        if (Char.ToLower(tecla) == vocal)
          {
              esVocal = true;
              break;
          }
      }

      System.Console.WriteLine(esVocal);

    }

  }
}