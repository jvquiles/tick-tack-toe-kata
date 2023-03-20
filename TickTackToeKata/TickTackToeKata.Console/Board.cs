using System.Text;

namespace TickTackToeKata.Console;

public class Board
{
    private string[,] _cells;

    public Board()
    {
        _cells = new string[3, 3];
    }

    public string Format()
    {
        var result = new StringBuilder();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                result.Append($"[{FormatCell(_cells[i, j])}]");
            }

            result.Append("\n");
        }
        
        return result.ToString();
    }

    private string FormatCell(string cell)
    {
        return cell switch
        {
            "X" => "X",
            "O" => "O",
            _ => " "
        };
    }

    public void Move(int x, int y, string token)
    {
        _cells[x, y] = token;
    }
}