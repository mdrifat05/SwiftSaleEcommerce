using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Order
    {
       

        [Key]
        public int orderId { get; set; }
        [Required]
        public DateTime Order_Date { get; set; }
        [Required]
        public int total_price { get; set; }
        public string status { get; set; }
        public int? custId { get; set; }

        public int? DelId { get; set; }

    }
}
