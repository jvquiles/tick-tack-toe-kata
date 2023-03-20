using TickTackToeKata.Console;

namespace TickTackToeKata.Tests;

[TestFixture]
public class GameShould
{
    private Game _game;

    [SetUp]
    public void Setup()
    {
        _game = new Game();
    }
    
    [Test]
    public void PrintEmptyBoard()
    {
        var result = _game.PrintBoard();
        Assert.That(result, Is.EqualTo("[ ][ ][ ]\n[ ][ ][ ]\n[ ][ ][ ]\n"));
    }

    [Test]
    public void DoFirstMove()
    {
        _game.Move(0, 0);
        var result = _game.PrintBoard();
        Assert.That(result, Is.EqualTo("[X][ ][ ]\n[ ][ ][ ]\n[ ][ ][ ]\n"));
    }

    [Test]
    public void DoSecondMove()
    {
        _game.Move(0, 0);
        _game.Move(0, 1);
        var result = _game.PrintBoard();
        Assert.That(result, Is.EqualTo("[X][O][ ]\n[ ][ ][ ]\n[ ][ ][ ]\n"));
    }

    [Test]
    public void DoThirdMove()
    {
        _game.Move(0,0);
        _game.Move(0,1);
        _game.Move(1,1);
        var result = _game.PrintBoard();
        Assert.That(result, Is.EqualTo("[X][O][ ]\n[ ][X][ ]\n[ ][ ][ ]\n"));
    }
}