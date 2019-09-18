using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
  public  class ConfigWeb
    {
        public string Url_WebAdmin { get; set; }
        public string Url_WebApi { get; set; }
        public ConnectionStringsX ConnectionStrings_ { get; set; }
        public AppSettings AppSettings_ { get; set; }

    }
}
