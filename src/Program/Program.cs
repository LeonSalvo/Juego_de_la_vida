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

/*El program es el experto de información de nuestro proyecto ya que es el que llama y dirige a todas las clases */