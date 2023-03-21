using System.Text;

namespace TickTackToeKata.Console;

public class Board
{
    private string[,] _cells;

    public Board()
    {
        _cells = new[,] { { " ", " ", " " }, {" ", " ", " "}, {" ", " ", " "} };
    }

    public string Format()
    {
        var result = new StringBuilder();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                result.Append($"[{_cells[i, j]}]");
            }

            result.Append("\n");
        }
        
        return result.ToString();
    }

    public void Move(int x, int y, string token)
    {
        _cells[x, y] = token;
    }

    public bool HasPlayerFirstRow(string token)
    {
        return _cells[0, 0] == token && _cells[0, 1] == token && _cells[0, 2] == token;
    }

    public bool HasPlayerFirstColumn(string token)
    {
        return _cells[0, 0] == token && _cells[1, 0] == token && _cells[2, 0] == token;
    }
}