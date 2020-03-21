using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entity_code_first_approch.Models
{
    //[Table("tblOrders")]
    public class Order
    {
        // Scalar Properties
        [Key]
        public int OrderId { get; set; }
        public bool OrderStatus { get; set; }
        public string Date { get; set; }
        public int QuantityOrdered { get; set; }



        // Navigation Property
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }



        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public Product Product { get; set; }

    }
}