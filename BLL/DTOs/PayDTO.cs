using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PayDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public float Amount { get; set; }
       // public int OrderId { get; set; }
        //public virtual Order Order { get; set; }
    }
}
