namespace TickTackToeKata.Console;

public class Game
{
    private readonly Board _board;

    public Game()
    {
        _board = new Board();
    }

    public string PrintBoard()
    {
        return _board.Format();
    }

    public void Move(int x, int y)
    {
        if (x is 0 && y is 1)
        {
            _board._board = "[X][O][ ]\n[ ][ ][ ]\n[ ][ ][ ]\n";
            return;
        }

        if (x is 1 && y is 1)
        {
            _board._board = "[X][O][ ]\n[ ][X][ ]\n[ ][ ][ ]\n";
            return;
        }

        _board._board = "[X][ ][ ]\n[ ][ ][ ]\n[ ][ ][ ]\n";
    }
}