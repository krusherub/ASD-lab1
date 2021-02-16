using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms_lab1
{
    class ArrList<T> : Lists<T>
    {
        private int initialSize = 10;
        private int cut_rate = 2;
        private T[] arr;
        private int elements = 0;
        public ArrList(int size)
        {
            arr = new T[size];
        }
        public ArrList()
        {
            arr = new T[this.initialSize];
        }
        public void add(int index, T item)
        {
            if (item == null)
                throw new ArgumentNullException("Невозможно добавить null");
            if (index > elements || index < 0)
                throw new ArgumentOutOfRangeException("Индекс выходит за границы массива");
            if (arr.Length <= elements + 1)
            {
                T[] newArr = new T[arr.Length * cut_rate];
                cloneArr(arr, ref newArr);
                arr = newArr;
            }
            if (index == elements)
                addLast(item);
            else
            {
                T[] tempArr = (T[])arr.Clone();
                for (int i = 0, b = 0; i < elements + 1; i++)
                {
                    if (i == index)
                    {
                        arr[i] = item;
                        continue;
                    }
                    arr[i] = tempArr[b];
                    b++;
                }
                elements++;
            }

        }
        public void addLast(T item)
        {
            if (item == null)
                throw new ArgumentNullException("Невозможно добавить null");
            if (arr.Length <= elements + 1)
            {
                T[] newArr = new T[arr.Length * cut_rate];
                cloneArr(arr, ref newArr);
                arr = newArr;
            }
            arr[elements] = item;
            elements++;
        }
        private void cloneArr(T[] arr1, ref T[] arr2)
        {
            for (int i = 0; i < elements; i++)
            {
                arr2[i] = arr1[i];
            }
        }
        public void remove(int index)
        {
            if (index > elements || index < 0)
                throw new ArgumentOutOfRangeException("Индекс выходит за границы массива");
            if (index == elements)
                removeLast();
            else
            {
                T[] tempArr = (T[])arr.Clone();
                for (int i = 0, b = 0; i < elements; )
                {
                    if (i == index)
                    {
                        b++;
                    }
                    arr[i] = tempArr[b];
                    b++;
                    i++;
                }
                elements--;
            }
        }
        public void removeLast()
        {
            arr[elements] = default(T);
            elements--;
        }
        public void removeFirst()
        {
            remove(0);
        }
        public void addFirst(T item)
        {
            add(0, item);
        }
        public int getLength()
        {
            return elements;
        }
        public void replace(int index, T item)
        {
            if (item == null)
                throw new ArgumentNullException("Невозможно добавить null");
            if (index > elements || index < 0)
                throw new ArgumentOutOfRangeException("Индекс выходит за границы массива");
            arr[index] = item;
        }
        public void replaceFirst(T item)
        {
            replace(0,item);
        }
        public void replaceLast(T item)
        {
            replace(elements - 1, item);
        }
        public int getIndexByValue(T item)
        {
            for (int i = 0; i < elements; i++)
            {
                if (arr[i].Equals(item))
                    return i;
            }
            throw new Exception("Элемент с таким значением не найден");
        }
        public int getSum()
        {
            if (elements == 0)
                return 0;
            try 
            {
                int sum = 0;
                foreach (T item in arr)
                    sum += int.Parse(item.ToString());
                return sum;
            }
            catch(Exception)
            {
                return 0;
            }
            
        }
        public void printValues()
        {
            for (int i = 0; i < elements; i++)
            {
                Console.WriteLine(arr[i]);
            }
                
        }
        public string getName()
        {
            return "ArrayList";
        }
    }
}
