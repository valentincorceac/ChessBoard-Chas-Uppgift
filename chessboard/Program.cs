using Chessboard;

Console.WriteLine("Welcome to chess board\nHow large do you want the board to be?\n(Answer with a number between 3 - 50): ");

RenderBoard ChessBoard = new RenderBoard();


ChessBoard.GetSize();


RenderBoard.Draw(ChessBoard.BoardSize);