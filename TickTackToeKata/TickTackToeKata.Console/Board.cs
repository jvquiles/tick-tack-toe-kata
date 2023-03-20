namespace TickTackToeKata.Console;

public class Board
{
    private string _board;

    public Board()
    {
        _board = "[ ][ ][ ]\n[ ][ ][ ]\n[ ][ ][ ]\n";
    }

    public string Format()
    {
        return _board;
    }

    public void Move(string board, int x, int y)
    {
        _board = board;
    }
}