using System;
using System.Collections.Generic;

namespace Model.Model
{
    public partial class OrdersProducts
    {
        public int OrderProductId { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public short? Quantity { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Products Product { get; set; }
    }
}
