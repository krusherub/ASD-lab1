using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms_lab1
{
    interface Lists<T>
    {
        public void removeFirst();
        public void removeLast();
        public void remove(int index);
        public void add(int index, T item);
        public void addFirst(T item);
        public void addLast(T item);
        public void replace(int index, T item);
        public void replaceFirst(T item);
        public void replaceLast(T item);
        public int getSum();
        public int getIndexByValue(T item);
        public string getName();
    }
}
