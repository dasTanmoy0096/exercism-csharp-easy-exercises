using System.Text;

namespace beer_song;

public class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        StringBuilder sb = new();
        int remainingBottles = startBottles;
        for (int i = 1; i <= takeDown; i++)
        {
            if (remainingBottles == 0)
            {
                sb.Append("No more bottles of beer on the wall, no more bottles of beer.\n");
                sb.Append($"Go to the store and buy some more, 99 bottles of beer on the wall.");
            }
            else
            {
                sb.Append($"{remainingBottles} bottle{(remainingBottles > 1 ? "s" : "")} of beer on the wall, {remainingBottles} bottle{(remainingBottles > 1 ? "s" : "")} of beer.\n" +
                $"Take {(remainingBottles > 1 ? "one" : "it")} down and pass it around, {(remainingBottles > 1 ? remainingBottles - 1 : "no more")} bottle{(remainingBottles != 2 ? "s" : "")} of beer on the wall."
                + $"{(i != takeDown ? "\n\n" : "")}");
            }
            remainingBottles--;
        }
        return sb.ToString();
    }
}
