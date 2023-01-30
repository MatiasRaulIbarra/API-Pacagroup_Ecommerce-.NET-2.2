using System;
using System.Collections.Generic;
using System.Text;

namespace Pacagroup.Ecommerce.Transversal.Common
{
    public class Response<T>
    {
        public T Data { get; set; }
        public bool IsSucces { get; set; }
        public string Message { get; set; }
    }
}
