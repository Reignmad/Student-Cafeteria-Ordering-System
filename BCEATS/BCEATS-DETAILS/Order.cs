using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_Eats
{
    class Order
    {
        public Member OrderedBy { get; set; }
        public DateTime OrderTime { get; set; }

        public Order(Member orderedBy)
        {
            OrderedBy = orderedBy;
            OrderTime = DateTime.Now;
        }
    }
}

