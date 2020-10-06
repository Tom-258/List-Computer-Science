using System.Collections.Generic;

namespace List_Computer_Science
{
    public class Question2
    {
        public bool IsInBoth(List<int> list1, List<int> list2)
        {
            var isTheSame = true;
            foreach (var i in list1)
            {
                isTheSame = (list2.Contains(i) != false);
            }

            return isTheSame;
        }
    }
}