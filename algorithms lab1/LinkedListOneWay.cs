using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms_lab1
{
    class LinkedListOneWay<T>
    {
        
            private LinkNodeOne<T> firstNode;
            private LinkNodeOne<T> lastNode;
            private int size = 0;

            public void addFirst(T item)
            {
                if (isEmpty() == true)
                {
                    LinkNodeOne<T> newNode = new LinkNodeOne<T>(item);
                    firstNode = newNode;
                    lastNode = newNode;
                }
                else
                {
                    LinkNodeOne<T> newNode = new LinkNodeOne<T>(item);
                    newNode.Next = firstNode;
                    firstNode = newNode;
                }
                size++;
            }
            public void addLast(T item)
            {
                if (isEmpty() == true)
                    addFirst(item);
                else
                {
                    LinkNodeOne<T> newNode = new LinkNodeOne<T>(item);
                    lastNode.Next = newNode;
                    lastNode = newNode;
                }
                size++;
            }
            private bool isEmpty()
            {
                if (firstNode == null)
                    return true;
                return false;
            }
            public void removeFirst()
            {
                if (size == 0)
                    throw new Exception("Количество элементов равно 0");
                firstNode = firstNode.Next;
                size--;
            }
            public void removeLast()
            {
                if (size == 0)
                    throw new Exception("Количество элементов равно 0");
                else if (size == 1)
                    removeFirst();
                else
                {
                    LinkNodeOne<T> temp = findNodeByIndex(size - 2);
                    lastNode = temp;
                    lastNode.Next = null;
                    size--;
                }
            }
            private LinkNodeOne<T> findNodeByIndex(int index)
            {
                if (index >= size)
                    throw new Exception("Индекс выходит за размер" + size);
                LinkNodeOne<T> temp = firstNode;
                for (int i = 0; i != index; i++)
                {
                    temp = temp.Next;
                }
                return temp;
            }
            public void addByIndex(int index, T item)
            {
                if (index >= size)
                    throw new Exception("Индекс выходит за размер" + size);
                else if (index == 0)
                    addFirst(item);
                else
                {
                    LinkNodeOne<T> newNode = new LinkNodeOne<T>(item);
                    LinkNodeOne<T> temp = findNodeByIndex(index - 1);
                    newNode.Next = temp.Next;
                    temp.Next = newNode;
                    size++;
                }
            }
            public void removeByIndex(int index)
            {
                if (index >= size)
                    throw new Exception("Индекс выходит за размер" + size);
                else if (index == 0)
                    removeFirst();
                else if (index == size - 1)
                    removeLast();
                else
                {
                    LinkNodeOne<T> temp = findNodeByIndex(index - 1);
                    temp.Next = temp.Next.Next;
                    size--;
                }


            }
            public void replaceFirst(T item)
            {
                firstNode.Item = item;
            }
            public void replaceLast(T item)
            {
                lastNode.Item = item;
            }
            public void replace(int index, T item)
            {
                findNodeByIndex(index).Item = item;
            }
        
    }
}
