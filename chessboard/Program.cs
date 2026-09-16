using Chessboard;

Console.WriteLine("Welcome to chess board\nHow large do you want the board to be?\n(Answer with a number between 3 - 50): ");

int boardSize;



RenderBoard.GetSize(out boardSize);


for(int i = 1; i <= boardSize; i++)
{
    for(int j = 1; j <= boardSize; j++)
    {
        if ((i + j) % 2 == 0 )
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