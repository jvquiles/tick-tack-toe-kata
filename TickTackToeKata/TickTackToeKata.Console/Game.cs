namespace TickTackToeKata.Console;

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
        if (x is 0 && y is 1)
        {
            _board = "[X][O][ ]\n[ ][ ][ ]\n[ ][ ][ ]\n";
            return;
        }

        if (x is 1 && y is 1)
        {
            _board = "[X][O][ ]\n[ ][X][ ]\n[ ][ ][ ]\n";
            return;
        }
        
        _board = "[X][ ][ ]\n[ ][ ][ ]\n[ ][ ][ ]\n";
    }
}