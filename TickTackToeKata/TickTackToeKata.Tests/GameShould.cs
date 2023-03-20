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

    [Test]
    public void LetPlayerXWinByFirstRow()
    {
        _game.Move(0, 0);
        _game.Move(1, 0);
        _game.Move(0, 1);
        _game.Move(1, 1);
        _game.Move(0, 2);
        var result = _game.CheckEnd();
        Assert.That(result, Is.EqualTo("Player X wins"));
    }

    [Test]
    public void LetPlayerYWinByFirstRow()
    {
        _game.Move(1, 0);
        _game.Move(0, 0);
        _game.Move(1, 1);
        _game.Move(0, 1);
        _game.Move(1, 2);
        _game.Move(0,2);
        var result = _game.CheckEnd();
        Assert.That(result, Is.EqualTo("Player Y wins"));
    }
}