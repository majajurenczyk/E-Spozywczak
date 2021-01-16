﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Models
{
    public class OrdersHistory
    {
        [Key]
        public int OrdersHistoryId;
        public ICollection<Order> OrdersInHistory;
    }
}
