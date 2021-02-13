using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms_lab1
{
    class LinkedListTwoWay<T>
    {
        private LinkNodeTwo<T> firstNode;
        private LinkNodeTwo<T> lastNode;
        private int size = 0;

        public void addFirst(T item)
        {
            if (isEmpty() == true)
            {
                LinkNodeTwo<T> newNode = new LinkNodeTwo<T>(item);
                firstNode = newNode;
                lastNode = newNode;
            }
            else
            {
                LinkNodeTwo<T> newNode = new LinkNodeTwo<T>(item);
                newNode.Next = firstNode;
                firstNode.Prev = newNode;
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
                LinkNodeTwo<T> newNode = new LinkNodeTwo<T>(item);
                lastNode.Next = newNode;
                newNode.Prev = lastNode;
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
            else if (size == 1)
                firstNode = null;
            else {
                firstNode = firstNode.Next;
                firstNode.Prev = null;
            }
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
                LinkNodeTwo<T> temp = findNodeByIndex(size - 2);
                lastNode = temp;
                lastNode.Next = null;
                size--;
            }
        }
        private LinkNodeTwo<T> findNodeByIndex(int index)
        {
            if (index >= size)
                throw new Exception("Индекс выходит за размер" + size);
            LinkNodeTwo<T> temp = firstNode;
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
                LinkNodeTwo<T> newNode = new LinkNodeTwo<T>(item);
                LinkNodeTwo<T> temp = findNodeByIndex(index - 1);
                newNode.Next = temp.Next;
                temp.Next.Prev = newNode;
                newNode.Prev = temp;
                temp.Next = newNode;

                size++;
            }
        }
        public void removeByIndex(int index)
        {
            if (index >= size)
                throw new Exception("Индекс выходит за размер" + size);
            if (index == 0)
                removeFirst();
            else if (index == size - 1)
                removeLast();
            else
            {
                LinkNodeTwo<T> temp = findNodeByIndex(index - 1);
                temp.Next = temp.Next.Next;
                temp.Next.Prev = temp;
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
