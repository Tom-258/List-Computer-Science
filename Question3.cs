using System;
using System.Collections.Generic;

namespace List_Computer_Science
{
    public class Question3
    {
        public Question3(List<int> list)
        {
            MyList = list;
            BubbleSort();
        }

        public List<int> MyList { get; }
        public bool NaiveSearch(int item)
        {
            var isInMyList = false;
            foreach (var i in MyList)
            {
                if (i == item)
                {
                    isInMyList = true;
                    break;
                }
            }

            return isInMyList;
        }

        public bool SmartSearch(int item)
        {
            var isInMyList = false;
            var startPoint = MyList.Count / 2;
            if (item <= MyList[MyList.Count / 2])
            {
                for (; startPoint >= 0 ; startPoint--)
                {
                    if (MyList[startPoint] != item) continue;
                    isInMyList = true;
                    break;
                }
            }
            else
            {
                for (; startPoint <= MyList.Count-1; startPoint++)
                {
                    if (MyList[startPoint] == item)
                    {
                        isInMyList = true;
                        break;
                    }
                }
            }

            return isInMyList;
        }

    private void BubbleSort()
        {
            for (var j = 0; j < MyList.Count; j++)
            {
                for (var i = 0; i <= MyList.Count - 2; i++)
                {
                    if (MyList[i] <= MyList[i + 1]) continue;
                    var temp = MyList[i];
                    MyList[i] = MyList[i + 1];
                    MyList[i + 1] = temp;
                }
            }
        }
    }
}