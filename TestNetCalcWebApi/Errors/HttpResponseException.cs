using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestNetCalcWebApi.Errors
{
    /**
    * HttpResponseException - класс отвечающий содержания HttpResponse
    */
    public class HttpResponseException : Exception
    {
        public int Status { get; set; }

        public object Value { get; set; }
    }
}
