namespace hamming;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        char[] firstStrandArray = firstStrand.ToCharArray();
        char[] secondStrandArray = secondStrand.ToCharArray();

        if (firstStrandArray.Length != secondStrandArray.Length)
        {
            throw new ArgumentException();
        }

        int numOfDifferences = 0;

        for (int i = 0; i < firstStrandArray.Length; i++)
        {
            if (firstStrandArray[i] != secondStrandArray[i])
            {
                numOfDifferences++;
            }
        }

        return numOfDifferences;
    }
}