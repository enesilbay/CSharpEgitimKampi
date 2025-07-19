using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi.EntityLayer.Concrete
{
    public class Customer //class lar ilgili tabloya ait sütünları tutuyor.Her class ilgili olduğu properity ile ilişkilendiriliyor(solid single resp.)
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerDistrict { get; set; }
        public string CustomerCity { get; set; }
        public List<Order> Orders { get; set; }
        public bool CustomerStatus { get; set; }










    }
}
