using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LabWork_1
{
    //Односвязный список
    public class LinkedList<T> : IEnumerable<T> 
    {
# nullable enable
        Node<T>? firstElem; //первый элемент списка
        Node<T>? lastElem; //последний элемент списка
#nullable disable
        int count; //количество элементов в списке

        public int Count { get { return count; } } //свойство показывает количество элементов в списке

        public bool IsEmpty { get { return count == 0; } } //свойство показывает пустой ли список

        //реализация интерфейса IEnumerable
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
#nullable enable
            Node<T>? current = firstElem;
#nullable disable
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }

        //добавление нового элемента списка
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data); 

            if (firstElem == null)
            {
                firstElem = node;
            }
            else
            {
                lastElem.Next = node; //ссылка на следующий элемент
            }
            lastElem = node;
            count++;
        }

        //добавление в начало списка
        public void AddFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            node.Next = firstElem; 
            firstElem = node;
            if (count == 0)
            {
                lastElem = firstElem;
            }
            count++;
        }

        //удаление элемента из списка
        public bool Remove (T data)
        {
#nullable enable
            Node<T>? current = firstElem;
            Node<T>? previous = null;
#nullable disable
            while (current != null && current.Data != null)
            {
                if (current.Data.Equals(data)) //проверяю равен ли current необходимому элементу для удаления
                {
                    if (previous != null) //если узел связи в середине или конце
                    {
                        previous.Next = current.Next; //то убираю узел связи с current и привязываю его к следующему от current

                        if (current.Next == null) //если у нынешнего элемента нет узла связи, значит он последний
                        {
                            lastElem = previous; //поэтому считаем что предыдущий элемент становится последним
                        }
                    }

                    else
                    {
                        firstElem = firstElem?.Next; //если удаляется первый элемент, то перезаписывается первый на значение следующего за ним

                        if (firstElem == null) //если первого элемента нет, т.е. список пустой
                        {
                            lastElem = null; // то последний элемент тоже считаем пустым
                        }
                    }
                    count--; //убавляю число в списке на 1 после удаления
                    return true; //все условия были выполнены и удаление прощло удачно
                }
                previous = current; //сдвигаем значение с предыдущего на нынешний
                current = current.Next; //нынешний становится следующим
            }
            return false; //в остальных случаях возвращаем false
        }

        //Проверка содержит ли список элемент
        public bool Contains(T data)
        {
#nullable enable
            Node<T>? current = firstElem;
#nullable disable
            while (current != null && current.Data != null)
            {
                if (current.Data.Equals(data)) //если нашли подходящее в списке
                {
                    return true;
                }
                current = current.Next; //если не нашли, переходим на следующий элемент и повторяем цикл
            }
            return false; //если не нашли
        }

       
    }
}
