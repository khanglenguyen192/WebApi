using System.Collections.Generic;
using System.Net;

namespace WebApi.Models
{
    public class ResponseMessage<T>
    {
        public IList<T> data { get; set; }

        public string message { get; set; }

        public HttpStatusCode statusCode { get; set; }
    }
}
