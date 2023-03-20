namespace TickTackToeKata.Console;

public class Board
{
    internal string _board;

    public Board()
    {
        _board = "[ ][ ][ ]\n[ ][ ][ ]\n[ ][ ][ ]\n";
    }

    public string Format()
    {
        return _board;
    }

    public void Move(string board)
    {
        _board = board;
    }
}