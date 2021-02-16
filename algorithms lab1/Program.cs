using System;
using System.Collections.Generic;

namespace algorithms_lab1
{

    
    class Program
    {
        //вернуть прайват
        static void Main(string[] args)
        {
            ArrList<int> s = new ArrList<int>();
            LinkedListOneWay<int> s1 = new LinkedListOneWay<int>();
           // Console.WriteLine(s.getIndexByValue(140));
            s.printValues();
            //  Console.WriteLine(s.GetClass().ToString());
            TimeTesting.test(s1,1000);


        }
    }

}
