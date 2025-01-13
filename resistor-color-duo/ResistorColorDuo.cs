using System.Text;

namespace resistor_color_duo;

public class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        Dictionary<string, int> bandColorEncoding = [];
        bandColorEncoding.Add("black", 0);
        bandColorEncoding.Add("brown", 1);
        bandColorEncoding.Add("red", 2);
        bandColorEncoding.Add("orange", 3);
        bandColorEncoding.Add("yellow", 4);
        bandColorEncoding.Add("green", 5);
        bandColorEncoding.Add("blue", 6);
        bandColorEncoding.Add("violet", 7);
        bandColorEncoding.Add("grey", 8);
        bandColorEncoding.Add("white", 9);

        StringBuilder sb = new();

        sb.Append(bandColorEncoding[colors[0]]);
        if (colors.Length >= 2)
        {
            sb.Append(bandColorEncoding[colors[1]]);
        }
        return int.Parse(sb.ToString());
    }
}
