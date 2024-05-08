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

    [Test]
    public void SolveWithBalancedBracketsShouldReturnBalanced()
    {
        Assert.Multiple(() =>
        {
            Assert.That(_problemOne.Solve("[()()]"), Is.EqualTo("Balanced"));
            Assert.That(_problemOne.Solve("{[()]}"), Is.EqualTo("Balanced"));
            Assert.That(_problemOne.Solve("[()]{}{[()()]()}"), Is.EqualTo("Balanced"));
            Assert.That(_problemOne.Solve("{[()abc]}"), Is.EqualTo("Balanced"));
        });
    }

    [Test]
    public void SolveWithUnbalancedStringsShouldReturnNotBalanced()
    {
        Assert.Multiple(() =>
        {
            Assert.That(_problemOne.Solve("abcdefg"), Is.EqualTo("Not Balanced"));
            Assert.That(_problemOne.Solve("[(])"), Is.EqualTo("Not Balanced"));
            Assert.That(_problemOne.Solve("[(1]x2)3defgasjdk"), Is.EqualTo("Not Balanced"));
            Assert.That(_problemOne.Solve("[[[)[){}k)("), Is.EqualTo("Not Balanced"));
        });
    }
}