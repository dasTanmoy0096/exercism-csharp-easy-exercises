﻿namespace difference_of_squares;

public class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    => (int)Math.Pow(Enumerable.Range(1, max).Sum(), 2);

    public static int CalculateSumOfSquares(int max)
    => Enumerable.Range(1, max).Select(x => (int)Math.Pow(x, 2)).Sum();

    public static int CalculateDifferenceOfSquares(int max)
    => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}
