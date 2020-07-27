using System;
using System.Collections.Generic;

namespace Model.Model
{
    public partial class Orders
    {
        public Orders()
        {
            OrdersProducts = new HashSet<OrdersProducts>();
        }

        public int OrderId { get; set; }
        public int CustId { get; set; }
        public DateTime? InvoiceCreationDate { get; set; }
        public DateTime? DeliveryDueDate { get; set; }
        public DateTime? PaymentDueDate { get; set; }

        public virtual Customers Cust { get; set; }
        public virtual ICollection<OrdersProducts> OrdersProducts { get; set; }
    }
}
