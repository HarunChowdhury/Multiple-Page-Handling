﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPp.Models
{
    public class Login
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public virtual Student AStudent{ get; set; }
    }
}