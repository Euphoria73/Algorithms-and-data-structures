using System;
using System.Collections;

namespace LabWork_1
{
    class Program
    {  
        static void Main(string[] args)
        {
            Start();
        }

        static private void Start()
        {
            int enterInt;
            
            while (true)
            {
                Console.WriteLine("Выберите режим работы: \n " +
                                  "Если хотите воспользоваться стеком нажмите - 1 \n" +
                                  "Если хотите воспользоаться двухсвязным списком нажмите - 2 \n");

                Int32.TryParse(Console.ReadLine(), out enterInt);
                if (enterInt == 1)
                {
                    TestStack testStack = new TestStack();
                    testStack.Start();

                }
                if (enterInt == 2)
                {
                    TestDoubleLL doubleLL = new TestDoubleLL();
                    doubleLL.Start();
                }
                if (enterInt == 0)
                {
                    break;
                }
                else Console.WriteLine("повторите попытку");
            }            

        }
    }
}
