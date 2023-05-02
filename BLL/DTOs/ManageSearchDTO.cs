using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ManageSearchDTO
    {
        public int search_Id { get; set; }

        
        public int cust_id { get; set; }

        public string search_text { get; set; }
    }
}
