using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace List_Computer_Science
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<int>(){4,2,6,7,4,13,12,5,3,1,0, -1, -4, -7, -9};
            var myList2 = new List<int>() {4, 7, 2, 3, 12, 6};
            var myList3 = new List<int>() {4, 7, 2, 3, 12, 6, 9, 1, 11};
            var myList4 = new List<int>() {4, 7, 2, 3, 12, 6, 6, 3, 7, 2, 1, 8};

            var question1 = new Question1();
            var question2 = new Question2();
            var question3 = new Question3(myList);
            var question4 = new Question4();
            var question5 = new Question5();
            var question6 = new Question6();
            var question7 = new Question7(myList);
            //Console.WriteLine(question1.Sum(myList));
            //Console.WriteLine(question1.Max(myList));
            //Console.WriteLine(question1.Min(myList));
            //question1.Negatives(myList);

            //Console.WriteLine(question2.IsInBoth(myList, myList2));
            //Console.WriteLine(question3.NaiveSearch(4));
            //Console.WriteLine(question3.SmartSearch(-4));

            //question4.Repeated(myList4);
            //Console.WriteLine(question5.IsASubset(myList2, myList3));
            //question6.Reverse(myList4);
            Console.WriteLine(question7.InsertionSort());


        }
    }
}
