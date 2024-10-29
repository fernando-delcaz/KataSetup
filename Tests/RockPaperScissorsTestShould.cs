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

    [Fact]
    public void PlayerOneWithRockBeatsPlayerTwoWithScissors()
    {
        var result = _game.play(Symbol.Rock, Symbol.Scissors);

        Assert.Equal(Symbol.Rock, result);
    }

    [Fact]
    public void PlayerOneWithPaperBeatsPlayerTwoWithRock()
    {
        var result = _game.play(Symbol.Paper, Symbol.Rock);

        Assert.Equal(Symbol.Paper, result);
    }

    [Fact]
    public void PlayerOneWithScissorsIsBeatenByPlayerTwoWithRock()
    { var result = _game.play(Symbol.Scissors, Symbol.Rock);

        Assert.Equal(Symbol.Rock, result);
    }

    [Fact]
    public void PlayerOneWithScissorsBeatsByPlayerTwoWithPaper()
    { var result = _game.play(Symbol.Scissors, Symbol.Paper);

        Assert.Equal(Symbol.Scissors, result);
    }
}


