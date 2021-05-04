using System;
using System.Collections;

namespace FirstUniqueCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "leetcode";

            Console.WriteLine("Index of first unique character is {0}", FirstUniqChar(s));

            Console.Read();
        }

        public static int FirstUniqChar(string s)
        {
            //Program to find first unique character
            var hashTable = new Hashtable();
            foreach (var c in s.ToCharArray())
            {
                if (hashTable.ContainsKey(c))
                {
                    hashTable[c] = (int)hashTable[c] + 1;
                }
                else
                {
                    hashTable.Add(c, 1);
                }
            }

            for (var i = 0; i < s.Length; i++)
            {
                if ((int)hashTable[s[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}



