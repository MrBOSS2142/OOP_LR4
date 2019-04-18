using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4_1
{
    public class Set
    {
        class Date
        {
            string day;
            string month;
            string year;
            public Date(string day, string month, string year)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
            private readonly Date date = new Date("1", "11", "2017");
        }



        public int number = 10;
        private int[] arr;
        private int size;
        private static Random rand = new Random();
        public int Len { get { return size; } }

        static int Clean(Set arr)
        {
            for (int i = 0; i < arr.size; i++)
            {
                if (arr[i] > 0)
                {
                    arr[i] = 0;
                }
            }
            return arr.size;
        }

        public Set(int size)
        {
            arr = new int[size];
            this.size = size;
        }

        public static explicit operator int(Set arr)
        {
            int num = 0;
            for (int i = 0; i < arr.size; i++)
            {
                if (arr[i] > 0)
                {
                    num++;
                } 
            }
            return num;
        }

        public int this[int i]
        {
            get
            {
                if (i < 0 || i >= arr.Length)
                {
                    return 0;
                }
                return arr[i];
            }
            set
            {
                if (i < 0 || i > arr.Length - 1)
                {
                    Console.WriteLine("Incorrect index. Nothing installed " + i);
                }
                else
                    arr[i] = value;
            }
        }

        public void Initialization()
        {
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next() % 100;
            }
        }

        public void Print()
        {
            Console.WriteLine("Множество: ");

            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------");
        }

        //Overload
        //----------------------------------------------------------
        public static bool operator >(Set num, Set arr1) //проверка на принадлежность
        {
            int count = 0;
            for (int i = 0; i < arr1.size; i++)
            {
                if (arr1[i] == num.number)
                {
                    count++;
                }
            }
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Set arr1, Set arr2) //проверка на подмножество
        {
            int count = 0;
            for (int i = 0; i < arr1.size; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    count++;
                }
            }
            if (arr2.size == count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator *(Set arr1, Set arr2) //пересечение множеств
        {
            int count = 0;
            for (int i = 0; i < arr1.size; i++)
            {
                for (int j = 0; j < arr2.size; j++)
                {
                    if (arr1[i] == arr2[i])
                    {
                        count++;
                    }
                }
            }
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
