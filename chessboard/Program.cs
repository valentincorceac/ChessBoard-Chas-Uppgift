Console.WriteLine("Welcome to chess board\nHow large do you want the board to be?\n(Answer with a number between 3 - 50): ");

int boardSize;



while(!(int.TryParse(Console.ReadLine(), out boardSize)))
{
    Console.WriteLine("Type a number between 3 - 50");
}