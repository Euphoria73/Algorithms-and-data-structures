using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork_1
{
    public class TestStack
    {
        public void Start()
        {
            //запоняем стек
            string[] shopList = DataBase.WriteDB();
            NodeStack<string> stack = new NodeStack<string>();
            for (int i = 0; i < shopList.Length; i++)
            {
                stack.Push(shopList[i]);
            }

            int enterVal;
            Console.WriteLine("Что со стеком сделать: \n " +
                                  "Вывести значения на экран - 1 \n" +
                                  "Добавить новое значение - 2 \n" +
                                  "Удалить элемент - 3 \n" +
                                  "Показать количесво элементов - 4 \n" +
                                  "Показать верхний элемент - 5 \n" +
                                  "Очистить - 6 \n" +
                                  "Завершить работу - 0 \n" );            
            while (true)
            {
                Console.WriteLine("Введите выбраное действие со стеком: ");
                Int32.TryParse(Console.ReadLine(), out enterVal);
                if (enterVal == 1)
                {
                    foreach (var item in stack)
                    {
                        Console.WriteLine(item);
                    }
                    continue;
                }
                if (enterVal == 2)
                {
                    Console.Write("Новое значение:  ");
                    stack.Push(Console.ReadLine());
                    continue;
                }
                if (enterVal == 3)
                {
                    stack.Pop();
                    continue;
                }
                if (enterVal == 4)
                {
                    Console.WriteLine(stack.Count.ToString());
                    continue;
                }
                if (enterVal == 5)
                {
                    Console.WriteLine(stack.Peek());
                    continue;
                }
                if (enterVal == 6)
                {
                    stack.Clear();
                    Console.WriteLine("Стек очищен \n");
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
