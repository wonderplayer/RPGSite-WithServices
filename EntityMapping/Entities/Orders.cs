using System;
using System.Collections.Generic;

namespace RPGSite.Entities
{
    public class Orders
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public int UserId { get; set; }

        public int Total { get; set; }

        public virtual Users User { get; set; }

        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}
