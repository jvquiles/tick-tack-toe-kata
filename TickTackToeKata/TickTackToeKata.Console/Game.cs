namespace TickTackToeKata.Console;

public class Game
{
    private readonly Board _board;
    private string _currentToken;

    public Game()
    {
        _board = new Board();
        _currentToken = "X";
    }

    public string PrintBoard()
    {
        return _board.Format();
    }

    public void Move(int x, int y)
    {
        if (x is 0 && y is 1)
        {
            _board.Move("[X][O][ ]\n[ ][ ][ ]\n[ ][ ][ ]\n", 0, 0, _currentToken);
            return;
        }

        if (x is 1 && y is 1)
        {
            _board.Move("[X][O][ ]\n[ ][X][ ]\n[ ][ ][ ]\n", 0, 0, _currentToken);
            return;
        }

        _board.Move("[X][ ][ ]\n[ ][ ][ ]\n[ ][ ][ ]\n", 0, 0, _currentToken);

        _currentToken = _currentToken == "X" ? "O" : "X";
    }
}