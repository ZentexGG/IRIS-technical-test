using IRISTechnicalSolution.Interfaces;
using IRISTechnicalSolution.Problems;

namespace IRISTechnicalSolutionTest.ProblemTests;

public class ProblemOneTests
{
    private IProblemOne _problemOne;
    [SetUp]
    public void Setup()
    {
        _problemOne = new ProblemOne();
    }

    // Testing balanced inputs
    
    [Test]
    public void SolveWithBalancedBracketsShouldReturnBalancedCase1()
    {

        Assert.That(_problemOne.Solve("[()()]"), Is.EqualTo("Balanced"));
    }
    [Test]
    public void SolveWithBalancedBracketsShouldReturnBalancedCase2()
    {
        Assert.That(_problemOne.Solve("{[()]}"), Is.EqualTo("Balanced"));
    }
    [Test]
    public void SolveWithBalancedBracketsShouldReturnBalancedCase3()
    {
        Assert.That(_problemOne.Solve("[()]{}{[()()]()}"), Is.EqualTo("Balanced"));
    }
    [Test]
    public void SolveWithBalancedBracketsAndTextShouldReturnBalanced()
    {
        Assert.That(_problemOne.Solve("{[()abc]}"), Is.EqualTo("Balanced"));
    }

    // Testing unbalanced strings
    
    [Test]
    public void SolveWithUnbalancedStringShouldReturnNotBalancedCase1()
    {
        Assert.That(_problemOne.Solve("[(])"), Is.EqualTo("Not Balanced"));
    }

    [Test]
    public void SolveWithUnbalancedStringShouldReturnNotBalancedCase2()
    {
        Assert.That(_problemOne.Solve("[[[)[){})("), Is.EqualTo("Not Balanced"));
    }

    [Test]
    public void SolveWithUnbalancedStringShouldReturnNotBalancedCase3()
    {
        Assert.That(_problemOne.Solve("(()"), Is.EqualTo("Not Balanced"));
    }

    [Test]
    public void SolveWithUnbalancedStringAndTextShouldReturnNotBalanced()
    {
        Assert.That(_problemOne.Solve("[(1]x2)3defgasjdk"), Is.EqualTo("Not Balanced"));
    }

    [Test]
    public void SolveWithStringContainingNoBracketsShouldReturnNotBalanced()
    {
        Assert.That(_problemOne.Solve("abcdefg"), Is.EqualTo("Not Balanced"));
    }
    
}