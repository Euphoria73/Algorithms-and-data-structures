using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork_1
{
    //определение элемента
    public class Node<T>
    {
        public T Data { get; set; } //ячейка для хранения данных

        #nullable enable
        public Node<T>? Next { get; set; } //проверка на следующий элемент
        #nullable disable

        public Node(T data) //конструктор класса
        {
            Data = data;
        }
    }
}
