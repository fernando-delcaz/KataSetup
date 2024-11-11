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
        HashSet<Symbol> symbols = new HashSet<Symbol>();
        symbols.Add(oneElement);
        symbols.Add(anotherElement);

        if (symbols.Contains(Symbol.Paper) && symbols.Contains(Symbol.Rock))
        {
            return Symbol.Paper;
        }

        if (symbols.Contains(Symbol.Scissors) && symbols.Contains(Symbol.Rock))
        {
            return Symbol.Rock;
        }

        return Symbol.Scissors;
    }
}
