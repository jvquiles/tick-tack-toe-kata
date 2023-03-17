namespace TickTackToeKata.Tests;

public class Game
{
    private string _board;

    public Game()
    {
        _board = "[ ][ ][ ]\n[ ][ ][ ]\n[ ][ ][ ]\n";
    }

    public string PrintBoard()
    {
        return _board;
    }

    public void Move(int x, int y)
    {
        _board = "[X][ ][ ]\n[ ][ ][ ]\n[ ][ ][ ]\n";
    }
}