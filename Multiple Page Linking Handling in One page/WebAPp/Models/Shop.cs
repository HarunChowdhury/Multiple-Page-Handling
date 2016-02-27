using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPp.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public string Address { get; set; }

        public virtual Product VProducts{ get; set; } 
  

    }
}