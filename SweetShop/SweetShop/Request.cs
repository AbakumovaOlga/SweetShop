﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetShop
{
    public class Request
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int CakeId { get; set; }

        public int? BakerId { get; set; }

        public int Count { get; set; }

        public decimal Sum { get; set; }

        public RequestStatus Status { get; set; }

        public DateTime DateCreate { get; set; }

        public DateTime? DateBaking { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Cake Cake { get; set; }

        public virtual Baker Baker { get; set; }
    }
}
