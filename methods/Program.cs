using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region void methodlar
            void CustomerList() {
                Console.WriteLine("enes ilbay");
            }
            CustomerList();

            #endregion

            #region parametreli void

            void Yazdir(string name) {
                Console.WriteLine(name);
            }
            Yazdir("enes");
            #endregion

            #region değer döndüren metotlar
            
            String namee()
            {
                return "enes ilby";
            }
            Console.WriteLine(namee());
            
            
            #endregion


            Console.Read();

        }
    }
}
