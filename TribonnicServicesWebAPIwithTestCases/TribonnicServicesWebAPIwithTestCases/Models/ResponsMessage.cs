using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TribonnicServicesWebAPIwithTestCases.Models
{
    public class ResponsMessage
    {
        public int Result { get; set; }
        public string Message { get; set; }
        public List<int> Series { get; set; }
        public HttpStatusCode Status { get; set; } 
    }
}