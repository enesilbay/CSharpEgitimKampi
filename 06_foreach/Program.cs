using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region foreach
            //forecah(1 2 3 4)
            //1:değişken türü, 2:değişken adı,3:in,4:liste,dizi,koleksiyon
            //string[] cities = {"istanbul","ankara","denizli","izmir","kocaeli","aydın","manisa" };
            //foreach (string i in cities)
            //{
            //    Console.WriteLine(i);
            ////}
            #endregion

            #region list
            List<int> number = new List<int>()
            {
                1,2,3,4,5,6,7,8,9 //listeye böyle atama yapılabilir.
            };

            foreach (int i in number) { 
            Console.Write(i+" ");
            }
            Console.WriteLine();
            string word = "enes";
            foreach (char c in word) { 
            Console.Write(c+" ");

            }





            #endregion





        }
    }
}
