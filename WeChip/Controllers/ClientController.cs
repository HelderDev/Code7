using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WeChip.Helpers;
using WeChip.Model.ViewModels;
using WeChip.Services.Concrete;
using WeChip.Services.Interface;

namespace WeChip.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;
        private readonly IStatusService _statusService;

        public ClientController()
        {
            _clientService = new ClientService();
            _statusService = new StatusService();
        }
        public IActionResult RegisterClient()
        {

            return View();
        }
        [HttpPost]
        public IActionResult RegisterClient(ClientRegisterViewModel clientRegister)
        {
            if (!ModelState.IsValid)
            {
                return View(clientRegister);
            }
            var client = clientRegister.ToClient();
            client.Status = _statusService.Get(0001);
            _clientService.Insert(client);
            var message = $"Cliente {clientRegister.Name} cadastrado com sucesso!";
            return RedirectToAction("Index", "Home", new { viewBagMessage = message });
        }
        public IActionResult OfferClient()
        {
            var clients = _clientService.GetAll();
            var offer = new OfferViewModel()
            {
                Clients = clients != null ? clients.ToList() : null
            };
            return View(offer);
        }
     }
}
