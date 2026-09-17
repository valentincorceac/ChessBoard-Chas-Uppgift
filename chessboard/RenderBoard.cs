using System;
using System.Collections.Generic;
using System.Text;
using Spectre.Console;


namespace Chessboard
{
    public class RenderBoard
    {

        public int BoardSize {  get; set; }

        //GetSize method changes the property of a RenderBoard object to a user input, it also checks if the input is valid.
        public void GetSize()
        {
            int temp;
            while (!(int.TryParse(Console.ReadLine(), out temp)) || !(temp >= 3 && temp <= 50) || (3 * temp > Console.WindowWidth))
            {
                if ((temp * 3 > Console.WindowWidth) && (temp >= 3 && temp <= 50))
                {
                    AnsiConsole.MarkupLine("[red]The board would be too large for your current console window.\n" +
                                            "Please increase the size of your console window and try again or\n " +
                                            $"choose a number between 3 - {Console.WindowWidth / 3}:[/]");
                }
                else
                {
                    AnsiConsole.MarkupLine("[green]Type a number between 3 - 50:[/]");
                }
            }

            BoardSize = temp;
        }


        //method Draw takes a boardSize value and renders a check board in the console.
        public static void Draw(int boardSize)
        {
            for (int i = 1; i <= boardSize; i++)
            {
                for (int j = 1; j <= boardSize; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        AnsiConsole.Markup("[white on black]   [/]");
                    }
                    else
                    {
                        AnsiConsole.Markup("[black on white]   [/]");
                    }
                }
                AnsiConsole.MarkupLine("");

            }
        }

    }
}
