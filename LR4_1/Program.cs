using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR4_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Owner own = new Owner();
            own.Print();
            Console.WriteLine("--------------------");

            Set set0 = new Set(10);
            set0.Initialization();
            set0.Print();
            Set set1 = new Set(20);
            set1.Initialization();
            set1.Print();
            bool pr = set0 > set1;
            bool pr1 = set0 < set1;
            bool pr3 = set1 * set0;
            if (pr)
            {
                Console.WriteLine($"Число {set0.number} принадлежит множеству 1");
            }
            else
            {
                Console.WriteLine($"Число {set0.number}  не принадлежит множеству 1");
            }
            if (pr1)
            {
                Console.WriteLine("Множество 1 является подмножеством множества 2");
            }
            else
            {
                Console.WriteLine("Множество 1 не является подмножеством множества 2");
            }
            if (pr3)
            {
                Console.WriteLine($"Множества пересекаются");
            }
            else
            {
                Console.WriteLine($"Множества не пересекаются");
            }

            Console.WriteLine("Максимальное число в множестве " + set0.Max());
            Console.WriteLine("Минимальное число в множестве " + set1.Min());

            Console.ReadKey();
        }
    }


    
}