using ASD_LabWork_1;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LabWork_1
{
    class TestDoubleLL
    {
        public void Start()
        {
            //запоняем стек
            string[] shopList = DataBase.WriteDB();
            DoubleLinkedList<string> linkedList = new DoubleLinkedList<string>();
            for (int i = 0; i < shopList.Length; i++)
            {
                linkedList.Add(shopList[i]);
            }

            int enterVal;
            Console.WriteLine("Что с двухсвязным списком сделать: \n " +
                                  "Вывести значения на экран - 1 \n" +
                                  "Добавить новое значение в начало списка - 2 \n" +
                                  "Добавить новое значение в конец списка - 3 \n" +
                                  "Удалить элемент - 4 \n" +
                                  "Показать количесво элементов - 5 \n" +
                                  "Показать пустой ли список - 6 \n" +
                                  "Найти элемент - 7 \n" +
                                  "Очистить список - 8 \n" +
                                  "Быстрая сортировка списка по алфавиту - 9 \n" +
                                  "Шейкерная сортировка списка по алфавиту в обратном порядке - 10 \n" +
                                  "Завершить работу - 0 \n");
            while (true)
            {
                Console.WriteLine("\n Введите выбраное действие со стеком: \n");
                Int32.TryParse(Console.ReadLine(), out enterVal);
                if (enterVal == 1)
                {
                    foreach (var item in linkedList)
                    {
                        Console.WriteLine(item);
                    }
                    continue;
                }
                if (enterVal == 2)
                {
                    Console.Write("Новое значение:  ");
                    linkedList.AddFirst(Console.ReadLine());
                    continue;
                }
                if (enterVal == 3)
                {
                    Console.Write("Новое значение:  ");
                    linkedList.Add(Console.ReadLine());
                    continue;
                }
                if (enterVal == 4)
                {
                    linkedList.Remove(Console.ReadLine());
                    continue;
                }
                if (enterVal == 5)
                {
                    Console.WriteLine(linkedList.Count.ToString());
                    continue;
                }
                if (enterVal == 6)
                {
                    Console.WriteLine(linkedList.IsEmpty.ToString());
                    continue;
                }
                if (enterVal == 7)
                {
                    Console.WriteLine(linkedList.Contains(Console.ReadLine()));
                    continue;
                }                
                if (enterVal == 8)
                {
                    linkedList.Clear();
                    Console.WriteLine("Список очищен \n");
                    continue;
                }
                if (enterVal == 9)
                {
                    string[] quickSortList = linkedList.ToArray();
                    QuickSort.Sort(ref quickSortList, 0, quickSortList.Length - 1);
                    foreach (var item in quickSortList)
                    {
                        Console.WriteLine(item);                        
                    }
                    Console.WriteLine("\nСписок отсортирован \n");
                    continue;
                }
                if (enterVal == 10)
                {
                    string[] shakeSortList = linkedList.ToArray();
                    ShakeSort.Sort(ref shakeSortList);
                    foreach (var item in shakeSortList)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("\nСписок отсортирован \n");
                    continue;
                }
                if (enterVal == 0)
                {
                    Console.WriteLine("Спасибо за внимание! \n");
                    System.Threading.Thread.Sleep(100);
                    break;
                }
            }

        }
    }
}
