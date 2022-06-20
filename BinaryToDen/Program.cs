using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryToDen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter binary num : ");
            string test = Console.ReadLine();
            Console.WriteLine(BinaryToDenary(test));
            Console.ReadLine();
        }

        static List<long> DenaryVals(int n)
        {
            long a = 1;
            List<long> arr = new List<long>(n);
            arr.Add(1);
            for(int i = 0; i<n ; i++)
            {
                long c = a * 2;
                a = c;
                arr.Add(c);
            }
            return arr;
        }

        static long BinaryToDenary(string str)
        {
            string one = "1";
            List<long> vals = DenaryVals(str.Length-1);
            vals.Reverse();

            List<long> arr = new List<long>();
            for(int i = 0; i < str.Length;i++)
            {
                if(str[i] == one.ToCharArray()[0])
                {
                    arr.Add(vals[i]);                 
                }
            }
            return arr.Sum();
        }
    }
}
