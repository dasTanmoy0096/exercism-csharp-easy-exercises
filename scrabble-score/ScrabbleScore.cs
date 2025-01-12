namespace scrabble_score;

public class ScrabbleScore
{
    public static int Score(string input)
    {
        if (String.IsNullOrEmpty(input))
        {
            return 0;
        }

        Dictionary<List<char>, int> letterValues = [];
        letterValues.Add(['A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'], 1);
        letterValues.Add(['D', 'G'], 2);
        letterValues.Add(['B', 'C', 'M', 'P'], 3);
        letterValues.Add(['F', 'H', 'V', 'W', 'Y'], 4);
        letterValues.Add(['K'], 5);
        letterValues.Add(['J', 'X'], 8);
        letterValues.Add(['Q', 'Z'], 10);

        input = input.ToUpper();
        int score = 0;

        foreach (char c in input)
        {
            foreach (List<char> letterList in letterValues.Keys)
            {
                if (letterList.Contains(c))
                {
                    score += letterValues[letterList];
                }
            }

        }

        return score;
    }
}
