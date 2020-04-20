using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using eManager.Models;
using eManager.Services.Helpers;
using eManager.WebModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Storage.Blob;
using X.PagedList;
using X.PagedList.Mvc;


namespace eManager.Controllers
{
    [Authorize]
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly CloudBlobClient _cloudBlobClient;
        public ClientController(IClientService clientService, CloudBlobClient cloudBlobClient, IHostingEnvironment hostingEnvironment)
        {
            _clientService = clientService;
            _hostingEnvironment = hostingEnvironment;
            _cloudBlobClient = cloudBlobClient;

        }
        [Authorize(Roles = "admin, userVP, userSN,userTP, userAMG, userEN, userSP, userGK, userKK")]
        public IActionResult ShowClients(int? page)
        {
            var clients = _clientService.ShowClients().GroupBy(x => x.Name).Select(x => x.First()).ToList();

            int pageSize = 10;
            int pageNumber = (page ?? 1);
            ViewBag.invoiceList = clients.ToPagedList(pageNumber, pageSize);
            return View(clients.ToPagedList(pageNumber, pageSize));
            
        }

        [Authorize(Roles = "admin, userVP")]
        [HttpGet]
        public IActionResult RegisterNewClient()
        {
            return View(new ClientViewModel());
        }


        [Authorize(Roles = "admin, userVP")]
        [HttpPost]
        public ActionResult RegisterNewClient(ClientViewModel client, IFormFile LogoImage)
        {
            if(LogoImage != null)
            {
                string FileName = LogoImage.FileName;
                //var container = _cloudBlobClient.GetContainerReference("ognootporno");
                //var blob = container.GetBlockBlobReference(FileName);

                //blob.UploadFromStream(LogoImage.OpenReadStream());

                //var path = Path.Combine(_hostingEnvironment.WebRootPath, "UploadedFiles", LogoImage.FileName);
                //using (var stream = new FileStream(path, FileMode.Create))
                //{
                //    LogoImage.CopyToAsync(stream);
                //}

                var filename = ContentDispositionHeaderValue.Parse(LogoImage.ContentDisposition).FileName.Trim('"');
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "UploadedFiles", LogoImage.FileName);
                using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                {
                    LogoImage.CopyTo(stream);
                }
                client.LogoImage = LogoImage.FileName;
                
                ViewBag.Message = "Logo image for this client is successfully uploaded in database and client is registered!";
                var obj = _clientService.ShowClients().Where(x => x.LogoImage == client.LogoImage).FirstOrDefault();
                if (obj != null)
                {
                    client.LogoImage = obj.LogoImage;
                }
            }
            int registeredClient = _clientService.AddClient(client);
            return View();
           
        }

        [Authorize(Roles = "admin, userVP")]
        [HttpGet]
        public IActionResult UpdateClientInfo(int id)
        {

            var client = _clientService.ShowClients().Find(x => x.ClientId == id);
            if (client == null)
            {
                ErrorViewModel error = new ErrorViewModel
                {
                    RequestId = id.ToString()
                };
                return View("Error", error);
            }

            ClientViewModel clientToView = new ClientViewModel()
            {
                ClientId = client.ClientId,
                Name = client.Name,
                Address = client.Address,
                Phone = client.Phone,
                Description = client.Description,
                BankAccount = client.BankAccount,
                Email = client.Email,
                TaxNumber = client.TaxNumber,
                LogoImage = client.LogoImage

            };

            return View(clientToView);
        }

        [Authorize(Roles = "admin, userVP")]
        [HttpPost]
        public IActionResult UpdateClientInfo(ClientViewModel clientToView,IFormFile LogoImage)
        {
            if (LogoImage != null)
            {
                var path = Path.Combine(_hostingEnvironment.WebRootPath, "UploadedFiles", LogoImage.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    LogoImage.CopyToAsync(stream);
                }
                clientToView.LogoImage = LogoImage.FileName;
                
                ViewBag.Message = "Logo image for this client is successfully uploaded in database!";
                var obj = _clientService.ShowClients().Where(x => x.LogoImage == clientToView.LogoImage).FirstOrDefault();
                if (obj != null)
                {
                    clientToView.LogoImage = obj.LogoImage;
                }

            }
            int registeredClient = _clientService.UpdateClientInfo(clientToView);

            return RedirectToAction("ShowClients");


        }

        [Authorize(Roles = "admin, userVP")]
        [HttpGet]
        public IActionResult RemoveClient(int id)
        {
            var client = _clientService.ShowClients().SingleOrDefault(x => x.ClientId == id);

            return View(client);
        }

        [Authorize(Roles = "admin, userVP")]
        [HttpPost]
        public IActionResult RemoveClient(ClientViewModel viewModel)
        {

            _clientService.RemoveClient(viewModel.ClientId);
            return RedirectToAction("ShowClients", "Client");
        }

    }
}