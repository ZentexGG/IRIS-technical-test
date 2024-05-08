using IRISTechnicalSolution.Interfaces;
using IRISTechnicalSolution.Problems;

namespace IRISTechnicalSolutionTest.ProblemTests;

public class ProblemTwoTests
{
    private IProblemTwo _problemTwo;
    [SetUp]
    public void Setup()
    {
        _problemTwo = new ProblemTwo();
    }
    
    // Testing correct array values
    [Test]
    public void SolveWithCorrectParamShouldReturnCorrectValueCase1()
    {
        Assert.That(_problemTwo.Solve(new[] { 2, 2, 1 }), Is.EqualTo(1));
    }

    [Test]
    public void SolveWithCorrectParamShouldReturnCorrectValueCase2()
    {
        Assert.That(_problemTwo.Solve(new[] { 4, 1, 2, 1, 2 }), Is.EqualTo(4)); 
    }

    [Test]
    public void SolveWithCorrectParamShouldReturnCorrectValueCase3()
    {
        Assert.That(_problemTwo.Solve(new[] { 1 }), Is.EqualTo(1));
    }

    // Testing incorrect inputs
    [Test]
    public void SolveWithEvenLengthArrayParamShouldThrowErr()
    {
        var incorrectArrLength = Assert.Throws<ArgumentException>(() => _problemTwo.Solve(new[] {1,1,2,2}));
        Assert.That(incorrectArrLength?.Message, Is.EqualTo("The array must have an odd length in order to be valid"));
    }

    [Test]
    public void SolveWithMultipleUniqueNumsShouldThrowErr()
    {
        var multipleUniqueNums = Assert.Throws<ArgumentException>(() => _problemTwo.Solve(new[] {1,1,2,3,5,9,10}));
        Assert.That(multipleUniqueNums?.Message, Is.EqualTo("The array must have a single unique number."));
    }

    [Test]
    public void SolveWithNoUniqueNumsShouldThrowErr()
    {
        var noUniqueNums = Assert.Throws<ArgumentException>(() => _problemTwo.Solve(new[] {1,1,1}));
        Assert.That(noUniqueNums?.Message, Is.EqualTo("The array must have at least one unique number."));
    }
}