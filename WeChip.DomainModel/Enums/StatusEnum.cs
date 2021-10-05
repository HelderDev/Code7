using System;
using System.Collections.Generic;
using System.Text;

namespace WeChip.DomainModel.Enums
{
   public enum StatusEnum
    {
        /// <summary>
        /// 0001 - Nome Livre
        /// </summary>
        FreeName = 1,

        /// <summary>
        /// 0007 - Não deseja ser contatado
        /// </summary>
        DoNotWishToBeContacted = 7,

        /// <summary>
        /// 0009 - Cliente aceitou a oferta
        /// </summary>
        ClientAcceptedTheOffer = 9,

        /// <summary>
        /// 0015 - Ligação caiu
        /// </summary>
        CallEnded = 15,

        /// <summary>
        /// 0019 - Viajou
        /// </summary>
        Traveled = 19,

        /// <summary>
        /// 0021 - Falecido :(
        /// </summary>
        Deceased = 21
    }
}
