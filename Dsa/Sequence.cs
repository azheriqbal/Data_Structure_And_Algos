﻿

namespace LeetCode
{
    public class Sequence
    {
        public static string LongestCommonPrefix(string[] s)
        {
            Array.Sort(s);
            string str1 = s[0];
            string str2 = s[s.Length-1];
            int index = 0;

            while(index < str1.Length) 
            {
                if (str1[index] == str2[index]) 
                {
                    index++;
                }
                else
                {
                    break;
                }

                
            }
            return index == 0 ? "No Sequence is Found" : str1.Substring(0, index);

        }
        public static bool IsSubsequence(string s, string t)
        {
            int sPointer = 0;
            int tPointer = 0;

            while (sPointer < s.Length && tPointer < t.Length)
            {
                if (s[sPointer] == t[tPointer])
                {
                    sPointer++;
                }
                tPointer++;
            }

            return sPointer == s.Length;
            /* if(s.Length==0) return true;

             int i = 0;
             int j=0;
             while(i<s.Length && j<t.Length) 
             {
                 if (s[i] == t[j])
                 {
                     i++;
                     j++;
                 }
                 else
                 {
                     j++;
                 }
             }
             if (i == s.Length)
             {
                 return true;
             }

             return false;*/
        }

        public static int LengthOfLastWord(string s)
        {

            /*if (string.IsNullOrWhiteSpace(s))
                return 0;

            int length = 0;
            bool foundWord = false;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (char.IsWhiteSpace(s[i]))
                {
                    if (foundWord)
                        break;
                }
                else
                {
                    length++;
                    foundWord = true;
                }
            }

            return length;*/



            int len = 0;
            string TrimmedString = s.Trim();

            for (int i = TrimmedString.Length - 1; i >= 0; i--)
            {
                if (TrimmedString[i] != ' ')
                {
                    len++;
                }
                else
                {
                    break;
                }

            }

            return len;




            /*if (string.IsNullOrWhiteSpace(s))
                return 0;

            string[] words = s.Trim().Split(' ');
            return words[words.Length - 1].Length;*/

        }
    }
}
