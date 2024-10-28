using Kata;

namespace Tests;

public class RockPaperScissorsTestShould
{
    [Fact]
    public void MakeRockBeatScissors()
    {
        var playerOne = "Manu";
        var playerTwo = "Fer";
        var game = new Game(playerOne, playerTwo);

        var result = game.play("ROCK", "SCISSORS");

        Assert.Equal("ROCK", result);
    }


}

