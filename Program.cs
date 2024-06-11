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

class Solution
{
    public static void IsOddEven(int n)
    {
        if (n > 1 && n <= 100)
        {
            if (n % 2 != 0) // Odd
            {
                Console.WriteLine("Weird");
            }
            else if (n % 2 == 0 && (n >= 2 && n <= 5)) // Even
            {
                Console.WriteLine("Not Weird");
            }
            else if (n % 2 == 0 && (n >= 6 && n <= 20))
            {
                Console.WriteLine("Weird");
            }
            else
            {
                Console.WriteLine("Not Weird");
            }
        }
        else
        {
            return;
        }

    }
    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());
        IsOddEven(N);
    }
}