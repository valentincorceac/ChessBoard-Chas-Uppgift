using Chessboard;
using Spectre.Console;


//Writes greeting to console
AnsiConsole.MarkupLine("[bold]Welcome to chess board\nHow large do you want the board to be?[/]\n[green](Answer with a number between 3 - 50): [/]");

//Creates new object ChessBoard
ChessBoard board = new ChessBoard();

//Uses GetSize method to set BoardSize
board.GetSize();

//Renders the chessboard using the Draw method
ChessBoard.Draw(board.BoardSize);