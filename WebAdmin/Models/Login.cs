
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Common;
using Entity;
using Logic;

namespace WebAdmin.Models
{
    public class Login
    {

        public Model mLogin(ConfigWeb ConfigWeb_, string sUsuario, string sPassword)
        {
            return new Logic.Logic_Login().mLogin(ConfigWeb_, sUsuario, sPassword);
        }
        /*public Model mLogin(string sUsuario, string sPassword)
        {
            return new Logic.Logic_Login().mLogin(sUsuario, sPassword);
        }*/


    }
}
