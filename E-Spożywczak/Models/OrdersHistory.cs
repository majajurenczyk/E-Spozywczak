﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Models
{
    public class OrdersHistory
    {
        public int OrdersHistoryId;
        public ICollection<Order> OrdersInHistory;
    }
}
