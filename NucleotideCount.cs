using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var dictionary = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };
        for (int i = 0; i < sequence.Length; i++)
        {
            if (dictionary.ContainsKey (sequence[i]))
            {
                dictionary[sequence[i]]++;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        return dictionary;
    }
}