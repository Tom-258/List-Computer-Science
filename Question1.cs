using System;
using System.Collections.Generic;

namespace List_Computer_Science
{
    public class Question1
    {
        public int Sum(List<int> list)
        {
            var sum = 0;
            foreach (var i in list)
            {
                sum += i;
            }

            return sum;
        }

        public int Max(List<int> list)
        {
            var max = 0;
            foreach (var i in list)
            {
                if (i > max)
                    max = i;
            }
            return max;
        }

        public int Min(List<int> list)
        {
            var min = 0;
            foreach (var i in list)
            {
                if (i < min)
                    min = i;
            }
            return min;
        }

        public void Negatives(List<int> list)
        {
            var negatives = new List<int>();

            foreach (var i in list)
            {
                if (i < 0)
                    negatives.Add(i);
            }

            foreach (var j in negatives)
            {
                Console.WriteLine(j);
            }
        }
    }
}