using IRISTechnicalSolution.Interfaces;

namespace IRISTechnicalSolution.Problems;

// Current solution ignores characters that aren't brackets
public class ProblemOne : IProblemOne
{
    private readonly Dictionary<char, char> _bracketPairs = new()
    {
        { '(', ')' },
        { '[', ']' },
        { '{', '}' }
    };

    public string Solve(string exp)
    {
        var openingBracketsStack = new Stack<char>();
        var stringHasBrackets = false;

        foreach (var c in exp)
        {
            if (!IsBracket(c)) continue;
            
            if (_bracketPairs.ContainsKey(c))
            {
                stringHasBrackets = true;
                openingBracketsStack.Push(c);
            }
            else if (openingBracketsStack.Count == 0 || _bracketPairs[openingBracketsStack.Pop()] != c)
            {
                return "Not Balanced";
            }
        }

        return openingBracketsStack.Count == 0 && stringHasBrackets  ? "Balanced" : "Not Balanced";
    }

    private bool IsBracket(char c)
    {
        return _bracketPairs.ContainsKey(c) || _bracketPairs.ContainsValue(c);
    }
}