using System;

namespace PII_Game_Of_Life
{
    public class Tablero
    {
        public bool[,] Board {get; set;}
        public Tablero(bool[,] tablero)
        {
            this.Board = tablero;
        }
    }
}

/*La clase cumple con el principio SRP ya que cumple con un unica función (almacena el tablero en un objeto)*/