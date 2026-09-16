using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard
{
    public class RenderBoard
    {

        public static void GetSize(out int boardSize)
        {
            while (!(int.TryParse(Console.ReadLine(), out boardSize)) || !(boardSize >= 3 && boardSize <= 50))
            {
                Console.WriteLine("Type a number between 3 - 50");
            }
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
