using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Customer
    {
        [Key]
        public int CustId { get; set; }
        [Required]
        public string Fname { get; set; }
        [Required]
        public string Lname { get; set; }
        [Required]
        public string Phone_number { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string gender { get; set; }
        public DateTime Dob { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string review { get; set; }
    }
}
