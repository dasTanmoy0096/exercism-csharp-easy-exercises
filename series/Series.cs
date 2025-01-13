using System.Text;

namespace series;

public class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength > numbers.Length || sliceLength <= 0)
        {
            throw new ArgumentException();
        }

        List<string> slices = [];
        int n = 0;
        do
        {
            List<int> indexes = [.. Enumerable.Range(n, sliceLength)];
            StringBuilder sb = new();
            foreach (int index in indexes)
            {
                sb.Append(numbers[index]);
            }
            slices.Add(sb.ToString());
            n++;
        } while (n + (sliceLength - 1) <= numbers.Length - 1);

        return [.. slices];
    }
}
