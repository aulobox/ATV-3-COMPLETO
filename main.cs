using System;

class Program {
  public static void Main (string[] args) {

    
    String macas;
    Double valor1, macasQ;
     Console.Write("Digite o numero de maças :");
     macas=Console.ReadLine();  
     macasQ=Double.Parse(macas);
     if (macasQ <= 6)
     {
      valor1 = (macasQ * 1.3);
       Console.Write("O valor das maças é : " + valor1);
     }
    else
    {
      valor1 = (macasQ * 1);
       Console.Write("O valor das maças é : " + valor1);
    }

    











    
  }
}