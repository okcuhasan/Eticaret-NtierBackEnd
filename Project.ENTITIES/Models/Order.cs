﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Order : BaseEntity
    {
        public string ShippingAddress { get; set; }

        // relational properties
        public int AppUserID { get; set; }

        public virtual AppUser AppUser { get; set; } 

        public virtual List<OrderDetail> OrderDetails { get; set; }  // çoka çok ilişki - junction table
    }
}
