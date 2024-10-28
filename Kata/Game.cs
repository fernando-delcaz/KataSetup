namespace Kata;

public class Game
{
    public Game(string playerOne, string playerTwo)
    {
    }

    public String play(string firstElement, string secondElement)
    {
        if (firstElement == "ROCK")
        {
            return "ROCK";
        }

        return "PAPER";

    }
}
