using System.Text;

namespace resistor_color_trio;

public class ResistorColorTrio
{
    static readonly Dictionary<string, int> bandColorEncoding = new()
        {
            {"black", 0},
            {"brown", 1},
            {"red", 2},
            {"orange", 3},
            {"yellow", 4},
            {"green", 5},
            {"blue", 6},
            {"violet", 7},
            {"grey", 8},
            {"white", 9},
        };
    public static string Label(string[] colors)
    {
        StringBuilder sb = new();

        sb.Append(bandColorEncoding[colors[0]]);

        int zeroes = 0;

        if (colors[1] == "black")
        {
            zeroes += 1;
        }
        else
        {
            sb.Append(bandColorEncoding[colors[1]]);
        }

        zeroes += bandColorEncoding[colors[2]];

        if (zeroes >= 3)
        {
            sb.Append(new string('0', zeroes - 3));
            return sb.Append(" kiloohms").ToString(); ;
        }

        sb.Append('0', zeroes);
        return sb.Append(" ohms").ToString();
    }
}
