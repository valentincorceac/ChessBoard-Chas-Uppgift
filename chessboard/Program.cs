using Chessboard;

//Writes greeting to console
Console.WriteLine("Welcome to chess board\nHow large do you want the board to be?\n(Answer with a number between 3 - 50): ");

//Creates new object ChessBoard
RenderBoard ChessBoard = new RenderBoard();

//Uses GetSize method to set BoardSize
ChessBoard.GetSize();

//Renders the chessboard using the Draw method
RenderBoard.Draw(ChessBoard.BoardSize);