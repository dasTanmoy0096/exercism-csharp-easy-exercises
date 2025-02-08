namespace darts;

public class Darts
{
    public static int Score(double x, double y)
    {
        double distance = (double)Math.Sqrt
        ((double)Math.Pow((x - 0), 2) + (double)Math.Pow((y - 0), 2));

        return distance switch
        {
            > 10 => 0,
            > 5 and <= 10 => 1,
            > 1 and <= 5 => 5,
            <= 1 => 10,
            _ => 0,
        };
    }
}
