using System;
using System.Collections.Generic;
using System.Linq;
using Entity_code_first_approch.Models;
using System.Web;
using System.Web.Http;
using System.Data.Entity;


namespace Entity_code_first_approch.Data
{
    public class CustomerClass
    {

        //this method is used to retrieve data from the table
        public IEnumerable<Customer> GetData()
        {
            var context = new CustomerDBContext();

            var result = context.Customers.Include(s => s.Orders).ToList();
            return result;

        }

        //this method is used to insert data in the table
        public bool Insert(Customer customer)
        {
            var context = new CustomerDBContext();
            try
            {

                context.Customers.Add(customer);
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


        //this method is used to delete customers in customer table via their id
        public bool DeleteByCustId(int id)
        {
            try
            {
                using (var context = new CustomerDBContext())
                {
                    var std1 = context.Orders.FirstOrDefault(q => q.CustomerID == id);
                    context.Orders.Remove(std1);
                    var std = context.Customers.FirstOrDefault(s => s.CustomerId == id);
                    context.Customers.Remove(std);
                    context.SaveChanges();
                    return true;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //this method is used to delete Products in product table via their id
        public bool DeleteByProdId(int id)
        {
            try
            {
                using (var context = new CustomerDBContext())
                {
                    var std1 = context.Orders.FirstOrDefault(q => q.ProductID == id);
                    context.Orders.Remove(std1);
                    var std = context.Products.FirstOrDefault(s => s.ProductId == id);
                    context.Products.Remove(std);
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