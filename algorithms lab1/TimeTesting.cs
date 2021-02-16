using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace algorithms_lab1
{
    class TimeTesting
    {
        public static void test(Lists<int> list, int amount)
        {
            string listName = list.getName();
            Console.WriteLine("Тестируется: " + listName);
            Console.WriteLine("Количество добавляемых елементов " + amount);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < amount; i++)
            {
                list.addFirst(i);
            }
            stopwatch.Stop();
            Console.WriteLine(listName + "-" + "Время на добавление в начало списка: "+stopwatch.ElapsedTicks*100 + "ns");

            stopwatch.Restart();
            for (int i = 0; i < amount; i++)
            {
                list.add(amount/2,i);
            }
            stopwatch.Stop();
            Console.WriteLine(listName + "-" + "Время на добавление в средину списка: " + stopwatch.ElapsedTicks * 100 + "ns");

            stopwatch.Restart();
            for (int i = 0; i < amount; i++)
            {
                list.addLast(i);
            }
            stopwatch.Stop();
            Console.WriteLine(listName + "-" + "Время на добавление в конец списка: " + stopwatch.ElapsedTicks * 100 + "ns");

            // ----------------------------
            Console.WriteLine();
            stopwatch.Restart();
            for (int i = 0; i < amount; i++)
            {
                list.replaceFirst(i);
            }
            stopwatch.Stop();
            Console.WriteLine(listName + "-" + "Время на замену в начале списка: " + stopwatch.ElapsedTicks * 100 + "ns");

            stopwatch.Restart();
            for (int i = 0; i < amount; i++)
            {
                list.replace(amount / 2, i);
            }
            stopwatch.Stop();
            Console.WriteLine(listName + "-" + "Время на замену в средине списка: " + stopwatch.ElapsedTicks * 100 + "ns");

            stopwatch.Restart();
            for (int i = 0; i < amount; i++)
            {
                list.replaceLast(i);
            }
            stopwatch.Stop();
            Console.WriteLine(listName + "-" + "Время на замену в конце списка: " + stopwatch.ElapsedTicks * 100 + "ns");

            // ----------------------------
            Console.WriteLine();
            stopwatch.Restart();
            for (int i = 0; i < amount; i++)
            {
                list.removeFirst();
            }
            stopwatch.Stop();
            Console.WriteLine(listName + "-" + "Время на удаление в начале списка: " + stopwatch.ElapsedTicks * 100 + "ns");

            stopwatch.Restart();
            for (int i = 0; i < amount; i++)
            {
                list.remove(amount / 2);
            }
            stopwatch.Stop();
            Console.WriteLine(listName + "-" + "Время на удаление в средине списка: " + stopwatch.ElapsedTicks * 100 + "ns");

            stopwatch.Restart();
            for (int i = 0; i < amount; i++)
            {
                list.removeLast();
            }
            stopwatch.Stop();
            Console.WriteLine(listName + "-" + "Время на удаление в конце списка: " + stopwatch.ElapsedTicks * 100 + "ns");

        }
    }
}
