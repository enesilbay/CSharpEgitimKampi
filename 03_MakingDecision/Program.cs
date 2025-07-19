using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if

            //string password;
            //password=Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("şifre doğru:"+password);
            //}
            //else {
            //    Console.WriteLine("şifre yanlış.");   
            //}


            //string capital, country;
            //Console.WriteLine("ülkeyi giriniz:");
            //country = Console.ReadLine();
            //Console.WriteLine("başkenti giriniz");
            //capital = Console.ReadLine();
            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("doğru bilgiler girdiniz");
            //}
            //else
            //{
            //    Console.WriteLine("yanlış.");
            //}
            #endregion

            #region mod işlemleri
            //int number =26;
            //int result = number % 5;
            //Console.WriteLine(result);




            #endregion

            #region team
            //char team;
            //Console.WriteLine("lütfen takım sayısını giriniz.");
            //team =char.Parse(Console.ReadLine());
            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else{
            //    Console.WriteLine("diğer");
            //}



            #endregion

            #region switch case

            Console.WriteLine("bir ay giriniz");
            int sayi = int.Parse(Console.ReadLine());

            switch (sayi) {

                case 1:
                    Console.WriteLine("ocak");
                    break;
                    case 2: Console.WriteLine("şubat");
                    break;
                    default : Console.WriteLine("ocak"); 
                    break;

                
            
            
            
            
            }



            #endregion












            Console.Read();

        }
    }
}
