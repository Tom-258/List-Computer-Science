using System;
using System.Collections.Generic;

namespace List_Computer_Science
{
    public class Question4
    {
        public void Repeated(List<int> list)
        {
            var scannedOver = new List<int>();
            var duplicates = new List<int>();
            for (var i = 0; i <= list.Count-2; i++)
            {
                scannedOver.Add(list[i]);
                if (scannedOver.Contains(list[i + 1]))
                {
                    duplicates.Add(list[i + 1]);
                }
                
            }

            foreach (var number in duplicates)
            {
                Console.WriteLine(number);
            }
        }
    }
}