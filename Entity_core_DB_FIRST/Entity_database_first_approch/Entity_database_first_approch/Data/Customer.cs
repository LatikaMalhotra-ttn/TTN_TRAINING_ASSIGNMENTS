using Entity_database_first_approch.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_database_first_approch.Data
{
    public class Customer:ICustomer
    {
        public IEnumerable<TblCustomer> GetData()
        {
            var context = new entity_database_first_approchContext();

            var result = context.TblCustomer.Include(s => s.TblOrder).ToList();
            return result;

        }


        public bool Insert(TblCustomer customer)
        {
            var context = new entity_database_first_approchContext();
            try
            {

                context.TblCustomer.Add(customer);
                context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //public bool UpdateData(TblOrder order)
        //{
        //    ;
        //    try
        //    {

        //        using (var context = new entity_database_first_approchContext())
        //        {
        //            context.TblOrder.Add(order);
        //            var std= context.TblOrder.FirstOrDefault(s => s.CustomerId == order.CustomerId);


        //        }
        //        return true;

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}



        public bool DeleteByCustId(int id)
        {
            try
            {
                using (var context = new  entity_database_first_approchContext())
                {
                    var std1 = context.TblOrder.FirstOrDefault(q => q.CustomerId == id);
                    context.TblOrder.Remove(std1);
                    var std = context.TblCustomer.FirstOrDefault(s => s.Id == id);
                    context.TblCustomer.Remove(std);
                    context.SaveChanges();
                    return true;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool DeleteByProdId(int id)
        {
            try
            {
                using (var context = new entity_database_first_approchContext())
                {
                    var std1 = context.TblOrder.FirstOrDefault(q => q.ProductId == id);
                    context.TblOrder.Remove(std1);
                    var std = context.TblProduct.FirstOrDefault(s => s.Id == id);
                    context.TblProduct.Remove(std);
                    context.SaveChanges();
                    return true;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        
        
    }
}
