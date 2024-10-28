using Kata;

namespace Tests;

public class RockPaperScissorsTestShould
{
    private readonly Game _game;
    private const string PlayerOne = "Manu";
    private const string PlayerTwo = "Fer";

    public RockPaperScissorsTestShould()
    {
        var game = new Game(PlayerOne, PlayerTwo);
        _game = game;
    }

    [Fact]
    public void PlayerOneWithRockBeatsPlayerTwoWithScissors()
    {
        var result = _game.play("ROCK", "SCISSORS");

        Assert.Equal("ROCK", result);
    }

    [Fact]
    public void PlayerOneWithPaperBeatsPlayerTwoWithRock()
    {
        var result = _game.play("PAPER", "ROCK");

        Assert.Equal("PAPER", result);
    }

    [Fact]
    public void PlayerOneWithScissorsIsBeatenByPlayerTwoWithRock()
    { var result = _game.play("SCISSORS", "ROCK");

        Assert.Equal("ROCK", result);
    }

    [Fact]
    public void PlayerOneWithScissorsBeatsByPlayerTwoWithPaper()
    { var result = _game.play("SCISSORS", "PAPER");

        Assert.Equal("SCISSORS", result);
    }
}


