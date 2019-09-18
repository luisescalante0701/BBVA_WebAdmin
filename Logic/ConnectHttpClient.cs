using Common;
using Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
   public class ConnectHttpClient :IConnectHttpClient
    {

        private readonly HttpClient _httpClient;

        
        public ConnectHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<object> ConnectHttpClientAsync(string sUrl_WebApi, string sMetodo, string Parametros)
        {
            _httpClient.BaseAddress = new Uri(sUrl_WebApi);
         //  string sUrlWebApi = sUrl_WebApi;

            object data = null; 

            Model modeloRpta = new Model();
            try {
                var response = await _httpClient.GetStringAsync(sUrl_WebApi + sMetodo+ Parametros);
                //string sJson = response.Content.ReadAsStringAsync().Result;
                string sJson = response;
                data = JsonConvert.DeserializeObject<Model>(sJson);
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = 100999;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "ConnectHttpClientAsync", ex.StackTrace, ex.Message);
                modeloRpta.obj = null;

                data = modeloRpta;
            }
         
            return data;
        }




    }
}
