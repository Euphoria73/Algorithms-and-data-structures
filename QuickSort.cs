using LabWork_1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ASD_LabWork_1
{
    static class QuickSort
    {
        static void Swap(ref string elem1, ref string elem2)
        {
            (elem1, elem2) = (elem2, elem1);

            //var temp = elem1;
            //elem1 = elem2;
            //elem2 = temp;
        }

       
        public static void Sort(ref string[] list, int leftIndex, int rightIndex)
        {            
            var pivot = list[leftIndex + (rightIndex - leftIndex) / 2]; //(выбирается любой элемент как условная опорная точка отсчёта,
            int i = leftIndex;                                                //делится на меньшее и равное или большее опорной точки)
            int j = rightIndex;

            while (i <= j)
            {
                while (string.CompareOrdinal(list[i], pivot) < 0) i++; //строку переводим в посимвольное исчисление для дальнейшего сравнения
                while (string.CompareOrdinal(list[j], pivot) > 0) j--; //находим максимальное и минимальное количество элементов в частях от опорной точки
                if (i <= j)
                {
                    Swap(ref list[i], ref list[j]);                   
                    i++;
                    j--;
                }
            }
            if (i < rightIndex) //рекурсия сортивки меньшей части
                Sort(ref list, i, rightIndex);

            if (leftIndex < j) //рекурсия сортировки большей части
                Sort(ref list, leftIndex, j);
        }
        //чтобы сделать сортировку в обратном порядке нужно с строках 29 и 30 поменять знаки <> противоположные ><
    }
}
