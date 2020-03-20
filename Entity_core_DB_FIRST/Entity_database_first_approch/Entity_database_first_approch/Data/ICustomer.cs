using Entity_database_first_approch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_database_first_approch.Data
{
    public interface ICustomer
    {
        public IEnumerable<TblCustomer> GetData();
        public bool Insert(TblCustomer customer);

        //public bool Update(TblOrder);

        public bool DeleteByCustId(int id);
        public bool DeleteByProdId(int id);
    }
}
