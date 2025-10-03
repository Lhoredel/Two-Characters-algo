using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'alternate' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int alternate(string s)
    {
        var uniqueChars = s.Distinct().ToList();
        int maxLength = 0;
        
        for (int i = 0; i < uniqueChars.Count; i++)
        {
        for (int j = i + 1; j < uniqueChars.Count; j++)
        {
            char c1 = uniqueChars[i];
            char c2 = uniqueChars[j];
            
            string filtered = new string(s.Where(c => c == c1 || c == c2).ToArray());
        
            if (IsAlternating(filtered))
            {
                maxLength = Math.Max(maxLength, filtered.Length);
            }
        }
    }
    
    return maxLength;
}

private static bool IsAlternating(string str)
{
    if (str.Length < 2)
        return false;
    
    for (int i = 1; i < str.Length; i++)
    {
        if (str[i] == str[i - 1])
        {
            return false;
        }
    }
    return true;
}

    }


class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int l = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int result = Result.alternate(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
