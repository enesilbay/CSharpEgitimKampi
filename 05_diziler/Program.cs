using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] dizi = new string[4];
            dizi[0] = "beyaz";
            dizi[1] = "kırmızı";
            dizi[2] = "sarı";
            dizi[3] = "mavi";
             Console.WriteLine(dizi[0]);
             for (int i = 0; i < dizi.Length; i++) { 
            Console.WriteLine(dizi[i]);}
            int[] dizi3 = { 1, 2, 8, 7, 9, 5 };

            int index = Array.IndexOf(dizi,"beyaz");//eleman arama indexini verir.
            Array.Sort(dizi3);// diziyi sıralar
            Array.Reverse(dizi3);//reverseler 
            Console.WriteLine("**********");
            Console.WriteLine(dizi3.Max());
            Console.WriteLine(dizi3.Min());
            Console.WriteLine("**********");







            for (int i = 0; i < dizi3.Length; i++)
            {
                Console.WriteLine(dizi3[i]);
            }


            string[] cities = { "ankara" ,"istanbul","denizli"};

            int[] dizi2 = new int[4];
            for (int i = 0; i < dizi2.Length; i++){
                dizi2[i] = int.Parse(Console.ReadLine());}





            for (int i = 0; i < dizi2.Length; i++)
            {
                Console.Write(dizi2[i]+",");
            }







            Console.Read();



        }
    }
}
