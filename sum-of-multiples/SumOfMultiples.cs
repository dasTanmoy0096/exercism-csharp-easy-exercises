namespace sum_of_multiples;

public class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        int i = 1;
        HashSet<int> uniqueMultiples = [];
        foreach (int multiple in multiples)
        {
            if (multiple == 0)
            {
                continue;
            }
            while ((multiple * i) < max)
            {
                uniqueMultiples.Add(multiple * i);
                i++;
            }
            i = 1;
        }

        return uniqueMultiples.Sum();
    }
}
