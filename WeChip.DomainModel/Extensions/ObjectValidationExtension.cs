using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace WeChip.DomainModel.Extensions
{
    public static class ObjectValidationExtension
    {
        /// <summary>
        /// Metodo de extensão que verifica a partir de Reflexão se existem campos nulos ou vazios em um objeto
        /// </summary>
        /// <param name="myObject"></param>
        /// <returns></returns>
        public static bool IsAnyNullOrEmpty(this object myObject)
        {
            foreach (PropertyInfo pi in myObject.GetType().GetProperties())
            {
                object value = pi.GetValue(myObject);
                if (value == null || value.Equals(0) || value.Equals(string.Empty))
                    return true;
            }
            return false;
        }
    }
}
