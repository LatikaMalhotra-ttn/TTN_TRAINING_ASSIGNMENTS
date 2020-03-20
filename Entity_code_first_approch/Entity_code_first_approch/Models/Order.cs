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
        public int Id { get; set; }
        public bool OrderStatus { get; set; }
        public string Date { get; set; }

        // Navigation Property

        //public int DepartmentId { get; set; }
        //[ForeignKey("CustomerId")]
        //public Customer Customer { get; set; }
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }


        //public int ProductId { get; set; }
        //[ForeignKey("ProductId")]
        // public Product Product { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public Product Product { get; set; }

    }
}