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

    public string GetCurrentToken()
    {
        return _currentToken;
    }

    public string CheckEnd()
    {
        if (_board.HasPlayerRow("X", 0)
            || _board.HasPlayerRow("X", 1)
            || _board.HasPlayerRow("X", 2)
            || _board.HasPlayerColumn("X", 0)
            || _board.HasPlayerColumn("X", 1)
            || _board.HasPlayerColumn("X", 2)
            || _board.HasPlayerFirstDiagonal("X")
            || _board.HasPlayerSecondDiagonal("X"))
        {
            return "Player X wins";
        }

        if (_board.HasPlayerRow("O", 0)
            || _board.HasPlayerRow("O", 1)
            || _board.HasPlayerRow("O", 2)
            || _board.HasPlayerColumn("O", 0)
            || _board.HasPlayerColumn("O", 1)
            || _board.HasPlayerColumn("O", 2)
            || _board.HasPlayerFirstDiagonal("O")
            || _board.HasPlayerSecondDiagonal("O"))
        {
            return "Player O wins";
        }

        if (_board.HasEmptyCells())
        {
            return "Not finished";
        }

        return "No winner";
    }
}