namespace nucleotide_count;

public class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        char[] sequenceArray = sequence.ToCharArray();
        Dictionary<char, int> count = new()
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0,
        };

        for (int i = 0; i < sequenceArray.Length; i++)
        {
            if (count.ContainsKey(sequenceArray[i]))
            {
                count[sequenceArray[i]]++;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        return count;
    }
}
