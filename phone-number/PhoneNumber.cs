using System.Text;

namespace phone_number;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        List<char> phoneNumberList = [.. phoneNumber];
        List<char> validPunctuations = ['+', '(', ')', '-', ' ', '.'];
        StringBuilder sb = new();

        foreach (char c in phoneNumberList)
        {
            if (validPunctuations.Contains(c))
            {
                continue;
            }

            if (Char.IsLetter(c) || Char.IsPunctuation(c))
            {
                throw new ArgumentException();
            }

            sb.Append(c);
        }

        if (sb.ToString().Length < 10 || sb.ToString().Length > 11)
        {
            throw new ArgumentException();
        }

        if (sb.ToString().Length == 11 && sb.ToString()[0] != '1')
        {
            throw new ArgumentException();
        }

        if (sb.ToString().Length == 11)
        {
            sb.Remove(0, 1);
        }

        if (sb.ToString()[0] == '0' || sb.ToString()[0] == '1'
        || sb.ToString()[3] == '0' || sb.ToString()[3] == '1')
        {
            throw new ArgumentException();
        }

        return sb.ToString();
    }
}
