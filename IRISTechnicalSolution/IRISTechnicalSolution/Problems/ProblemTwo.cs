using IRISTechnicalSolution.Interfaces;
namespace IRISTechnicalSolution.Problems;
// Current solution assumes there can be wrong inputs
public class ProblemTwo : IProblemTwo
{
    public int Solve(int[] nums)
    {
        if (nums.Length % 2 == 0)
        {
            throw new ArgumentException("The array must have an odd length in order to be valid");
        }

        var uniqueNumberFound = 0;
        var uniqueNumberCount = 0;
        foreach (var num in nums)
        {
            if (nums.Count(i => i == num) != 1) continue;
            uniqueNumberCount++;
            uniqueNumberFound = num;
            if (uniqueNumberCount > 1)
            {
                throw new ArgumentException("The array must have a single unique number.");
            }
        }

        if (uniqueNumberCount == 0)
        {
            throw new ArgumentException("The array must have at least one unique number.");
        }

        return uniqueNumberFound;
    }
}