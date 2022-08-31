using System;
using System.Threading;
namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Tablero Tablero1 = new Tablero(LectorArchivo.LeerArchivo( @"../../assets/board.txt"));
            while(true)
            {
                Console.WriteLine(Printer.Imprimir(Tablero1));
                Logica.Juego(Tablero1);
                Thread.Sleep(300);
            }
        }
    }
}
