namespace Kata;

public class Game
{
    public Game(string playerOne, string playerTwo)
    {
    }

    public string play(string firstElement, string secondElement)
    {
        if (firstElement == "ROCK")
        {
            return "ROCK";
        }

        if (firstElement == "SCISSORS")
        {
            if (secondElement == "PAPER")
            {
                return "SCISSORS";
            }
            return "ROCK";
        }

        return "PAPER";
    }
}
