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
        _board.Move(x, y, _currentToken);
        _currentToken = _currentToken == "X" ? "O" : "X";
    }

    public string CheckEnd()
    {
        if (_board.HasPlayerFirstRow("X"))
        {
            return "Player X wins";
        }
        else if (_board.HasPlayerFirstRow("O"))
        {
            return "Player Y wins";
        }

        return "Not finished";
    }
}