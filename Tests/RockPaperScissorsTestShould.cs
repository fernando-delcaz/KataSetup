using Kata;

namespace Tests;

public class RockPaperScissorsTestShould
{
    [Fact]
    public void PlayerOneWithRockBeatsPlayerTwoWithScissors()
    {
        var playerOne = "Manu";
        var playerTwo = "Fer";
        var game = new Game(playerOne, playerTwo);

        var result = game.play("ROCK", "SCISSORS");

        Assert.Equal("ROCK", result);
    }

    [Fact]
    public void PlayerOneWithPaperBeatsPlayerTwoWithRock()
    {
        var playerOne = "Manu";
        var playerTwo = "Fer";
        var game = new Game(playerOne, playerTwo);

        var result = game.play("PAPER", "ROCK");

        Assert.Equal("PAPER", result);
    }
}

