using Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface IConnectHttpClient
    { 
        Task<object> ConnectHttpClientAsync(string Url_WebApi, string sMetodo, string Parametros);
    }
}
