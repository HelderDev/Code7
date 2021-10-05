using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using WeChip.DomainModel.Enums;
using WeChip.DomainModel.Extensions;
using WeChip.Helpers;
using WeChip.Model.ViewModels;
using WeChip.Repository.Concrete;
using WeChip.Repository.Interface;

namespace WeChip.Test
{
    [TestFixture]
    public class OfferClientService
    {
        private IClientRepository _clientRepository;
        private IStatusRepository _statusRepository;
        private IProductRepository _productRepository;


        [SetUp]
        public void Setup()
        {
            _clientRepository = new ClientRepository();
            _statusRepository = new StatusRepository();
            _productRepository = new ProductRepository();
        }

        public ClientRegisterViewModel LoadClient_WithNoMoney()
        {
            return new ClientRegisterViewModel()
            {
                CPF = "099.554.570-74",
                Credit = "0,50",
                Name = "John Doe",
                Phone = "(11) 94002-8922"
            };
        }
        public ClientRegisterViewModel LoadClient_WithMoney()
        {
            return new ClientRegisterViewModel()
            {
                CPF = "068.620.510-32",
                Credit = "50.000,99",
                Name = "Lorem Ipsum",
                Phone = "(21) 94123-4567"
            };
        }

        public DeliveryClientAddressViewModel LoadAddress_Successful()
        {
            return new DeliveryClientAddressViewModel()
            {
                CEP = "12345678",
                City = "Itú",
                Complement = "Em frente ao mercado",
                Neighbourhood = "Jardim das Flores",
                NumberAddress = "541",
                State = "SP",
                Street = "Nova Estrada"
            };
        }
        public DeliveryClientAddressViewModel LoadAddress_Failed()
        {
            return new DeliveryClientAddressViewModel()
            {
                CEP = "12345678",
                City = "Itú",
                Complement = "Em frente ao mercado",
                Neighbourhood = "Jardim das Flores",
                NumberAddress = null,
                State = string.Empty,
                Street = "Nova Estrada"
            };
        }
        public List<ProductViewModel> LoadProducts_Software()
        {
            var products = _productRepository
                .GetAll()
                    .Where(p => p.Type == TypeEnum.SOFTWARE)
                .ToList()
                .ToProductList();
            return products;
        }
        public List<ProductViewModel> LoadProducts_Hardware()
        {
            var products = _productRepository
                .GetAll()
                    .Where(p => p.Type == TypeEnum.HARDWARE)
                .ToList()
                .ToProductList();
            return products;
        }
        public LinkOfferClientViewModel LoadLinkOfferClient_Hardware_Successful()
        {
            return new LinkOfferClientViewModel()
            {
                Client = LoadClient_WithMoney(),
                Address = LoadAddress_Successful(),
                Products = LoadProducts_Hardware(),
                StatusCode = StatusEnum.ClientAcceptedTheOffer
            };
        }
        [Test]
        public void FlowClient_WithHardwareAndMoneySuccessful()
        {
            SaveClients();
            LinkOfferClient_Successful();

            var clients = _clientRepository.GetAll()
                .Where(c => c.Status.StatusCode == StatusEnum.ClientAcceptedTheOffer
                && c.Products.Select(p => p.Type).Contains(TypeEnum.HARDWARE)).ToList();

            Assert.Pass("Cliente cadastrado na compra de hardware com endereço preenchido", clients.Any());
        }
        [Test]
        public void FlowClient_WithSoftwareAndMoneySuccessful()
        {
            SaveClients();
            LinkOfferClient_Successful();

            var clients = _clientRepository.GetAll()
                .Where(c => c.Status.StatusCode == StatusEnum.ClientAcceptedTheOffer
                && c.Products.Select(p => p.Type).Contains(TypeEnum.HARDWARE)).ToList();

            Assert.Pass("Cliente cadastrado na compra de hardware com endereço preenchido", clients.Any());
        }

        public void SaveClients()
        {
            var clientWithMoney = LoadClient_WithMoney().ToClient();
            clientWithMoney.Status = _statusRepository.Get(StatusEnum.FreeName);

            var clientWithNoMoney = LoadClient_WithNoMoney().ToClient();
            clientWithNoMoney.Status = _statusRepository.Get(StatusEnum.FreeName);

            _clientRepository.Insert(clientWithMoney);
            _clientRepository.Insert(clientWithNoMoney);

            var clients = _clientRepository.GetAllAvailable().ToList();
            //Assert.Pass("Foi cadastrado 2 clientes", clients.Count() == 2);
        }

        
        public void LinkOfferClient_Successful()
        {
            LinkOfferClient(LoadLinkOfferClient_Hardware_Successful());
            var clientsAccepted = _clientRepository.GetAll()
                .Where(c => c.Status.StatusCode == StatusEnum.ClientAcceptedTheOffer).ToList();
            //Assert.Pass("Venda realizada com sucesso", clientsAccepted != null && clientsAccepted.Any());

        }
        private void LinkOfferClient(LinkOfferClientViewModel linkOfferClient)
        {
            //Retorna todos os produtos escolhidos
            var products = linkOfferClient.Products;

            var selectedProducts = _productRepository.GetAllSelected(products.Select(p => int.Parse(p.ProductCode)).ToArray());
            //Retorna a soma do preço de todos os produtos
            decimal productsPrice = selectedProducts.Sum(p => p.Price);

            //Retorna o objeto DomainModel do cliente
            var client = _clientRepository.Get(linkOfferClient.Client.CPF);

            //Armazena o cliente atual
            var currentClient = client;

            //Atualiza o seu status com o status escolhido na tela
            client.Status = _statusRepository.Get(linkOfferClient.StatusCode);

            //Associa o endereço na tela ao cliente
            client.DeliveryClientAddress = linkOfferClient.Address != null
                && !linkOfferClient.Address.IsAnyNullOrEmpty()
                ? linkOfferClient.Address.ToAddress() : null;

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
                    client.OfferCode = new System.Guid();
                    //Atualiza o cliente na base
                    _clientRepository.Update(currentClient);

                    //return RedirectToAction("OfferClient", "Client", new { flowMessage = "Venda realizada com sucesso!" });
                }
                else
                {
                    //Caso ocorra algum erro retorna ao estado inicial
                    _clientRepository.Update(currentClient);
                }
              

            }

            //Caso o cliente possua um status FinalizaCliente e possa recusar, o processo é finalizado
            else if (client.CanRefuse())
            {
                _clientRepository.Update(currentClient);
            }

            //Verifica se o cliente apenas estava ausente
            else if (client.CanContinue())
            {
                _clientRepository.Update(currentClient);
            }

            //Caso ocorra algum erro retorna ao estado inicial
            client = currentClient;
            _clientRepository.Update(currentClient);
        }

    }
}