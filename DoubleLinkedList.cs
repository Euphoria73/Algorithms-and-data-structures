using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LabWork_1
{
    //Двухсвязный список
    public class DoubleLinkedList<T> : IEnumerable<T> 
    {

        DoubleNode<T> firstElem; //первый элемент списка
        DoubleNode<T> lastElem; //последний элемент списка

        int count; //количество элементов в списке

        public int Count { get { return count; } } //свойство показывает количество элементов в списке

        public bool IsEmpty { get { return count == 0; } } //свойство показывает пустой ли список

        //добавление нового элемента списка
        public void Add(T data)
        {
            DoubleNode<T> node = new DoubleNode<T>(data);

            if (firstElem == null)
            {
                firstElem = node;
            }
            else
            {
                lastElem.Next = node; //ссылка на следующий элемент
                node.Previous = lastElem; //ссылка с нового элемента на предыдущий, который был последним
            }
            lastElem = node;
            count++;
        }

        //добавление в начало списка
        public void AddFirst(T data)
        {
            DoubleNode<T> node = new DoubleNode<T>(data);
            DoubleNode<T> temp = firstElem; //добавляем промежуточную переменную для определения первого элемента связи перед добавлением нового
            node.Next = temp; //создаем связку новго элемента с раннее первым элементом
            firstElem = node; //устанавливаем новый элемент как первый

            if (count == 0)
            {
                lastElem = firstElem;
            }
            else
            {
                temp.Previous = node; //связываю ранее первый элемент с новым
            }
            count++;
        }

        //удаление элемента из списка
        public bool Remove(T data)
        {
            DoubleNode<T> current = firstElem;

            while (current != null && current.Data != null) //поиск нужного элемента
            {
                if (current.Data.Equals(data))
                {
                    break;
                }
                current = current.Next;
            }

            if (current != null)
            {
                if (current.Next != null) //если узел связи не последний
                {
                    current.Next.Previous = current.Previous; //сдвигаю связь на 1 влево от удаляемого
                }
                else //если узел последний
                {
                    lastElem = current.Previous; //переустанавливаю последним элементом предыдущий перед удаляемым
                }

                if (current.Previous != null) //аналогично если узел связи не первый
                {
                    current.Previous.Next = current.Next; //сдвигаю связь на 1 вправо от удаляемого
                }
                else //если узел первый 
                {
                    firstElem = current.Next; // переустанавливаю первым элементом следующий за удаляемым
                }

                count--;
                return true; //удаление прошло успешно
            }
            return false; //в остальных случаях удаление не произойдёт (отстутствует элемент, список пустой и пр.)
        }

        public string Contains(T data) //поиск нужного элемента
        {
            DoubleNode<T> current = firstElem;

            while (current != null)
            {
                if (current.Data.Equals(data)) //использование библиотечного метода сравнения обьектов
                {
                    return current.Previous.Next.Data.ToString(); //вывод найденного элемента
                }
                current = current.Next; //если не нашел листает дальше
            }
            return "не найдено"; //если в списке нет нужного элемента
        }

        public void Clear() //очистка списка
        {
            firstElem = null;
            lastElem = null;
            count = 0;
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            DoubleNode<T> current = firstElem;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public IEnumerable<T> BackEnumerator()
        {
            DoubleNode<T> current = lastElem;

            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
