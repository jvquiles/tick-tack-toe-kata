using TickTackToeKata.Console;

var game = new Game();
Console.WriteLine(game.PrintBoard());

string result;
do 
{
    Console.WriteLine($"Is the {game.GetCurrentToken()} player turn.");
    Console.Write("Enter X coordinate: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Y coordinate: ");
    int y = Convert.ToInt32(Console.ReadLine());
    game.Move(x, y);
    Console.Clear();
    Console.WriteLine(game.PrintBoard());
    result = game.CheckEnd();
} while (result == "Not finished");

Console.WriteLine(result);