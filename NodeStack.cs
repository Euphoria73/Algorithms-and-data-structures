using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LabWork_1
{
    public class NodeStack<T> : IEnumerable<T>
    {
#nullable enable
        Node<T>? firstElem;
#nullable disable
        int count;

        public bool IsEmpty { get { return count == 0; } }
        public int Count { get { return count; } }

        public void Push(T data)
        {
            Node<T> node = new Node<T>(data); //увеличиваем стек, занося в новые данные
            node.Next = firstElem; //делаем связь нового элемента с первым элементом
            firstElem = node; //переставляем верхушку стека на новый элемент
            count++;
        }

        public T Pop()
        {
            if (IsEmpty) //если стек пустой выдаём соответсвующее сообщение
            {
                throw new InvalidOperationException("Стек пуст");
            }
            Node<T> temp = firstElem;
            firstElem = firstElem.Next; //переставляем верхушку на следующий элемент
            count--; //уменьшаем количество в стеке на 1
            return temp.Data; //возвращаем обновленный стек
        }
        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Стек пуст");
            }
            return firstElem.Data;
        }

        public void Clear()
        {
            firstElem = null;            
            count = 0;
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = firstElem;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
