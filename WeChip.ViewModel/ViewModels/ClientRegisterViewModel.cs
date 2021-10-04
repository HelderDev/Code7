using System.ComponentModel.DataAnnotations;
using WeChip.Model.Helper;

namespace WeChip.Model.ViewModels
{
    public class ClientRegisterViewModel
    {
        [Required(ErrorMessage = "Nome obrigatório")]
        [StringLength(1000)]
        public string Name { get; set; } 
        [Required(ErrorMessage = "CPF obrigatório")]
        [CPFValidationHelper(ErrorMessage = "CPF inválido")]
        public string CPF { get; set; }
        [DataType(DataType.Currency)]
        public string Credit { get; set; } = "0";
        [Required(ErrorMessage = "Telefone obrigatório")]
        public string Phone { get; set; }
    }
}
