using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Invoice.Migrations;
using Invoice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Invoice.Controllers
{
    [ApiController]
    public class InvoiceController : Controller
    {
   
            private readonly InvoiceDb _context;

            public InvoiceController(InvoiceDb context)
            {
                _context = context;
            }

        // GET: api/Invoice
        [HttpGet("api/Invoice")]
            public async Task<IActionResult> GetInoice()
            {
                var invoices = await _context.Invoice
                                           .Select(b => new InvoiceDto
                                           {
                                               id = b.id,
                                               customerID = b.customerID,
                                               invoiceDetail = b.invoiceDetail,
                                               date= b.date
                                           })
                                           .ToListAsync();
                return Ok(invoices);
            }      
    }
}
