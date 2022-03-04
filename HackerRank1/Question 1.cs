using System;
using System.Collections.Generic;

namespace HackerRank1
{
    public class Question_1
    {
        public static void Solution()
        {
            string word = "the day is sunny the the the sunny is is"; 
            Dictionary<string, int> message = new Dictionary<string, int>();
            var newWord = word.Split(' ');
            foreach (var itemWord in newWord)
            {
                if (message.ContainsKey(itemWord))
                {
                    message[itemWord] = (int)message[itemWord] + 1;
                }
                else
                {
                    message.Add(itemWord,1);
                }
            }
            
            foreach (var cha in message)
            {
                Console.WriteLine($"{cha.Key}   {cha.Value}");
            }
        }
    }
}