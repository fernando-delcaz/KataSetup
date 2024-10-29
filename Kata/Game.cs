namespace Kata;

public enum Symbol
{
    Rock,
    Scissors,
    Paper
}

public class Game
{
    public Symbol play(Symbol oneElement, Symbol anotherElement)
    {
        if (oneElement == Symbol.Rock && anotherElement == Symbol.Scissors)
        {
            return Symbol.Rock;
        }

        if (oneElement == Symbol.Scissors && anotherElement == Symbol.Paper)
        {
            return Symbol.Scissors;
        }

        if (oneElement == Symbol.Paper && anotherElement == Symbol.Rock)
        {
            return Symbol.Paper;
        }

        return Symbol.Rock;
    }
}
