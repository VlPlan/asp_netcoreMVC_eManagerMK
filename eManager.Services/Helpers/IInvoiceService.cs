using System;
using System.Collections.Generic;
using System.Text;
using eManager.Domain;
using eManager.WebModels;

namespace eManager.Services.Helpers
{
    public interface IInvoiceService
    {      
        InvoiceViewModel GetCurrentInvoice();
        int CreateInvoice(InvoiceViewModel invoice);
        int RemoveServiceFromInvoice(int invoiceId, int serviceId, string userId, out string serviceName);
        List<InvoiceViewModel> ShowInvoices();
        void RemoveInvoice(int id);
        int RegisterInvoice(InvoiceViewModel invoice, string description, int invoiceId, string userId, int clientId, string invoiceNumber, string clientName, DateTime invoiceDate, double paymentPeriod);
        int ChangePrice(int invoiceId, int serviceId, double currencyRate);
        double ChangeQuantity(int invoiceId, int serviceId, double quantity);
        int AddService(int invoiceId, int serviceId, int clientId,  string userId);
        int UpdateInvoice(InvoiceViewModel invoiceModel);
    }
}
