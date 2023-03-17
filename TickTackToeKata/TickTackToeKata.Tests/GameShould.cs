using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace TickTackToeKata.Tests;

[TestFixture]
public class GameShould
{
    private Game _game;

    [SetUp]
    public void Setup()
    {
        _game = new Game(3, 3);
    }
    
    [Test]
    public void PrintEmptyBoard()
    {
        var result = _game.PrintBoard();
        Assert.That(result, Is.EqualTo("[ ][ ][ ]\n[ ][ ][ ]\n[ ][ ][ ]\n"));
    }
}

public class Game
{
    public Game(int i, int i1)
    {
    }

    public string PrintBoard()
    {
        return "[ ][ ][ ]\n[ ][ ][ ]\n[ ][ ][ ]\n";
    }
}