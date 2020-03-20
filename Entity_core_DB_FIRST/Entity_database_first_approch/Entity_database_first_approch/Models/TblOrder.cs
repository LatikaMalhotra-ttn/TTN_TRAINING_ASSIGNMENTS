using System;
using System.Collections.Generic;

namespace Entity_database_first_approch.Models
{
    public partial class TblOrder
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? ProductId { get; set; }
        public bool? OrderStatus { get; set; }
        public DateTime? OrderDate { get; set; }

        public virtual TblCustomer Customer { get; set; }
        public virtual TblProduct Product { get; set; }
    }
}
