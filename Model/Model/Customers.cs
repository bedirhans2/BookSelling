using System;
using System.Collections.Generic;

namespace Model.Model
{
    public partial class Customers
    {
        public Customers()
        {
            Address = new HashSet<Address>();
            Orders = new HashSet<Orders>();
        }

        public int CustId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
