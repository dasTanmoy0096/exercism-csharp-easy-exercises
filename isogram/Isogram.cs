namespace isogram;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        Dictionary<char, int> alphabetDictionary = [];

        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            alphabetDictionary[letter] = 0;
        }

        word = word.ToLower();
        word.ToCharArray();

        foreach (char letter in word)
        {
            if (letter == ' ' || letter == '-')
            {
                continue;
            }
            if (alphabetDictionary[letter] == 1)
            {
                return false;
            }
            alphabetDictionary[letter] = 1;
        }

        return true;
    }
}