using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace EMS.Client
{
    /// <summary>
    /// Glabal Variable to use Http Instance
    /// </summary>
    public class GlobalVariable
    {
        #region Static Variables

    
        // The web API client static Instance
        public static HttpClient WebApiClient = new HttpClient();
        
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes the <see cref="GlobalVariable"/> class.
        /// </summary>
        static GlobalVariable()
        {
            WebApiClient.BaseAddress = new Uri("http://localhost:49878/api/Employee/");
            WebApiClient.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));
        }
        
        #endregion
    }
}
