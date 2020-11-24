using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace EMS.Client
{
    public class GlobalVariable
    {
        public static HttpClient WebApiClient = new HttpClient();
        static GlobalVariable()
        {
            WebApiClient.BaseAddress = new Uri("http://localhost:49878/api/Employee/");
            WebApiClient.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
