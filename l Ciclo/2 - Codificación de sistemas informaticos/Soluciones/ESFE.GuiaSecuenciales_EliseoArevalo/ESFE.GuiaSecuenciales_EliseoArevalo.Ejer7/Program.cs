using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ESFE.GuiaSecuenciales_EliseoArevalo.Ejer7
{

  public class Program
  {
    static void Main(string[] args)
    {
      // 1BG == 1024 MB
      double GB, MB;
    
      Console.Write("Digite los GBs a convertir :"); 
      GB = Convert.ToDouble( Console.ReadLine() );
      MB = GB * 1024;

      Console.WriteLine(
        GB > 0 
        ? "{0} GB corresponde a {1} MB"
        : "VALOR ERRONEO" , GB, MB
      );
    }
  }
}