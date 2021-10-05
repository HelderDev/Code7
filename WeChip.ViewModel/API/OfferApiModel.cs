using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace WeChip.ViewModel.API
{
    /// <summary>
    /// Objeto representante da oferta
    /// </summary>
    public class OfferApiModel : ResponseMessage<OfferApiModel>
    {
        public Guid? OfferCode { get; set; }

        [JsonPropertyName("codStatus")]
        public short StatusCode { get; set; }

        [JsonPropertyName("idProdutos")]
        public int[] ProductIds { get; set; }

        [Required]
        public string CPF { get; set; }

    }
}
