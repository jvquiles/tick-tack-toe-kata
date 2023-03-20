// See https://aka.ms/new-console-template for more information

using TickTackToeKata.Console;

var game = new Game();
Console.WriteLine(game.PrintBoard());

while (true)
{
    Console.Write("Enter X coordinate: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Y coordinate: ");
    int y = Convert.ToInt32(Console.ReadLine());
    game.Move(x, y);
    Console.Clear();
    Console.WriteLine(game.PrintBoard());
}