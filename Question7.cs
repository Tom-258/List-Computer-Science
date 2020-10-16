using System;
using System.Collections.Generic;

namespace List_Computer_Science
{
    public class Question7
    {
        private List<int> _List;
        public Question7(List<int> myList)
        {
            _List = myList;
        }

        public string InsertionSort()
        {
            var sorted = false;
            var i = 1;
            while (sorted == false)
            {
                if (i + 1 > _List.Count)
                    throw new IndexOutOfRangeException();
                var current = _List[i];
                if (i > 1)
                {
                    int breakPoint;
                    for (var j = i; j >= 0; j--)
                    {
                        while (true)
                        {
                            if (current > _List[j]) continue;
                            breakPoint = j;
                            break;
                        }

                        _List[breakPoint+1] = _List[breakPoint];
                        _List[breakPoint] = current;
                    }
                }

                for (var j = 0; j <= _List.Count-2; j++)
                {
                    sorted = _List[j] < _List[j + 1];
                }

                i++;
            }

            return string.Join("", _List.ToArray());
        }
    }
}