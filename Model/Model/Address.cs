using System;
using System.Collections.Generic;

namespace Model.Model
{
    public partial class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public int? CustId { get; set; }

        public virtual Customers Cust { get; set; }
    }
}
