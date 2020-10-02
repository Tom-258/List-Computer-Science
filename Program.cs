using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Computer_Science
{
    public class Question2
    {
        public bool isInBoth(List<int> list1, List<int> list2)
        {
            var isTheSame = true;
            while (isTheSame)
            {

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var mylist = new List<int>(){4,2,6,7,4,13,12,5,3,1,0, -1, -4, -7, -9};
            var mylist2 = new List<int>(){4,7,2,3,12,6};
            var question1 = new Question1();
            Console.WriteLine(question1.Sum(mylist));
            Console.WriteLine(question1.Max(mylist));
            Console.WriteLine(question1.Min(mylist));
            question1.Negatives(mylist);
            
        }
    }
}
