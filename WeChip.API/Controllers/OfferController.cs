using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeChip.API.Extensions;
using WeChip.Repository.Concrete;
using WeChip.Repository.Interface;
using WeChip.ViewModel.API;

namespace WeChip.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OfferController : Controller
    {
        private readonly IClientRepository _clientRepository;
        private readonly ResponseMessage<OfferApiModel> _responseMessage;
        public OfferController()
        {
            _clientRepository = new ClientRepository();
            _responseMessage = new ResponseMessage<OfferApiModel>();
        }

        /// <summary>
        /// Retorna as informações da oferta
        /// </summary>
        /// <param name="cpf">CPF do cliente</param>
        /// <returns></returns>
        [Route("{cpf}")]
        [HttpGet]
        public ResponseMessage<OfferApiModel> Get(string cpf)
        {
            try
            {
                var client = _clientRepository.Get(cpf);
                if (client == null)
                    throw new Exception($"Cliente com CPF {cpf} não existe na base");

                _responseMessage.Response = client.ToAPIOffer();
                return client.ToAPIOffer();
            }
            catch (Exception ex)
            {
                return new ResponseMessage<OfferApiModel>()
                {
                    ErrorMessage = ex.Message,
                    Response = null,
                    TimeStamp = DateTime.Now
                };
            }

        }
    }
}
