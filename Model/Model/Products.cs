using System;
using System.Collections.Generic;

namespace Model.Model
{
    public partial class Products
    {
        public Products()
        {
            OrdersProducts = new HashSet<OrdersProducts>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Desciption { get; set; }
        public decimal? Price { get; set; }
        public short? Quantity { get; set; }

        public virtual ICollection<OrdersProducts> OrdersProducts { get; set; }
    }
}
