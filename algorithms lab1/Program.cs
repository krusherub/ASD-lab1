using System;
using System.Collections.Generic;

namespace algorithms_lab1
{

    
    class Program
    {
        //вернуть прайват
        static void Main(string[] args)
        {
            //LinkedListOneWay<int> s = new LinkedListOneWay<int>();
            //s.addFirst(1);

            //s.addLast(2);
            //s.addLast(3);
            //s.removeLast();

            NotArrayList array = new NotArrayList();
            for(int i=1; i<15; i++)
            {
                array.deleteAtTheBeginning();
            }
            for (int i = 0; i < 14; i++)
            {
                Console.WriteLine(array.getElement(i));
            }
            Console.WriteLine("----------------------------");
            array.deleteAtTheBeginning();
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(array.getElement(i));
            }
            Console.WriteLine(array.size());
        }
    }

}
