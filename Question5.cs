using System.Collections.Generic;
using System.Linq;

namespace List_Computer_Science
{
    public class Question5
    {
        public bool isASubset(List<int> list1, List<int> list2)
        {
            var shorterList = (list1.Count > list2.Count) ? list2 : list1;
            var longerList = (list1.Count < list2.Count) ? list2 : list1;
            var checkList = new List<int>();

            foreach (var value in shorterList)
            {
                if(longerList.Contains(value))
                    checkList.Add(value);
            }

            var isSubset = checkList.All(shorterList.Contains);

            return isSubset;
        }
    }
}