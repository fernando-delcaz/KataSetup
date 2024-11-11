namespace Kata;

public enum Symbol
{
    Rock,
    Scissors,
    Paper
}

public class Game
{
    private readonly Dictionary<Symbol, Symbol> _winningMovement = new()
    {
        { Symbol.Rock, Symbol.Paper },
        { Symbol.Paper, Symbol.Scissors },
        { Symbol.Scissors, Symbol.Rock },
    };

    public Symbol Play(Symbol oneElement, Symbol anotherElement)
    {

        if (_winningMovement[oneElement] == anotherElement)
        {
            return anotherElement;
        }

        if (_winningMovement[anotherElement] == oneElement)
        {
            return oneElement;
        }

        return Symbol.Scissors;
    }
}
