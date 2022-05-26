using System;
   class Formatacao
   {
       static void Main()
       {
        double valcompra = 5.50;
        double valvenda;
        double lucro = 0.1;
        string produto = "Pastel";
        valvenda = valcompra + (valcompra * lucro);

        Console.WriteLine("Produto..........{0,15}",produto);
        Console.WriteLine("Val.compra.......{0,15:c}",valcompra);
        Console.WriteLine("Lucro............{0,15:p}",lucro);
        Console.WriteLine("Val.venda........{0,15:c}",valvenda);
       }

    }
