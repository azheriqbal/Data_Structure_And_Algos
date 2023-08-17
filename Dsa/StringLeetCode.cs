﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa
{
    public class StringLeetCode
    {
        public static string ReverseWords(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return string.Empty;

            string[] words = s.Trim().Split(' ');
            StringBuilder result = new StringBuilder();

            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrWhiteSpace(words[i]))
                {
                    result.Append(words[i]);
                    if (i > 0)
                    {
                        result.Append(" ");
                    }
                }
            }

            return result.ToString();
        }
    }
}


/*In C#, StringBuilder is a class that provides an efficient way to
 * manipulate strings, especially when you need to perform a series
 * of append or modification operations. Unlike regular string
 * concatenation, which creates a new string each time you modify
 * it, StringBuilder allows you to modify a single string buffer
 * in memory, reducing the overhead associated with creating
 * new string instances.
 * 
 *  StringBuilder sb = new StringBuilder();

        // Appending strings
        sb.Append("Hello, ");
        sb.Append("world!");

        // Inserting strings at a specific position
        sb.Insert(7, "awesome ");

        // Removing characters
        sb.Remove(12, 7);

        // Replacing characters
        sb.Replace('o', 'O');

        // Converting StringBuilder to string
        string result = sb.ToString();
 * 
 * 
 */
