using Chessboard;

Console.WriteLine("Welcome to chess board\nHow large do you want the board to be?\n(Answer with a number between 3 - 50): ");

int boardSize;



RenderBoard.GetSize(out boardSize);

RenderBoard.Draw(boardSize);