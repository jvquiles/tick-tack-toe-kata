namespace TickTackToeKata.Console;

public class Board
{
    private string _board;
    private string[,] _cells;

    public Board()
    {
        _cells = new string[3, 3];
        _board = "[ ][ ][ ]\n[ ][ ][ ]\n[ ][ ][ ]\n";
    }

    public string Format()
    {
        return _board;
    }

    public void Move(string board, int x, int y)
    {
        _cells[x, y] = "X";
        _board = board;
    }
}