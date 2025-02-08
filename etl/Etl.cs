namespace etl;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> transformed = [];

        foreach (int key in old.Keys)
        {
            foreach (string value in old[key])
            {
                transformed.Add(value.ToLower(), key);
            }
        }

        return transformed;
    }
}
