using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

var matrix1 = DenseMatrix.OfArray(new double[,]
{
    { 2, -1, 3 },
    { 4, 1, 0 },
    { -3, 2, 5 }
});
var matrix2 = DenseMatrix.OfArray(new double[,]
{
    { 1, 0, -2 },
    { 3, -4, 2 },
    { -1, 5, 7 }
});

var multiplyResult = matrix1 * 3;
Console.WriteLine($"{multiplyResult}");

var additionResult = matrix1 + matrix2;
Console.WriteLine($"\n{additionResult}");

var determinant = matrix1.Determinant();
Console.WriteLine($"{determinant:F0}");

var solve = matrix1.Solve(matrix1);
Console.WriteLine($"\n{solve}");