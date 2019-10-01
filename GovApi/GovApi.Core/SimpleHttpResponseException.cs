using System;
using System.Net;

namespace GovApi.Core
{
    public class SimpleHttpResponseException : Exception
    {
        public HttpStatusCode StatusCode { get; }

        public SimpleHttpResponseException(HttpStatusCode statusCode, string content) : base(content)
        {
            StatusCode = statusCode;
        }
    }
}
