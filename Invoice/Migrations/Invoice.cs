using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Migrations
{
    public class Invoice
    {
        public int id { get; set; }
        public int customerID { get; set; }
        public string invoiceDetail { get; set; }
        public DateTime date { get; set; }
    }
}

