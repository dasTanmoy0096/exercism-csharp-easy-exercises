namespace armstrong_numbers;

public class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        List<int> digits = [.. number.ToString().Select(digit => int.Parse(digit.ToString()))];
        return number == digits.Select(digit => Math.Pow(digit, digits.Count)).Sum();
    }
}
