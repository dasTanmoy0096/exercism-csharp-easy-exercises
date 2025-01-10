namespace robot_name;

public class Robot
{
    readonly static Random random = new();
    readonly static HashSet<string> usedNames = [];
    string name;

    public Robot()
    {
        Reset();
    }

    public string Name => name;

    public void Reset()
    {
        string newName;
        do
        {
            newName = GenerateName();
        } while (!usedNames.Add(newName));
        name = newName;
    }

    public static string GenerateName()
    {
        char[] letters = Enumerable.Range(0, 2).Select(_ => (char)
        ('A' + random.Next(26))).ToArray();
        char[] digits = Enumerable.Range(0, 3).Select(_ => (char)
        ('0' + random.Next(10))).ToArray();
        return new string(letters.Concat(digits).ToArray());
    }
}
