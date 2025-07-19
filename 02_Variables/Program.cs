using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double e;
            e = 1.0;
            Console.WriteLine(e);
           char s= 'a';
            Console.WriteLine(s);

            int count;
            double count1;
            char count2;
           count= int.Parse(Console.ReadLine()); //stringi int e çeviriyor
            count1 = double.Parse(Console.ReadLine());
            count2 = char.Parse(Console.ReadLine()); // 1 karakter uzunluğunda olur char.
            Console.WriteLine(count);
            Console.WriteLine(count1);
            Console.WriteLine(count2);
            


            Console.Read();



        }
    }
}
