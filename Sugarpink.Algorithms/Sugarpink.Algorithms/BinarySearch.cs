using System;
using System.Collections.Generic;
using System.Text;

namespace Sugarpink.Algorithms
{
    public class BinarySearch
    {
        public int Search(int value, List<int> list)
        {
            int start = 0;
            int end = list.Count;
            int prevIndex = -1;
            int index;

            while (true)
            {
                index = (start + end) / 2;

                if(index == prevIndex)
                {
                    return -1;
                } else
                {
                    prevIndex = index;
                }

                var candidate = list[index];

                if (candidate == value)
                {
                    return index;
                }
                else if (candidate < value)
                {
                    start = index;
                }
                else
                {
                    end = index;
                }
            }
        }
    }
}
