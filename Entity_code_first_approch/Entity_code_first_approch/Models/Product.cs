using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entity_code_first_approch.Models
{
    //[Table("tblProducts")]
    public class Product
    {
        // Scalar Properties
        [Key]   
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public int Price { get; set; }

        // Navigation Property
        public List<Order> Orders { get; set; }
    }
}