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
    public void LetPlayerOWinByFirstRow()
    {
        _game.Move(1, 0);
        _game.Move(0, 0);
        _game.Move(1, 1);
        _game.Move(0, 1);
        _game.Move(2, 2);
        _game.Move(0, 2);
        var result = _game.CheckEnd();
        Assert.That(result, Is.EqualTo("Player O wins"));
    }

    [Test]
    public void LetPlayerXWinByFirstColumn()
    {
        _game.Move(0, 0);
        _game.Move(0, 1);
        _game.Move(1, 0);
        _game.Move(1, 1);
        _game.Move(2, 0);
        var result = _game.CheckEnd();
        Assert.That(result, Is.EqualTo("Player X wins"));
    }

    [Test]
    public void LetPlayerOWinByFirstColumn()
    {
        _game.Move(0, 1);
        _game.Move(0, 0);
        _game.Move(1, 1);
        _game.Move(1, 0);
        _game.Move(2, 2);
        _game.Move(2, 0);
        var result = _game.CheckEnd();
        Assert.That(result, Is.EqualTo("Player O wins"));
    }

    [Test]
    public void LetPlayerXWinBySecondRow()
    {
        _game.Move(1, 0);
        _game.Move(0, 0);
        _game.Move(1, 1);
        _game.Move(0, 1);
        _game.Move(1, 2);
        var result = _game.CheckEnd();
        Assert.That(result, Is.EqualTo("Player X wins"));
    }

    [Test]
    public void LetPlayerOWinBySecondRow()
    {
        _game.Move(0, 0);
        _game.Move(1, 0);
        _game.Move(0, 1);
        _game.Move(1, 1);
        _game.Move(2, 0);
        _game.Move(1, 2);
        var result = _game.CheckEnd();
        Assert.That(result, Is.EqualTo("Player O wins"));
    }

    [Test]
    public void LetPlayerXWinBySecondColumn()
    {
        _game.Move(0, 1);
        _game.Move(0, 0);
        _game.Move(1, 1);
        _game.Move(1, 0);
        _game.Move(2, 1);
        var result = _game.CheckEnd();
        Assert.That(result, Is.EqualTo("Player X wins"));
    }

    [Test]
    public void LetPlayerOWinBySecondColumn()
    {
        _game.Move(0, 0);
        _game.Move(0, 1);
        _game.Move(0, 2);
        _game.Move(1, 1);
        _game.Move(2, 2);
        _game.Move(2, 1);
        var result = _game.CheckEnd();
        Assert.That(result, Is.EqualTo("Player O wins"));
    }

    [Test]
    public void LetPlayerXWinByThirdColumn()
    {
        _game.Move(0 ,2);
        _game.Move(0 ,0);
        _game.Move(1 ,2);
        _game.Move(0 ,1);
        _game.Move(2 ,2);
        var result = _game.CheckEnd();
        Assert.That(result, Is.EqualTo("Player X wins"));
    }

    [Test]
    public void LetPlayerOWinByThirdColumn()
    {
        _game.Move(0, 0);
        _game.Move(0, 2);
        _game.Move(0, 1);
        _game.Move(1, 2);
        _game.Move(1, 0);
        _game.Move(2, 2);
        var result = _game.CheckEnd();
        Assert.That(result, Is.EqualTo("Player O wins"));
    }

    [Test]
    public void LetPlayerXWinByThirdRow()
    {
        _game.Move(2, 0);
        _game.Move(0, 0);
        _game.Move(2, 1);
        _game.Move(1, 1);
        _game.Move(2, 2);
        var result = _game.CheckEnd();
        Assert.That(result, Is.EqualTo("Player X wins"));
    }

    [Test]
    public void LeyPlayerOWinByThirdRow()
    {
        _game.Move(0, 0);
        _game.Move(2, 0);
        _game.Move(0, 1);
        _game.Move(2, 1);
        _game.Move(1, 1);
        _game.Move(2, 2);
        var result = _game.CheckEnd();
        Assert.That(result, Is.EqualTo("Player O wins"));
    }

    [Test]
    public void LeyPlayerXWinByFirstDiagonal()
    {
        _game.Move(0, 0);
        _game.Move(0, 1);
        _game.Move(1, 1);
        _game.Move(1, 0);
        _game.Move(2, 2);
        var result = _game.CheckEnd();
        Assert.That(result, Is.EqualTo("Player X wins"));
    }

    [Test]
    public void LetPlayerOWinByFirstDiagonal()
    {
        _game.Move(0, 1);
        _game.Move(0, 0);
        _game.Move(1, 0);
        _game.Move(1, 1);
        _game.Move(0, 2);
        _game.Move(2, 2);
        var result = _game.CheckEnd();
        Assert.That(result, Is.EqualTo("Player O wins"));
    }

    [Test]
    public void LetPlayerXWinBySecondDiagonal()
    {
        _game.Move(0, 2);
        _game.Move(0, 0);
        _game.Move(1, 1);
        _game.Move(2, 2);
        _game.Move(2, 0);
        var result = _game.CheckEnd();
        Assert.That(result, Is.EqualTo("Player X wins"));
    }
}