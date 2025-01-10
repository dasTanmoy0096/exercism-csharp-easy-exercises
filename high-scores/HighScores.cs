namespace high_scores;

public class HighScores
{
    readonly List<int> list;
    public HighScores(List<int> list)
    {
        this.list = list;
    }

    public List<int> Scores() => list;

    public int Latest() => list.Last();

    public int PersonalBest() => list.Max();

    public List<int> PersonalTopThree() => [.. list.OrderByDescending(n => n).Take(3)];
}
