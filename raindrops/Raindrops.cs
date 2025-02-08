using System.Text;

namespace raindrops;

public class Raindrops
{
    public static string Convert(int number)
    {
        StringBuilder sb = new();
        if (number % 3 == 0)
        {
            sb.Append("Pling");
        }
        if (number % 5 == 0)
        {
            sb.Append("Plang");
        }
        if (number % 7 == 0)
        {
            sb.Append("Plong");
        }
        if (String.IsNullOrWhiteSpace(sb.ToString()))
        {
            return number.ToString();
        }
        return sb.ToString();
    }
}
