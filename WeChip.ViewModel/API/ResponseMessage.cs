using System;
using System.Collections.Generic;
using System.Text;

namespace WeChip.ViewModel.API
{
    /// <summary>
    /// Objeto genérico para o retorno de valores para API
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResponseMessage<T>
    {
        public string ErrorMessage { get; set; }
        public DateTime TimeStamp { get; set; }
        public T Response { get; set; }
    }
}
