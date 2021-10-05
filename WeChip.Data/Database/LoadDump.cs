using System;
using System.Collections.Generic;
using System.Text;
using WeChip.DomainModel.Models;
using WeChip.DomainModel.Enums;
namespace WeChip.Data.Database
{
    public static class LoadDump
    {
        public static IEnumerable<StatusModel> LoadStatus()
        {
            return new List<StatusModel>() {
            new StatusModel
            {
                StatusCode = StatusEnum.FreeName,
                AccountSale = false,
                TerminateClient = false,
                Description = "Nome Livre"
            },
             new StatusModel
            {
                StatusCode = StatusEnum.DoNotWishToBeContacted,
                AccountSale = false,
                TerminateClient = true,
                Description = "Não deseja ser contatado"
            },
              new StatusModel
            {
                StatusCode = StatusEnum.ClientAcceptedTheOffer,
                AccountSale = true,
                TerminateClient = true,
                Description = "Cliente Aceitou Oferta"
            },
               new StatusModel
            {
                StatusCode = StatusEnum.CallEnded,
                AccountSale = false,
                TerminateClient = false,
                Description = "Caiu a ligação"
            },
                new StatusModel
            {
                StatusCode = StatusEnum.Traveled,
                AccountSale = false,
                TerminateClient = false,
                Description = "Viajou"
            },
                 new StatusModel
            {
                StatusCode = StatusEnum.Deceased,
                AccountSale = false,
                TerminateClient = true,
                Description = "Falecido :("
            },
        };


        }

        public static IEnumerable<ProductModel> LoadProduct()
        {

            return new List<ProductModel>()
            {
                new ProductModel
                {
                    ProductCode = 00015,
                    Description = "Mouse",
                    Price = 20.00m,
                    Type = TypeEnum.HARDWARE
                },
                new ProductModel
                {
                    ProductCode = 00106,
                    Description = "Teclado",
                    Price = 30.00m,
                    Type = TypeEnum.HARDWARE
                },
                new ProductModel
                {
                    ProductCode = 00200,
                    Description = "Monitor 17’",
                    Price = 350.00m,
                    Type = TypeEnum.HARDWARE
                },
                new ProductModel
                {
                    ProductCode = 00211,
                    Description = "Pen Drive 8 GB",
                    Price = 30.00m,
                    Type = TypeEnum.HARDWARE
                },
                new ProductModel
                {
                    ProductCode = 00314,
                    Description = "Pen Drive 16 GB",
                    Price = 50.00m,
                    Type = TypeEnum.HARDWARE
                },
                new ProductModel
                {
                    ProductCode = 00459,
                    Description = "AVAST",
                    Price = 199.99m,
                    Type = TypeEnum.SOFTWARE
                },
                new ProductModel
                {
                    ProductCode = 01104,
                    Description = "Pacote Office",
                    Price = 499.00m,
                    Type = TypeEnum.SOFTWARE
                },
                new ProductModel
                {
                    ProductCode = 01108,
                    Description = "Spotify (3 meses)",
                    Price = 45.50m,
                    Type = TypeEnum.SOFTWARE
                },
                new ProductModel
                {
                    ProductCode = 01107,
                    Description = "Netflix (1 mês)",
                    Price = 19.90m,
                    Type = TypeEnum.SOFTWARE
                }
            };


        }
    }
}
