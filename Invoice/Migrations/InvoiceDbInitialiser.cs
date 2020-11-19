using Invoice.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Producks.Data
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
                new Invoice { customerID = 0, invoiceDetail="shoes Num:6 Miss Buyer address", date = 19/11/2020 },
                 new Invoice { customerID = 1, invoiceDetail="hat Num:6 Mr Buyer address", date = 18/11/2020 }

            };
            invoices.ForEach(c => context.Invoice.Add(c));

            await context.SaveChangesAsync();
        }
    }
}
