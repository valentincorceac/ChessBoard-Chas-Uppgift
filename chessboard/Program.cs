Console.WriteLine("Welcome to chess board\nHow large do you want the board to be?\n(Answer with a number between 3 - 50): ");

int boardSize;



while(!(int.TryParse(Console.ReadLine(), out boardSize)) || !(boardSize >= 3 && boardSize <= 50))
{
    Console.WriteLine("Type a number between 3 - 50");
}


for(int i = 1; i <= boardSize; i++)
{
    for(int j = 1; j <= boardSize; j++)
    {
        if((j % 2 == 0) && (i % 2 == 0))
        {
            Console.Write("X ");
        }
        else if ((j % 2 == 0) && !(i % 2 == 0))
        {
            Console.Write("0 ");
        }else if(!(j % 2 == 0) && !(i %2 == 0))
        {
            Console.Write("X ");
        }
        else
        {
            Console.Write("0 ");
        }
    }
    Console.WriteLine();

}