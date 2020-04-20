using System;
using System.Collections.Generic;
using System.Linq;
using eManager.DataAccess;
using eManager.Domain;
using eManager.Services.Helpers;
using eManager.WebModels;

namespace eManager.Services.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IRepository<Client> _clientRepository;
        private readonly IRepository<Service> _serviceRepository;
        private readonly IRepository<Invoice> _invoiceRepository;
        private readonly IUserRepository _userRepository;
        public InvoiceService(IRepository<Client> clientRepository, IRepository<Service> serviceRepository, IUserRepository userRepository, IRepository<Invoice> invoiceRepository)
        {
            _clientRepository = clientRepository;
            _serviceRepository = serviceRepository;
            _userRepository = userRepository;
            _invoiceRepository = invoiceRepository;
        }


        public int AddService(int invoiceId, int serviceId, int clientId, string userId)
        {
            

            Service service = _serviceRepository.GetById(serviceId);

            Invoice invoice = _invoiceRepository.GetById(invoiceId);

            Client client = _clientRepository.GetById(clientId);



            ClientServiceDTO productInvoice = new ClientServiceDTO()
            {
                
                Service = new Service() { Name = service.Name, Price = service.Price, Quantity = service.Quantity, Client = service.Client, Currency = service.Currency, ClientId = service.ClientId, ClientInvoices = service.ClientInvoices, CurrencyRate = service.CurrencyRate },
                Invoice = invoice 
                
            };


            ClientInvoice clientInvoice = new ClientInvoice()
            {
                ClientId = service.ClientId,
                Invoice_Id = invoice.InvoiceId
            };


            invoice.InvoiceServices.Add(productInvoice);
            invoice.ClientInvoices.Add(clientInvoice);

            invoice.Client = client;
            invoice.ClientName = client.Name;
            invoice.ClientId = client.Id;
            invoice.ClientAddress = client.Address;

            User user = _userRepository.GetById(userId);
            invoice.User = user;

            int id = _invoiceRepository.Update(invoice);
            return id;

        }

        

        public int RemoveServiceFromInvoice(int invoiceId, int serviceId, string userId, out string serviceName)
        {
            try
            {

                Service service = _serviceRepository.GetById(serviceId);

                Invoice invoice = _invoiceRepository.GetById(invoiceId);
                serviceName = service.Name;
                ClientServiceDTO productInvoice = invoice.InvoiceServices.FirstOrDefault(x => x.ServiceId == serviceId && x.InvoiceId == invoiceId);

                invoice.InvoiceServices.Remove(productInvoice);

                User user = _userRepository.GetById(userId);
                invoice.User = user;

                int id = _invoiceRepository.Update(invoice);

                return id;

            }
            catch (Exception ex)
            {
                string message = $"Something went wrong, please contact your administrator! {ex.InnerException}";
                throw new Exception(message, ex);
            }
        }


        public int CreateInvoice(InvoiceViewModel Invoice)
        {
            try
            {

                Invoice newInvoice = new Invoice();
                var lastInvoice = _invoiceRepository.GetAll().OrderByDescending(i => i.InvoiceId).FirstOrDefault();

                if (lastInvoice == null)
                {

                    newInvoice.InvoiceNumber = "OGN2020/0001";
                }
                else
                {

                    newInvoice.InvoiceNumber = "OGN2020/" + (Convert.ToInt32(lastInvoice.InvoiceNumber.Substring(9, lastInvoice.InvoiceNumber.Length - 9)) + 1).ToString("D3");
                }



                newInvoice.InvoiceServices = new List<ClientServiceDTO>();
                foreach (var i in Invoice.InvoiceServices)
                {
                    newInvoice.InvoiceServices.Add(new ClientServiceDTO { InvoiceId = Invoice.Id, ServiceId = i.ServiceId });
                }
                newInvoice.ClientInvoices = new List<ClientInvoice>();
                foreach (var c in Invoice.ClientInvoices)
                {
                    newInvoice.ClientInvoices.Add(new ClientInvoice { ClientId = c.ClientId, Invoice_Id = Invoice.Id });
                }
                newInvoice.InvoiceId = Invoice.Id;
                newInvoice.InvoiceDate = Invoice.InvoiceDate;
                newInvoice.PaymentPeriod = Invoice.PaymentPeriod;
                newInvoice.Price = Invoice.Price;
                newInvoice.ClientId = Invoice.SelectedClient;
                newInvoice.ClientName = Invoice.ClientName;
                newInvoice.ClientAddress = Invoice.ClientAddress;
                newInvoice.DueDate = Invoice.DueDate;
                newInvoice.Description = Invoice.Description;
              

                var addInvoice = _invoiceRepository.Insert(newInvoice);
                return addInvoice;
            }
            catch (Exception ex)
            {
                string message = $"Something went wrong, please contact your administrator! {ex.InnerException}";
                throw new Exception(message, ex);
            }
        }



        public InvoiceViewModel GetCurrentInvoice()
        {
            try
            {


                var invoice = _invoiceRepository.GetAll().OrderByDescending(i => i.InvoiceId).FirstOrDefault();

                if (invoice == null)
                {

                    CreateInvoice(new InvoiceViewModel());
                    return GetCurrentInvoice();
                }
                List<Service> services = invoice.InvoiceServices
                                                     .Select(x =>
                                                     _serviceRepository.GetById(x.ServiceId)).ToList();


                InvoiceViewModel invoiceModel = new InvoiceViewModel();
                invoiceModel.Id = invoice.InvoiceId;
                invoiceModel.InvoiceNumber = invoice.InvoiceNumber;
                if(invoiceModel.InvoiceNumber == null)
                {
                    var lastInvoice = _invoiceRepository.GetAll().LastOrDefault(x => x.InvoiceNumber != null);
                    invoiceModel.InvoiceNumber = "OGN2020/" + (Convert.ToInt32(lastInvoice.InvoiceNumber.Substring(9, lastInvoice.InvoiceNumber.Length - 9)) + 1).ToString("D3");
                }
                invoiceModel.InvoiceDate = invoice.InvoiceDate;
                invoiceModel.PaymentPeriod = invoice.PaymentPeriod;
                invoiceModel.Price = invoice.Price;
                invoiceModel.SelectedClient = invoice.ClientId;
                invoiceModel.Client = new ClientViewModel(invoice.Client);
                //invoiceModel.User = new UserViewModel { Id = UserId };
                invoiceModel.ClientAddress = invoice.Client.Address;
                invoiceModel.DueDate = invoice.DueDate;
                invoiceModel.ClientName = invoice.ClientName;
     
                invoiceModel.InvoiceServices = invoice.InvoiceServices.Select(x => new ServiceViewModel (x.Service)).ToList();
                invoiceModel.ClientInvoices = invoice.ClientInvoices.Select(c => new ClientViewModel(c.Client)).ToList();
              

                invoiceModel.Description = invoice.Description;
                return invoiceModel;
            }
            catch (Exception ex)
            {
                string message = $"Invoice not exist! {ex.InnerException}";
                throw new Exception(message, ex);
            }
        }

        public void RemoveInvoice(int id)
        {
            _invoiceRepository.DeleteById(id);
        }

        public List<InvoiceViewModel> ShowInvoices()
        {
            var invoices = _invoiceRepository.GetAll().ToList();

            List<InvoiceViewModel> allInvoices = new List<InvoiceViewModel>();
            foreach (var invoice in invoices)
            {
                allInvoices.Add(new InvoiceViewModel(invoice));
            }
            return allInvoices;
        }






        public int RegisterInvoice(InvoiceViewModel invoice, string description, int invoiceId, string userId, int clientId, string invoiceNumber, string clientName, DateTime invoiceDate, double paymentPeriod)
        {
            try
            {
                var Invoice = _invoiceRepository.GetAll().OrderByDescending(i => i.InvoiceId).FirstOrDefault();

                Invoice.InvoiceNumber = invoice.InvoiceNumber;
                Invoice.InvoiceDate = invoiceDate;
                Invoice.PaymentPeriod = paymentPeriod;
                Invoice.DueDate = invoiceDate.AddDays(paymentPeriod);
                Invoice.Description = description;
                Invoice.ClientAddress = Invoice.ClientAddress;
                Invoice.ClientId = clientId;
                Invoice.ClientInvoices = Invoice.ClientInvoices;
                Invoice.Price = Invoice.Price;
             
                Invoice currentInvoice = new Invoice();

                currentInvoice.InvoiceNumber = invoiceNumber;
                currentInvoice.InvoiceDate = Invoice.InvoiceDate;
                currentInvoice.PaymentPeriod = paymentPeriod;
                currentInvoice.DueDate = invoiceDate.AddDays(paymentPeriod);
                currentInvoice.Description = description;
                currentInvoice.ClientAddress = Invoice.ClientAddress;
                currentInvoice.ClientId = clientId;
                currentInvoice.ClientInvoices = Invoice.ClientInvoices;
                currentInvoice.Price = Invoice.Price;
                currentInvoice.InvoiceServices = new List<ClientServiceDTO>();
   
                User user = _userRepository.GetById(userId);
                Client client = _clientRepository.GetById(clientId);
                currentInvoice.ClientName = Invoice.ClientName;
                currentInvoice.User = user;
                currentInvoice.Client = Invoice.Client;

                _invoiceRepository.Insert(currentInvoice);
                return  _invoiceRepository.Update(Invoice);
                
            }
            catch (Exception ex)
            {
                string message = $"Something went wrong registering Invoice! {ex.InnerException}";
                throw new Exception(message, ex);
            }

        }




        public double ChangeQuantity(int invoiceId, int serviceId, double quantity)
        {




            Invoice invoiceModel = _invoiceRepository.GetById(invoiceId);
            Service service = _serviceRepository.GetById(serviceId);

            var serviceModel = invoiceModel.InvoiceServices.OrderByDescending(x =>x.ServiceId == serviceId && x.InvoiceId == invoiceId).FirstOrDefault();

            serviceModel.Service.Quantity = quantity;
            double id = _invoiceRepository.Update(invoiceModel);
            return id;


        }

        public int ChangePrice(int invoiceId, int serviceId, double currencyRate)
        {

            var currentInvoice = _invoiceRepository.GetById(invoiceId);

            foreach (var service in currentInvoice.InvoiceServices)
            {
                if (service.Service.Currency == Currency.EUR)
                {
                    service.Service.CurrencyRate = currencyRate;
                }
            }

            return _invoiceRepository.Update(currentInvoice);

        }

        public int UpdateInvoice(InvoiceViewModel invoiceModel)
        {
            var updatedInvoice = new Invoice();
            updatedInvoice.InvoiceId = invoiceModel.Id;
            updatedInvoice.InvoiceDate = invoiceModel.InvoiceDate;
            updatedInvoice.InvoiceNumber = invoiceModel.InvoiceNumber;
            updatedInvoice.InvoiceServices = new List<ClientServiceDTO>();
            updatedInvoice.ClientInvoices = new List<ClientInvoice>();
         foreach(var c in invoiceModel.ClientInvoices)
            {
                updatedInvoice.ClientInvoices.Add(new ClientInvoice()
                {
                    Invoice_Id = invoiceModel.Id,
                    ClientId = invoiceModel.SelectedClient
                });
            }
            updatedInvoice.ClientAddress = invoiceModel.ClientAddress;
            updatedInvoice.ClientId = invoiceModel.SelectedClient;
            updatedInvoice.ClientName = invoiceModel.ClientName;
            updatedInvoice.Description = invoiceModel.Description;
            updatedInvoice.DueDate = invoiceModel.DueDate;
            updatedInvoice.Price = invoiceModel.Price;
            updatedInvoice.PaymentPeriod = invoiceModel.PaymentPeriod;

            foreach(var service in invoiceModel.InvoiceServices)
            {
                updatedInvoice.InvoiceServices.Add(new ClientServiceDTO()
                {
                   
                    InvoiceId=invoiceModel.Id,
                    ServiceId=service.ServiceId

                });
            }
            new InvoiceViewModel(updatedInvoice);
            var updated = _invoiceRepository.Update(updatedInvoice);
            return updated;

        }


    }
}
 
