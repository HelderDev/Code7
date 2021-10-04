using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WeChip.DomainModel.Enums;
using WeChip.Helpers;
using WeChip.Model.ViewModels;
using WeChip.Repository.Concrete;
using WeChip.Repository.Interface;

namespace WeChip.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientRepository _clientService;
        private readonly IStatusRepository _statusService;
        private readonly IProductRepository _productService;

        /// <summary>
        /// Construtor responsável por iniciar todos os serviços que fazem acesso a base de dados.
        /// </summary>
        public ClientController()
        {
            _clientService = new ClientRepository();
            _statusService = new StatusRepository();
            _productService = new ProductRepository();
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
        public IActionResult LinkOfferClient(string clientCPF)
        {
            var products = _productService.GetAll();
            var linkOfferClient = _clientService.Get(clientCPF).ToLinkOfferView();
            if (products != null && products.Any())
                linkOfferClient.Products = products.ToList().ToProductList();

            return View(linkOfferClient);
        }
        [HttpPost]
        public IActionResult LinkOfferClient(LinkOfferClientViewModel linkOfferClient)
        {
            linkOfferClient.StatusCode = "0001";
            if (!ModelState.IsValid)
            {
                return View(linkOfferClient);
            }

            var productCodes = linkOfferClient.Products
                                                .Where(p => p.IsSelected)
                                                .Select(p => int.Parse(p.ProductCode)).ToArray();

            var selectedProducts = _productService.GetAllSelected(productCodes);
            decimal productsPrice = selectedProducts.Sum(p => p.Price);
            //bool hasHardware = selectedProducts
            //                    .Select(s => s.Type == TypeEnum.HARDWARE)
            //                    .FirstOrDefault();

            #region Regras de Venda
            //if (selectedProducts == null || !selectedProducts.Any())
            //{
            //    ViewBag.ErrorMessage = "É preciso selecionar ao menos 1 produto!";
            //    return View(linkOfferClient);
            //}

            //if (productsPrice > decimal.Parse(linkOfferClient.Client.Credit))
            //{
            //    ViewBag.ErrorMessage = "Cliente não possui Crédito suficiente!";
            //    return View(linkOfferClient);
            //}

            //if (hasHardware && (string.IsNullOrEmpty(linkOfferClient.Address.CEP)
            //    || string.IsNullOrEmpty(linkOfferClient.Address.City)
            //    || string.IsNullOrEmpty(linkOfferClient.Address.Complement)
            //    || string.IsNullOrEmpty(linkOfferClient.Address.Neighbourhood)
            //    || string.IsNullOrEmpty(linkOfferClient.Address.NumberAddress)
            //    || string.IsNullOrEmpty(linkOfferClient.Address.Street)
            //    || string.IsNullOrEmpty(linkOfferClient.Address.State)
            //    ))
            //{
            //    ViewBag.ErrorMessage = "Produto HARDWARE Selecionado! Obrigatório o preenchimento dos dados de endereço.";
            //    return View(linkOfferClient);
            //}
            #endregion

            var client = _clientService.Get(linkOfferClient.Client.CPF);
            client.DeliveryClientAddress = linkOfferClient.Address != null ? linkOfferClient.Address.ToAddress() : null;
            client.Products = selectedProducts;
            if (client.CanBuy()) {
                client.Status = _statusService.Get(0009);
                client.Credit -= productsPrice;
                _clientService.Update(client);
            }

           
            return View(linkOfferClient);
        }
    }
}
