using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
   public class Product:IEntity //ENtity olması için Core katmanını referans alarak kullandık.
    {
        public int ProductID { get; set; }
        public int ProductName { get; set; }
        public int CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }

    }
}
