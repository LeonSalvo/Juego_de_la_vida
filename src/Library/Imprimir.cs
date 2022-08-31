using System;
using System.Text;
namespace PII_Game_Of_Life
{
    public class Printer
    {
        public static string Imprimir(Tablero tablero)
        {
            bool[,] b = tablero.Board; //variable que representa el tablero
            int width = tablero.Board.GetLength(0);  //variabe que representa el ancho del tablero
            int height = tablero.Board.GetLength(1);  //variabe que representa altura del tablero
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y<height;y++)
            {
                for (int x = 0; x<width; x++)
                {
                    if(b[x,y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            return s.ToString();
        }
    }
}