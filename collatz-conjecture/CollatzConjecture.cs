namespace collatz_conjecture;

public class CollatzConjecture
{
    public static int Steps(int number)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(number);
        int steps = 0;
        while (number != 1)
        {
            if (number % 2 == 0)
            {
                number /= 2;
                steps++;
            }
            else
            {
                number = (3 * number) + 1;
                steps++;
            }
        }

        return steps;
    }
}
