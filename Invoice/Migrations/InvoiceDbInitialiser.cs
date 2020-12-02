using Invoice.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Invoice.Migrations
{
    public static class InvoiceDbInitialiser
    {
        public static async Task SeedTestData(InvoiceDb context,
                                              IServiceProvider services)
        {
            if (context.Invoice.Any())
            {
                //db seems to be seeded
                return;
            }

            var invoices = new List<Invoice>
            {
                new Invoice { customerID = "0", FromName="Mr",FromEmail = "Mr@aol.com", Message="buy", date = new DateTime(2020,5,25), Dispatched = true },
                new Invoice { customerID = "2", FromName="Jeff",FromEmail = "Jeff@aol.com", Message="buy more", date =  new DateTime(2020,9,25) , Dispatched = true }

            };
            invoices.ForEach(c => context.Invoice.Add(c));

            await context.SaveChangesAsync();
        }
    }
}
