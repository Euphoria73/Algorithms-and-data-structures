using System;
using System.Collections.Generic;
using System.Text;

namespace ASD_LabWork_1
{
    public static class ShakeSort
    {
        static void Swap(ref string elem1, ref string elem2)
        {
            (elem1, elem2) = (elem2, elem1);

            //var temp = elem1;
            //elem1 = elem2;
            //elem2 = temp;
        }

        public static void Sort(ref string[] list)
        {
            int left = 0;
            int right = list.Length - 1;
            
            
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (string.CompareOrdinal(list[i], list[i+1]) < 0)
                        Swap(ref list[i], ref list[i + 1]);
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    if (string.CompareOrdinal(list[i-1], list[i]) < 0)
                        Swap(ref list[i-1], ref list[i]);
                }
                left++;
            }
        }

    }
}
