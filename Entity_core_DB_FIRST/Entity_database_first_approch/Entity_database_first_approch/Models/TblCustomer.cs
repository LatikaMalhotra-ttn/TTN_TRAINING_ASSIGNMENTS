using System;
using System.Collections.Generic;

namespace Entity_database_first_approch.Models
{
    public partial class TblCustomer
    {
        public TblCustomer()
        {
            TblOrder = new HashSet<TblOrder>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
        public int? ZipPin { get; set; }

        public virtual ICollection<TblOrder> TblOrder { get; set; }
    }
}
