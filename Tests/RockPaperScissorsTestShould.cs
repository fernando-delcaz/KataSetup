using Kata;

namespace Tests;

public class RockPaperScissorsTestShould
{
    private readonly Game _game;

    public RockPaperScissorsTestShould()
    {
        var game = new Game();
        _game = game;
    }

    [Theory]
    [InlineData(Symbol.Rock, Symbol.Scissors)]
    [InlineData(Symbol.Scissors, Symbol.Rock)]
    public void RockBeatsScissors(Symbol one, Symbol another)
    {
        var result = _game.play(one, another);

        Assert.Equal(Symbol.Rock, result);
    }

    [Theory]
    [InlineData(Symbol.Paper, Symbol.Rock)]
    [InlineData(Symbol.Rock, Symbol.Paper)]
    public void PaperBeatsRock(Symbol one, Symbol another)
    {
        var result = _game.play(one, another);

        Assert.Equal(Symbol.Paper, result);
    }

    [Theory]
    [InlineData(Symbol.Paper, Symbol.Scissors)]
    [InlineData(Symbol.Scissors, Symbol.Paper)]
    public void ScissorsBeatsPaper(Symbol one, Symbol another)
    {
        var result = _game.play(one, another);

        Assert.Equal(Symbol.Scissors, result);
    }
}
