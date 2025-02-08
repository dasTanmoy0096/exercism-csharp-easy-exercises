﻿namespace proverb;

public class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        List<string> recite = [];
        for (int i = 0; i < subjects.Length; i++)
        {
            if (i == subjects.Length - 1)
            {
                recite.Add($"And all for the want of a {subjects[0]}.");
                continue;
            }
            recite.Add($"For want of a {subjects[i]} the {subjects[i + 1]} was lost.");
        }
        return [.. recite];
    }
}
