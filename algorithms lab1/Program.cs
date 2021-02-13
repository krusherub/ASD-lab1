using System;
using System.Collections.Generic;

namespace algorithms_lab1
{

    
    class Program
    {
        //вернуть прайват
        static void Main(string[] args)
        {
            LinkedListOneWay<int> s = new LinkedListOneWay<int>();
            s.addFirst(1);
            
            s.addLast(2);
            s.addLast(3);
            s.removeLast();
            
        }
    }

}
