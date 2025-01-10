namespace allergies;

public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128,
}

public class Allergies
{
    int mask;
    public Allergies(int mask)
    {
        this.mask = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        List<Allergen> allergenList = [.. List()];

        return allergenList.Contains(allergen);
    }

    public Allergen[] List()
    {
        string[] allergenNames = Enum.GetNames(typeof(Allergen));
        int[] allergenScores = Enum.GetValues(typeof(Allergen)).Cast<int>().ToArray();

        int mask = this.mask;

        List<string> allergenList = [];
        int length = allergenScores.Length;

        while (mask != 0)
        {
            for (int i = 0; i < length; i++)
            {
                if (mask == 257)
                {
                    allergenList.Add(allergenNames[0]);
                    mask -= 257;
                    break;
                }
                else if (mask == allergenScores[i])
                {
                    allergenList.Add(allergenNames[i]);
                    mask -= allergenScores[i];
                    length = i;
                    break;
                }
                else if (mask < allergenScores[i])
                {
                    i--;
                    allergenList.Add(allergenNames[i]);
                    mask -= allergenScores[i];
                    length = i;
                    break;

                }
                else if (i == length - 1)
                {
                    allergenList.Add(allergenNames[i]);
                    mask -= allergenScores[i];
                    length = i;
                    break;
                }
            }
        }

        allergenList.Reverse();

        return allergenList.Select(
            allergy => (Allergen)Enum.Parse(typeof(Allergen), allergy)).ToArray();
    }
}
