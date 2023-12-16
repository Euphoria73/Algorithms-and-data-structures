using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork_1
{
    public class DoubleNode<T>
    {
        public T Data { get; set; } //ячейка для хранения данных

#nullable enable
        public DoubleNode<T> Previous { get; set; } //проверка на предыдущий элемент
        public DoubleNode<T> Next { get; set; } //проверка на следующий элемент
#nullable disable

        public DoubleNode(T data) //конструктор класса
        {
            Data = data;
        }
    }
}
