using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using WeChip.DomainModel.Enums;
using WeChip.DomainModel.Extensions;
using WeChip.DomainModel.Models;
using WeChip.Enums;
using WeChip.Helpers;
using WeChip.Model.ViewModels;
using WeChip.Repository.Concrete;
using WeChip.Repository.Interface;

namespace WeChip.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientRepository _clientRepository;
        private readonly IStatusRepository _statusRepository;
        private readonly IProductRepository _productRepository;

        /// <summary>
        /// Construtor responsável por iniciar todos os serviços que fazem acesso a base de dados.
        /// </summary>
        public ClientController()
        {
            _clientRepository = new ClientRepository();
            _statusRepository = new StatusRepository();
            _productRepository = new ProductRepository();
        }
        public IActionResult RegisterClient()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterClient(ClientRegisterViewModel clientRegister)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(clientRegister);
                }
                //Converte o objeto da ViewModel para a DomainModel
                var client = clientRegister.ToClient();

                //Retorna o objeto de Status 0001 - "Nome Livre"
                client.Status = _statusRepository.Get(StatusEnum.FreeName);

                //Insere o cliente na base de dados
                _clientRepository.Insert(client);
                var message = $"Cliente {clientRegister.Name} cadastrado com sucesso!";
                return RedirectToAction("Index", "Home", new { viewBagMessage = message, messageType = MessageTypeEnum.success });
            }
            catch (System.Exception ex)
            {
                var message = ex.Message;
                return RedirectToAction("Index", "Home", new { viewBagMessage = message, messageType = MessageTypeEnum.danger });
            }

        }
        public IActionResult OfferClient(string flowMessage = null, MessageTypeEnum messageType = MessageTypeEnum.none)
        {
            //Busca apenas os clientes disponiveis para a venda
            var clients = _clientRepository.GetAllAvailable();

            //Popula a lista de clientes que será exibida na tela
            var offer = new OfferViewModel()
            {
                Clients = clients != null ? clients.ToList() : null
            };

            //Caso seja um redirect de página, é armazenado uma mensagem.
            ViewBag.FlowMessage = flowMessage;
            ViewBag.MessageType = messageType;
            return View(offer);
        }
        public IActionResult LinkOfferClient(string clientCPF)
        {
            //Retorna todos os produtos disponíveis
            var products = _productRepository.GetAll();

            //Retorna o objeto que será utilizado na tela com toda a informação do cliente
            var linkOfferClient = _clientRepository.Get(clientCPF).ToLinkOfferView();

            //Preenche a lista de produtos que será exibida na tela
            if (products != null && products.Any())
                linkOfferClient.Products = products.ToList().ToProductList();

            //Preenche a lista de possiveis status que será exibida na tela
            ViewBag.StatusList = _statusRepository.GetAll().ToList().ToStatus();
            return View(linkOfferClient);
        }
        [HttpPost]
        public IActionResult LinkOfferClient(LinkOfferClientViewModel linkOfferClient)
        {
            try
            {
                //Validação se todos os campos foram preenchidos corretamente
                if (!ModelState.IsValid)
                    return View(linkOfferClient);

                //Retorna todos os códigos de produtos escolhidos
                var productCodes = linkOfferClient.Products
                                                    .Where(p => p.IsSelected)
                                                    .Select(p => int.Parse(p.ProductCode)).ToArray();

                //Retorna todos os produtos escolhidos
                var selectedProducts = _productRepository.GetAllSelected(productCodes);

                //Retorna a soma do preço de todos os produtos
                decimal productsPrice = selectedProducts.Sum(p => p.Price);

                //Retorna o objeto DomainModel do cliente
                var client = _clientRepository.Get(linkOfferClient.Client.CPF);

                //Armazena o cliente atual em um novo objeto
                var currentClient = new ClientModel()
                {
                    Name = client.Name,
                    CPF = client.CPF,
                    Credit = client.Credit,
                    DeliveryClientAddress = client.DeliveryClientAddress,
                    Phone = client.Phone,
                    Products = client.Products,
                    Status = client.Status
                };



                //Atualiza o seu status com o status escolhido na tela
                client.Status = _statusRepository.Get(linkOfferClient.StatusCode);

                //Associa o endereço na tela ao cliente
                client.DeliveryClientAddress = linkOfferClient.Address != null && !linkOfferClient.Address.IsAnyNullOrEmpty() ? linkOfferClient.Address.ToAddress() : null;

                //Associa os produtos selecionados ao cliente
                client.Products = selectedProducts;

                //Verificando se o cliente está tentando efetuar a compra
                if (client.TriedToBuy())
                {
                    //Faz as devidas validações de regra de negócio para confirmar se o cliente pode ou não efetuar a compra
                    if (client.CanBuy())
                    {
                        //Atualiza os créditos do cliente fazendo o cálculo da diferença com base no que foi comprado
                        client.Credit -= productsPrice;

                        //Atualiza o cliente na base
                        _clientRepository.Update(client);

                        return RedirectToAction("OfferClient", "Client", new { flowMessage = "Venda realizada com sucesso!", messageType = MessageTypeEnum.success });
                    }
                    //Caso ocorra algum erro retorna ao estado inicial
                    _clientRepository.Update(currentClient);

                    //Preenche os valores de StatusList novamente no objeto de dropdown da tela
                    ViewBag.StatusList = _statusRepository.GetAll().ToList().ToStatus();

                    ViewBag.ErrorMessage = client.ErrorMessage;
                    return View(linkOfferClient);
                }

                //Caso o cliente possua um status FinalizaCliente e possa recusar, o processo é finalizado
                else if (client.CanRefuse())
                {
                    _clientRepository.Update(client);
                    return RedirectToAction("OfferClient", "Client", new { flowMessage = $"Cliente {client.Name} encerrado com sucesso.", messageType = MessageTypeEnum.secondary });
                }

                //Verifica se o cliente apenas estava ausente
                else if (client.CanContinue())
                {
                    _clientRepository.Update(client);
                    return RedirectToAction("OfferClient", "Client", new { flowMessage = $"Cliente {client.Name} não estava disponível \n[Motivo: {client.Status.Description}]", messageType = MessageTypeEnum.info });
                }

                //Caso ocorra algum erro retorna ao estado inicial
                _clientRepository.Update(currentClient);

                //Preenche os valores de StatusList novamente no objeto de dropdown da tela
                ViewBag.StatusList = _statusRepository.GetAll().ToList().ToStatus();

                //Caso não consiga efetuar a compra, é exibido o motivo na tela para o cliente
                ViewBag.ErrorMessage = client.ErrorMessage;
                return View(linkOfferClient);
            }
            catch (System.Exception ex)
            {
                //Preenche os valores de StatusList novamente no objeto de dropdown da tela
                ViewBag.StatusList = _statusRepository.GetAll().ToList().ToStatus();
                ViewBag.ErrorMessage = ex.Message;
                return View(linkOfferClient);
            }

        }
    }
}
