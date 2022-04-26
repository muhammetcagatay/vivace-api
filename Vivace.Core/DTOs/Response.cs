using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Vivace.Core.DTOs
{
    public class Response<T>
    {
        public T Data { get; set; }
        public List<String> Errors { get; set; }
        [JsonIgnore]
        public HttpStatusCode StatusCode { get; set; }

        public static Response<T> Success(HttpStatusCode statusCode, T data)
        {
            return new Response<T> { Data = data, StatusCode = statusCode };
        }
        public static Response<T> Success(HttpStatusCode statusCode)
        {
            return new Response<T> { StatusCode = statusCode };
        }
        public static Response<T> Fail(List<String> errors, HttpStatusCode statusCode)
        {
            return new Response<T> { StatusCode = statusCode, Errors = errors };
        }
        public static Response<T> Fail(string error, HttpStatusCode statusCode)
        {
            return new Response<T> { StatusCode = statusCode, Errors = new List<string> { error } };
        }
    }
}
