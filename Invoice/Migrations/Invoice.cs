using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Migrations
{
    public class Invoice
    {
        public String id { get; set; }
        public String customerID { get; set; }

        [Required, Display(Name = "Your name")]
        public string FromName { get; set; }
        [Required, Display(Name = "Your email"), EmailAddress]
        public string FromEmail { get; set; }
        [Required]
        public string Message { get; set; }
        public DateTime date { get; set; }
        public Boolean Dispatched { get; set; }
    }
}


