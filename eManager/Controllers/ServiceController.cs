using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eManager.Domain;
using eManager.Services.Helpers;
using eManager.WebModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eManager.Controllers
{
   
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;
        private readonly IClientService _clientService;
       

        public ServiceController(IServiceService serviceService, IClientService clientService )
        {
            _serviceService = serviceService;
            _clientService = clientService;
        }

        [Authorize(Roles = "admin, userVP, userSN,userTP, userAMG, userEN, userSP, userGK, userKK,userDR")]
        public IActionResult Services()
        {

            var services = _serviceService.GetServices().GroupBy(x=>x.Name).Select(x=>x.First()).ToList();
            var clientsList = _clientService.ShowClients().Select(x => new SelectListItem
            {
                Value = x.Name,
                Text = x.Name,
                Selected = false

            });
            ViewBag.clientSelect = clientsList;


            foreach (var s in services)
            {
                var currentClient = _clientService.ShowClients().FirstOrDefault(c => c.ClientId == s.SelectedClientId);
                if (s.SelectedClientId == currentClient.ClientId)
                {
                    s.SelectedClient = currentClient.Name;
                    
                }

            }

            return View(services);
        }

        [Authorize(Roles = "admin, userVP, userSN,userTP, userAMG, userEN, userSP, userGK, userKK,userDR")]
        [HttpGet]
        public IActionResult NewService()
        {

            return View(new ServiceViewModel() { Clients = GetClientsList() });
        }

        [Authorize(Roles = "admin, userVP, userSN,userTP, userAMG, userEN, userSP, userGK, userKK,userDR")]
        [HttpPost]
        public IActionResult NewService(ServiceViewModel service)
        {
            service.Clients = GetClientsList();


            var selectedClientId = service.Clients.SingleOrDefault(x => x.Value == service.ServiceId.ToString());
            

            if (selectedClientId != null)
            {

                selectedClientId.Selected = true;
                ViewBag.Message = "Service for client: " + selectedClientId.Text;

            }

            ClientViewModel clientModel = _clientService.GetClient(service.SelectedClientId);

            service.Client = clientModel;
            service.SelectedClient = clientModel.Name;
            int addedService = _serviceService.AddService(service);
            return RedirectToAction("Services", "Service");

        }


        [Authorize(Roles = "admin, userVP, userSN,userTP, userAMG, userEN, userSP, userGK, userKK,userDR")]
        [HttpGet]
        public IActionResult RemoveService(int id)
        {
            var service = _serviceService.GetServices().SingleOrDefault(x => x.ServiceId == id);

            return View(service);
        }

        [Authorize(Roles = "admin, userVP, userSN,userTP, userAMG, userEN, userSP, userGK, userKK,userDR")]
        [HttpPost]
        public IActionResult RemoveService(ServiceViewModel viewModel)
        {
            _serviceService.RemoveService(viewModel.ServiceId);
            return RedirectToAction("Services", "Service");
        }



        [Authorize(Roles = "admin, userVP, userSN,userTP, userAMG, userEN, userSP, userGK, userKK,userDR")]
        public IEnumerable<SelectListItem> GetClientsList()
        {
            var clientsList = _clientService.ShowClients().Select(x => new SelectListItem
            {
                Value = x.ClientId.ToString(),
                Text = x.Name,
                Selected = false

            });
            return new SelectList(clientsList, "Value", "Text");
        }

        


    }
}