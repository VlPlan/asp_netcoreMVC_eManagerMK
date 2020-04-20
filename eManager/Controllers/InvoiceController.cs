using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eManager.Domain;
using eManager.Models;
using eManager.Services.Helpers;
using eManager.WebModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using X.PagedList;
using X.PagedList.Mvc;

namespace eManager.Controllers
{
    [Authorize]
    public class InvoiceController : Controller
    {
        private readonly IServiceService _serviceService;
        private readonly IUserService _userService;
        private readonly IInvoiceService _invoiceService;
        private readonly IClientService _clientService;
        private readonly IToastNotification _toastNotification;

        public InvoiceController(IServiceService serviceService, IUserService userService, IInvoiceService invoiceService, IClientService clientService, IToastNotification toastNotification)
        {
            _serviceService = serviceService;
            _userService = userService;
            _invoiceService = invoiceService;
            _clientService = clientService;
            _toastNotification = toastNotification;
        }


        [Authorize(Roles = "admin, userVP")]
        [HttpGet]
        public IActionResult AddInvoice()
        {
            var model = new InvoiceViewModel();
            var lastInvoice = _invoiceService.ShowInvoices().OrderByDescending(i => i.Id).FirstOrDefault();
            if (lastInvoice == null)
            {
                model.InvoiceNumber = "OGN2020/0001";
            }
            else
            {
                model.InvoiceNumber = "OGN2020/" + (Convert.ToInt32(lastInvoice.InvoiceNumber.Substring(9, lastInvoice.InvoiceNumber.Length - 9)) + 1).ToString("D3"); ;
            }

            return View(model);
        }

        [Authorize(Roles = "admin, userVP")]
        [HttpPost]
        public IActionResult AddInvoice(InvoiceViewModel model)
        {

            int addedInvoice = _invoiceService.CreateInvoice(model);
            return RedirectToAction("Invoices", "Invoice");
        }


        [Authorize(Roles = "admin, userVP")]
        public IActionResult AddDetailsToInvoice(int invoiceId, int serviceId)
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            InvoiceViewModel invoice = _invoiceService.GetCurrentInvoice();
            ServiceViewModel service = _serviceService.GetServiceById(serviceId);
            var client = _clientService.GetClient(service.SelectedClientId);



            int result = _invoiceService.AddService(invoice.Id, serviceId, client.ClientId, user.Id);





            return RedirectToAction("CurrentInvoice");
        }
        [Authorize(Roles = "admin, userVP")]
        public IActionResult RemoveDetailsFromInvoice(int serviceId)
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            InvoiceViewModel invoice = _invoiceService.GetCurrentInvoice();

            string serviceName;
            int result = _invoiceService.RemoveServiceFromInvoice(invoice.Id, serviceId, user.Id, out serviceName);
            return RedirectToAction("CurrentInvoice");
        }


        [Authorize(Roles = "admin, userVP, userSN,userTP, userAMG, userEN, userSP, userGK, userKK")]
        public IActionResult Invoices(string sort, string search, string filter, int? page)
        {
            var invoices = _invoiceService.ShowInvoices().ToList();


            ViewBag.CurrentSort = sort;
            ViewBag.SortByClient = String.IsNullOrEmpty(sort) ? "client_desc" : "";
            ViewBag.SortByDate = sort == "Date" ? "date_desc" : "Date";
            ViewBag.SortByDueDate = sort == "DueDate" ? "duedate_desc" : "DueDate";
            ViewBag.SortByTotalPrice = sort == "TotalPrice" ? "totalprice_desc" : "TotalPrice";
            if (search != null)
            {
                page = 1;
            }
            else
            {
                search = filter;
            }
            ViewBag.CurrentFilter = search;

            if (!String.IsNullOrEmpty(search))
            {
                invoices = invoices.Where(i => i.Client.Name == search || i.ClientAddress == search || i.Description == search).ToList();

            }

            switch (sort)
            {
                case "client_desc":
                    invoices = invoices.OrderByDescending(c => c.ClientName).ToList();
                    break;
                case "date_desc":
                    invoices = invoices.OrderByDescending(c => c.InvoiceDate).ToList();
                    break;
                case "duedate_desc":
                    invoices = invoices.OrderByDescending(c => c.DueDate).ToList();
                    break;
                case "totalprice_desc":
                    invoices = invoices.OrderByDescending(c => c.TotalPrice).ToList();
                    break;

            }

            int pageSize = 10;
            int pageNumber = (page ?? 1);
            ViewBag.invoiceList = invoices.ToPagedList(pageNumber, pageSize);
            return View(invoices.ToPagedList(pageNumber, pageSize));
        }



        [Authorize(Roles = "admin, userVP")]
        public IActionResult CurrentInvoice()
        {

            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            InvoiceViewModel invoice = _invoiceService.GetCurrentInvoice();

            InvoiceViewModel invoiceModel = new InvoiceViewModel();
            invoiceModel.Id = invoice.Id;
            invoiceModel.InvoiceNumber = invoice.InvoiceNumber;
            invoiceModel.InvoiceDate = invoice.InvoiceDate;
            invoiceModel.PaymentPeriod = invoice.PaymentPeriod;
            invoiceModel.Price = invoice.Price;
            //invoiceModel.User = new UserViewModel() { Id=user.Id};
            invoiceModel.Description = invoice.Description;
            invoiceModel.SelectedClient = invoice.SelectedClient;
            invoiceModel.Client = invoice.Client;
            invoiceModel.ClientAddress = invoice.Client.Address;
            invoiceModel.DueDate = invoice.DueDate;
            invoiceModel.ClientName = invoice.ClientName;
            invoiceModel.ClientInvoices = invoice.ClientInvoices;
            invoiceModel.InvoiceServices = invoice.InvoiceServices;
            if (invoiceModel.InvoiceServices.Any(s => s.Currency == CurrencyView.ЕУР && s.CurrencyRate == 1))
            {
                invoiceModel.VAT = invoiceModel.VAT * 0;
                invoiceModel.TotalPrice = invoiceModel.Price * 61.50000;

            }
            if (invoiceModel.InvoiceServices.Any())
            {

                if (invoiceModel.ClientName.ToLower().Contains("arcelor") || invoiceModel.ClientName.ToLower().Contains("aрцелор") || invoiceModel.ClientName.ToLower().Contains("Liberty") || invoiceModel.ClientName.ToLower().Contains("либерти"))
                {
                    invoiceModel.VAT = invoiceModel.VAT * 0;
                    invoiceModel.TotalPrice = invoiceModel.Price;
                }
            }

            return View(invoiceModel);


        }



        [Authorize(Roles = "admin, userVP")]
        [HttpGet]
        public IActionResult DeleteInvoice(int invoiceId)
        {
            var invoice = _invoiceService.ShowInvoices().FirstOrDefault(x => x.Id == invoiceId);
            return View(invoice);


        }

        [Authorize(Roles = "admin, userVP")]
        [HttpPost]
        public IActionResult DeleteInvoice(InvoiceViewModel invoice)
        {

            _invoiceService.RemoveInvoice(invoice.Id);
            return RedirectToAction("Invoices", "Invoice");
        }


        [Authorize(Roles = "admin, userVP")]
        public IActionResult RegisterInvoice(InvoiceViewModel invoice, string description, int invoiceId, string userId, int clientId, string invoiceNumber, string clientName, double price, DateTime invoiceDate, double paymentPeriod)
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            InvoiceViewModel currentInvoice = _invoiceService.ShowInvoices().LastOrDefault();
            ClientViewModel client = _clientService.GetClient(currentInvoice.SelectedClient);
            var lastInvoice = _invoiceService.ShowInvoices().OrderByDescending(i => i.Id).FirstOrDefault();
            var newInvoice = new InvoiceViewModel();
            newInvoice.InvoiceNumber = currentInvoice.InvoiceNumber;
            newInvoice.InvoiceDate = invoiceDate;
            newInvoice.PaymentPeriod = paymentPeriod;
            newInvoice.DueDate = currentInvoice.InvoiceDate.AddDays(paymentPeriod);
            newInvoice.Client = client;
            //newInvoice.User = user;
            newInvoice.Description = description;
            newInvoice.ClientInvoices = currentInvoice.ClientInvoices;
            newInvoice.ClientName = currentInvoice.Client.Name;
            newInvoice.ClientAddress = currentInvoice.Client.Address;
            newInvoice.SelectedClient = currentInvoice.SelectedClient;
            newInvoice.Price = currentInvoice.Price;
            if (lastInvoice == null)
            {
                newInvoice.InvoiceNumber = "OGN2020/0001";
            }
            else
            {
                newInvoice.InvoiceNumber = "OGN2020/" + (Convert.ToInt32(lastInvoice.InvoiceNumber.Substring(9, lastInvoice.InvoiceNumber.Length - 9)) + 1).ToString("D3");
            }
            if (newInvoice.InvoiceServices.Any(s => s.Currency == CurrencyView.ЕУР && s.CurrencyRate == 1))
            {
                newInvoice.VAT = newInvoice.VAT * 0;
                newInvoice.TotalPrice = newInvoice.Price * 61.5000;

            }
            if (newInvoice.Client.Name.ToLower().Contains("arcelor") || newInvoice.Client.Name.ToLower().Contains("aрцелор") || newInvoice.Client.Name.ToLower().Contains("Liberty") || newInvoice.Client.Name.ToLower().Contains("либерти"))
            {
                newInvoice.VAT = newInvoice.VAT * 0;
                newInvoice.TotalPrice = newInvoice.Price;
            }
            _invoiceService.RegisterInvoice(currentInvoice, newInvoice.Description, invoiceId, user.Id, client.ClientId, newInvoice.InvoiceNumber, client.Name, invoiceDate, paymentPeriod);
            return RedirectToAction("invoices", "invoice");


        }


        [Authorize(Roles = "admin, userVP")]
        public IActionResult UpdatePrice(int invoiceId, int serviceId, double currencyRate)
        {
            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            InvoiceViewModel currentInvoice = _invoiceService.ShowInvoices().FirstOrDefault(x => x.Id == invoiceId);
            ServiceViewModel service = currentInvoice.InvoiceServices.FirstOrDefault(x => x.ServiceId == serviceId);

            service.CurrencyRate = currencyRate;

            _invoiceService.ChangePrice(currentInvoice.Id, service.ServiceId, currencyRate);
            return RedirectToAction("CurrentInvoice");


        }

        [Authorize(Roles = "admin, userVP, userSN,userTP, userAMG, userEN, userSP, userGK, userKK")]
        public IActionResult InvoiceDetails(InvoiceViewModel invoiceModel)
        {
            var invoice = _invoiceService.ShowInvoices().Where(x => x.Id == invoiceModel.Id).FirstOrDefault();
            if (invoice == null) return View("_Error");

            InvoiceViewModel invoiceToView = new InvoiceViewModel()
            {
                Id = invoice.Id,
                InvoiceDate = invoice.InvoiceDate,
                InvoiceNumber = invoice.InvoiceNumber,
                Client = invoice.Client,
                ClientAddress = invoice.ClientAddress,
                ClientName = invoice.ClientName,
                ClientInvoices = invoice.ClientInvoices,
                InvoiceServices = invoice.InvoiceServices,
                PaymentPeriod = invoice.PaymentPeriod,
                Price = invoice.Price,
                SelectedClient = invoice.SelectedClient,
                TotalPrice = invoice.TotalPrice,
                VAT = invoice.VAT,
                //User = invoice.User,
                DueDate = invoice.DueDate,
                Description = invoice.Description

            };

            if (invoiceToView.InvoiceServices.Any(s => s.Currency == CurrencyView.ЕУР && s.CurrencyRate == 1))
            {
                invoiceToView.VAT = invoiceToView.VAT * 0;
                invoiceToView.TotalPrice = invoiceToView.Price * 61.5000;

            }
            if (invoiceToView.ClientName.ToLower().Contains("arcelor") || invoiceToView.ClientName.ToLower().Contains("aрцелор") || invoiceToView.ClientName.ToLower().Contains("Liberty") || invoiceToView.ClientName.ToLower().Contains("либерти"))
            {
                invoiceToView.VAT = invoiceToView.VAT * 0;
                invoiceToView.TotalPrice = invoiceToView.Price;
            }
            return View(invoiceToView);
        }


        [Authorize(Roles = "admin, userVP, userSN,userTP, userAMG, userEN, userSP, userGK, userKK")]
        public IActionResult SalesReport(string year, string filter)
        {
            var invoices = _invoiceService.ShowInvoices().ToList();
            var clients = _clientService.ShowClients().GroupBy(x => x.Name).Select(x => x.First()).ToList();
            ClientInvoiceViewModel clientInvoiceModel = new ClientInvoiceViewModel();
            foreach (var i in invoices)
            {
                if (i.InvoiceServices.Any(s => s.Currency == CurrencyView.ЕУР && s.CurrencyRate == 1))
                {
                    i.VAT = i.VAT * 0;
                    i.TotalPrice = i.Price * 61.5000;

                }
                if (i.Client.Name.ToLower().Contains("arcelor") || i.Client.Name.ToLower().Contains("aрцелор") || i.Client.Name.ToLower().Contains("Liberty") || i.Client.Name.ToLower().Contains("либерти"))
                {
                    i.VAT = i.VAT * 0;
                    i.TotalPrice = i.Price;
                }

                clientInvoiceModel.Invoices.Add(i);
            }
            foreach (var c in clients)
            {
                clientInvoiceModel.Clients.Add(c);
            }
            if (String.IsNullOrEmpty(year))
            {
                ViewBag.CurrentFilter = DateTime.Now.Year.ToString();
            }
            else
            {
                ViewBag.CurrentFilter = year;
            }


            if (!String.IsNullOrEmpty(year))
            {
                clientInvoiceModel.Invoices = clientInvoiceModel.Invoices.Where(i => i.InvoiceDate.Year.ToString() == year).ToList();

            }


            return View(clientInvoiceModel);
        }


        [Authorize(Roles = "admin, userVP")]
        [HttpGet]
        public IActionResult UpdateQuantity(int serviceId)
        {

            UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
            var invoice = _invoiceService.GetCurrentInvoice();
            var serviceModel = invoice.InvoiceServices.LastOrDefault(x => x.ServiceId == serviceId);




            return View(serviceModel);


        }


        [Authorize(Roles = "admin, userVP")]
        [HttpPost]
        public IActionResult UpdateQuantity(ServiceViewModel serviceModel, double quantity)
        {
            var invoiceUpdate = _invoiceService.GetCurrentInvoice();

            var service = invoiceUpdate.InvoiceServices.LastOrDefault(x => x.ServiceId == serviceModel.ServiceId);

            _invoiceService.ChangeQuantity(invoiceUpdate.Id, service.ServiceId, quantity);
            return RedirectToAction("CurrentInvoice");
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult UpdateInvoice(int id)
        {
            var invoice = _invoiceService.ShowInvoices().Find(i => i.Id == id);
            if (invoice == null)
            {
                ErrorViewModel error = new ErrorViewModel
                {
                    RequestId = id.ToString()
                };
                return View("Error", error);
            }

            InvoiceViewModel invoiceModel = new InvoiceViewModel()
            {
                Id = invoice.Id,
                Client = invoice.Client,
                ClientAddress = invoice.Client.Address,
                ClientName = invoice.Client.Name,
                ClientInvoices = invoice.ClientInvoices,
                Clients = invoice.Clients,
                Description = invoice.Description,
                DueDate = invoice.DueDate,
                InvoiceDate = invoice.InvoiceDate,
                InvoiceServices = invoice.InvoiceServices,
                InvoiceNumber = invoice.InvoiceNumber,
                PaymentPeriod = invoice.PaymentPeriod,
                Price = invoice.Price,
                SelectedClient = invoice.SelectedClient,
                TotalPrice = invoice.TotalPrice,
                VAT = invoice.VAT
            };

            return View(invoiceModel);

        }
        [Authorize(Roles = "admin")]
        [HttpPost]
        public IActionResult UpdateInvoice(InvoiceViewModel invoiceModel)
        {

            var modifiedInvoice = _invoiceService.UpdateInvoice(invoiceModel);
            return RedirectToAction("Invoices");

        }
    }
}
