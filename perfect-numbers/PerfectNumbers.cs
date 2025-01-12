namespace perfect_numbers;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}
public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number <= 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        List<int> factors = [];

        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                factors.Add(i);
            }
        }

        int aliquotSum = 0;
        foreach (int factor in factors)
        {
            aliquotSum += factor;
        }

        if (number < aliquotSum)
        {
            return Classification.Abundant;
        }
        else if (number > aliquotSum)
        {
            return Classification.Deficient;
        }
        else
        {
            return Classification.Perfect;
        }
    }
}
