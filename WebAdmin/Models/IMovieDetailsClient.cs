using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAdmin.Models
{
    public interface IMovieDetailsClient
    {
        Task<MovieDetailModel> GetMovieDetailsAsync(string movieName); 
    }

}
