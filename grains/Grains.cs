namespace grains;

public static class Grains
{

    public static ulong Square(int n) => calculatingGrains(n).Last();

    public static ulong Total()
    {
        List<ulong> grainsList = calculatingGrains(64);

        ulong totalGrains = 0;

        foreach (ulong grainsAmount in grainsList)
        {
            totalGrains += grainsAmount;
        }

        return totalGrains;
    }

    public static List<ulong> calculatingGrains(int n)
    {
        if (n <= 0 || n > 64)
        {
            throw new ArgumentOutOfRangeException();
        }

        List<ulong> grainsList = [];
        for (int i = 1; i <= n; i++)
        {
            if (i == 1)
            {
                grainsList.Add(1);
                continue;
            }
            grainsList.Add(2 * grainsList[i - 2]);
        }

        return grainsList;
    }
}
