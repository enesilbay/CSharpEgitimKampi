using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi.EntityLayer.Concrete
{
    public class Category  
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; } // veritabanına göndermek için property olması lazım.
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }




    }
}








/* Field-Variable-Property
 * int x; sınıfın içine tanımlanırsa field olur.
 * int z; method içinde tanımlanırsa variable olur.
 * public int y {get;set};  sınıfın içinde get set ile bu şekilde tanımlanırsa property olur.
 * 
 * 
 * 
 * 
 * Access Modifiers(erişim belirleyiciler)
 * public--> solution'un altındaki heryerden erişim sağlanabilir.
 * private-->sadece bulunduğu class'dan erişim sağlanır.
 * internal-->sadce bulunduğu katmandan erişim sağlanır.(Entity katmanı burada)
 * protected-->Sınıf ve sınıfı miras alan yerlerden erişim sağlanıyor.
 */
