using Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebAdmin.Models
{
    public class MovieDetailsClient : IMovieDetailsClient
    {
        private readonly HttpClient _httpClient;

        public MovieDetailsClient(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("http://www.omdbapi.com/");
            _httpClient = httpClient;
        } 

        public async Task<MovieDetailModel> GetMovieDetailsAsync(string movieName)
        {

            string sUrlWebApi = "http://localhost:8081/api/bolsa/";

            var response = await _httpClient.GetStringAsync(sUrlWebApi + "mGetCriterio");
            //string sJson = response.Content.ReadAsStringAsync().Result;
            string sJson = response;
            object data = JsonConvert.DeserializeObject<Model>(sJson);

            return new MovieDetailModel
            {
                Title = movieName
            };
        }



    }

}
