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

    [Fact]
    public void PlayerOneWithScissorsIsBeatenByPlayerTwoWithRock()
    {
        var result = _game.play(Symbol.Scissors, Symbol.Rock);

        Assert.Equal(Symbol.Rock, result);
    }

    [Fact]
    public void PlayerOneWithScissorsBeatsByPlayerTwoWithPaper()
    {
        var result = _game.play(Symbol.Scissors, Symbol.Paper);

        Assert.Equal(Symbol.Scissors, result);
    }
}
