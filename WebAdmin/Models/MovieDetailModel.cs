﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAdmin.Models
{
    public class MovieDetailModel
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public string IMDBRating { get; set; }
        public string PosterImage { get; set; }
        public string Plot { get; set; }
    }
}
