
using System;
using System.Collections.Generic;

namespace CollectionsExercisesLib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            var result = new List<int>();
            for (int i = 1; i <= max; i++)
            {
                if(i%5==0)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        // return the average of all the numbers in argList 
        public static double Average(List<double> argList)
        {
            var sum = 0.0;
            if(argList.Count == 0)
            {
                return sum;
            }
            foreach (var item in argList)
            {
                sum = sum + item;
            }
            
            
            return sum/argList.Count;
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            var result = new List<String>();
            foreach (var item in sourceList)
            {
               
                if(item.ToLower().StartsWith('a'))
                {
                    result.Add(item);
                }

            }
            return result;
        }
    }
}
  