using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eManager.Domain;
using Microsoft.EntityFrameworkCore;

namespace eManager.DataAccess.Repositories
{
    public class InvoiceRepository : IRepository<Invoice>
    {
        private ManagerDbContext _context;
        public InvoiceRepository(ManagerDbContext context)
        {
            _context = context;
        }
        public void DeleteById(int id)
        {
            ClientInvoice invoiceClient = _context.ClientInvoices.FirstOrDefault(x => x.Invoice_Id == id);
            ClientServiceDTO invoiceService = _context.InvoiceServices.FirstOrDefault(x => x.InvoiceId == id);
           
            Invoice invoice = _context.Invoices.FirstOrDefault(x => x.InvoiceId == id);

            if (invoice != null)
                _context.Invoices.Remove(invoice);
            if (invoiceClient != null)
                _context.ClientInvoices.Remove(invoiceClient);
            if (invoiceService != null)
                _context.InvoiceServices.Remove(invoiceService);
       

            _context.SaveChanges();
        }

        public List<Invoice> GetAll()
        {
            return _context.Invoices
              .Include(x => x.InvoiceServices)
              .ThenInclude(x => x.Service)
              .Include(i => i.ClientInvoices)
              .ThenInclude(i => i.Client)
              .Include(x => x.User)
              .ToList();
        }

        public Invoice GetById(int id)
        {
            return _context.Invoices
              .Include(i => i.InvoiceServices)
              .ThenInclude(i => i.Service).Include(i => i.ClientInvoices).ThenInclude(i => i.Client)
              .Include(i => i.User)
              .FirstOrDefault(x => x.InvoiceId == id);
        }

        public int Insert(Invoice entity)
        {

            _context.Invoices.Add(entity);
            int id = _context.SaveChanges();
            return id;
        }

        public int Update(Invoice invoice)
        {
            Invoice invoiceModel = _context.Invoices.FirstOrDefault(x => x.InvoiceId == invoice.InvoiceId);
            
          
            if (invoiceModel != null)
            {
                invoiceModel.InvoiceId = invoice.InvoiceId;
                invoiceModel.InvoiceServices = invoice.InvoiceServices;
                invoiceModel.Client = invoice.Client;
                invoiceModel.ClientAddress = invoice.ClientAddress;
                invoiceModel.ClientId = invoice.ClientId;
                invoiceModel.ClientName = invoice.ClientName;
                invoiceModel.Description = invoice.Description;
                invoiceModel.DueDate = invoice.DueDate;
                invoiceModel.InvoiceDate = invoice.InvoiceDate;
                invoiceModel.User = invoice.User;
                invoiceModel.UserId = invoice.UserId;
                invoiceModel.Price = invoice.Price;
                invoiceModel.PaymentPeriod = invoice.PaymentPeriod;
             
            }

            _context.Invoices.Update(invoiceModel);
            int id = _context.SaveChanges();
            return id;

        }
    }

}