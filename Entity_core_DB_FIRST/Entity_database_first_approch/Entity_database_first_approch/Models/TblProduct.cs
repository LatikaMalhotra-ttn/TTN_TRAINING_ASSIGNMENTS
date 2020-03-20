using System;
using System.Collections.Generic;

namespace Entity_database_first_approch.Models
{
    public partial class TblProduct
    {
        public TblProduct()
        {
            TblOrder = new HashSet<TblOrder>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public int? Price { get; set; }

        public virtual ICollection<TblOrder> TblOrder { get; set; }
    }
}
