using System.Text;

namespace protein_translation;

public class ProteinTranslation
{
    static readonly Dictionary<string, string> sequences = new()
    {
        {"AUG" , "Methionine"}, {"UUU", "Phenylalanine"}, {"UUC", "Phenylalanine"},
        {"UUA", "Leucine"}, {"UUG", "Leucine"}, {"UCU", "Serine"},
        {"UCC", "Serine"}, {"UCA", "Serine"}, {"UCG", "Serine"},
        {"UAU", "Tyrosine"}, {"UAC", "Tyrosine"}, {"UGU", "Cysteine"},
        {"UGC", "Cysteine"}, {"UGG", "Tryptophan"}, {"UAA", "STOP"},
        {"UAG", "STOP"}, {"UGA", "STOP"},
    };
    public static string[] Proteins(string strand)
    {
        List<string> proteins = [];
        for (int i = 1; i <= strand.Length - 2; i++)
        {
            StringBuilder sb = new();
            sb.Append(strand.ToCharArray(), i - 1, 3);
            i += 2;

            if (sequences[sb.ToString()] == "STOP")
            {
                break;
            }

            proteins.Add(sequences[sb.ToString()]);
            continue;
        }
        return [.. proteins];
    }
}
