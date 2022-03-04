using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank1
{
    public class Question2
    {
        public static void Solution()
        {
            List<string> words = new List<string>() {"abcw", "baz", "foo", "bar", "xtfn", "abcdef"};
            List<int> length = new List<int>();
            int result=0;
            int maxresult = 0;
            for (int i = 0; i < words.Count; i++)
            {
                var cah = words[i].ToCharArray();
                for (int j = 1; j < words.Count; j++)
                {
                    if (words[i].Length == words[j].Length)
                    {
                        foreach (var item in cah)
                        {
                            if (words[j].IndexOf(item)<0)
                            { 
                                result = words[i].Length * words[j].Length;
                                if (result > maxresult)
                                {
                                    maxresult = result;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(maxresult);
        }
    }
}