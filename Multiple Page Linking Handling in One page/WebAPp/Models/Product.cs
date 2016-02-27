using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string  Code { get; set; }
        public string  Description { get; set; }

        //public virtual Shop VShop{ get; set; }
         
    }
}