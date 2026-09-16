using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    public class RenderBoard
    {

        public int BoardSize {  get; set; }

        //public RenderBoard(int boardSize)
        //{
        //    BoardSize = boardSize;
        //}





        public void GetSize()
        {
            int temp;
            while (!(int.TryParse(Console.ReadLine(), out temp)) || !(temp >= 3 && temp <= 50))
            {
                Console.WriteLine("Type a number between 3 - 50");
            }

            BoardSize = temp;
        }

        public static void Draw(int boardSize)
        {
            for (int i = 1; i <= boardSize; i++)
            {
                for (int j = 1; j <= boardSize; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("◻︎ ");
                    }
                    else
                    {
                        Console.Write("◼︎ ");
                    }
                }
                Console.WriteLine();

            }
        }

    }
}
