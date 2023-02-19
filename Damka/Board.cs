using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Damka
{
    class Board
    {
        private Square[,] board;


        public Board()
        {

            board = new Square[8, 8];



            int turn = 0;
            bool[,] colors = new bool[8, 8]; 
            for (int row = 0; row < colors.GetLength(0); row++)
            {
                if (row % 2 == 0)
                    turn = 0;
                else
                    turn = 1;
                for (int col = 0; col < colors.GetLength(1); col++)
                {
                    if (turn == 0)
                    {
                        colors[row, col] = true;
                        Console.Write("t   ");
                        turn++;
                    }
                    else
                    {
                        colors[row, col] = false;
                        Console.Write("f   ");
                        turn--;
                    }


                }
                Console.WriteLine("");
            }//checking colors of squares

            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (row <= 3 && colors[row, col])
                        board[row, col] = new Square(new Checker(true));
                    if (row >= 6 && !colors[row, col])
                        board[row, col] = new Square(new Checker(false));

                }
            }


        }
        
    }

}
