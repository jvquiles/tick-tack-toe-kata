﻿namespace TickTackToeKata.Tests;

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
}