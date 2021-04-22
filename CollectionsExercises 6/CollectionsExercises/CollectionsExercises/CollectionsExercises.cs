
using System.Collections.Generic;

namespace CollectionsExercisesLib
{
    public class CollectionsExercises
    {
        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            var result = "";
            if(num > queue.Count) {
                num = queue.Count;
                result = HelpNextInQueue(num, queue);
            }
            else
            {
                result = HelpNextInQueue(num, queue);
            }
            return result;
            
        }

        public static string HelpNextInQueue(int num, Queue<string> queue)
        {
            var result = "";
            for (int i = 0; i < num; i++)
            {
                result += i == num - 1 ? queue.Dequeue() : queue.Dequeue() + ", ";
            }
            return result;
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            var reverse = new Stack<int>();
            foreach (var item in original)
            {
                reverse.Push(item);
            }

           return reverse.ToArray();
         
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            var result = "";
            var dic = new Dictionary<char,int>();
            
            foreach (var item in input)
            {
                if (char.IsDigit(item))
                {
                    if (dic.ContainsKey(item))
                    {
                        dic[item]++;
                    }
                    else
                    {
                        dic.Add(item, 1);
                    }
                }         
            }

            foreach (var item in dic)
            {  
                   result += $"[{item.Key}, {item.Value}]";
            }

            return result;
           
        }
    }
}