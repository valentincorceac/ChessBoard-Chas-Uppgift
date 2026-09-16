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


    }
}
