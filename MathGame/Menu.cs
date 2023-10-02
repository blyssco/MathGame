namespace MathGame
{
    internal class Menu
    {
        GameEngine engine = new();
        internal void ShowMenu(string name, DateTime date)
        {
                Console.Clear();

                Console.WriteLine("--------------------------------------------");
                Console.WriteLine($"Hello {name.ToUpper()}. It's {date}. That's great that you're working on improving yourself\n");
                Console.WriteLine("Press any key to show menu");

                Console.ReadLine();

                Console.WriteLine("\n");

            var isGameOn = true;

            do
            {
                Console.Clear() ;
                Console.WriteLine($@"What game would you like to play today ? Choose from the options below:
                        V - View Previous Games
                        A - Addition
                        S - Substraction
                        M - Multiplication
                        D - Division
                        Q - Quit the program"
                );
                Console.WriteLine("--------------------------------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        engine.AdditionGame("Addition game");
                        break;
                    case "s":
                        engine.SubstractionGame("Substraction game");
                        break;
                    case "m":
                        engine.MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        engine.DivisionGame("Division game");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (isGameOn);
        }
    }
}
