﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi.EntityLayer.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }
        public int PruductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity{ get; set; }
        public int UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }




    }
}
