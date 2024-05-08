using IRISTechnicalSolution.Interfaces;
using IRISTechnicalSolution.Problems;

var problemOne = new ProblemOne();
var problemTwo = new ProblemTwo();

Console.WriteLine("PROBLEM 1");
Console.WriteLine("Input: \"[()]{}{[()()]()}\" ; Expected: Balanced ; Actual: " + problemOne.Solve("[()]{}{[()()]()}"));
Console.WriteLine("Input: \"[(])\" ; Expected: Not Balanced ; Actual: " + problemOne.Solve("[(])"));

Console.WriteLine("\n");

Console.WriteLine("PROBLEM 2");
Console.WriteLine("Input: [2,2,1] ; Expected: 1 ; Actual: " + problemTwo.Solve(new[] {2,2,1}));
Console.WriteLine("Input: [4,1,2,1,2] ; Expected: 4 ; Actual: " + problemTwo.Solve(new[] {4,1,2,1,2}));
Console.WriteLine("Input: [1] ; Expected: 1 ; Actual: " + problemTwo.Solve(new[] {1}));

