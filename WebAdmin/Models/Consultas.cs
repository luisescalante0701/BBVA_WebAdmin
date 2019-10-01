using Common;
using Entity;
using Logic;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WebAdmin.Models
{
    public class Consultas
    {
        public async Task<Model> mConsultaCliente(ConfigWeb ConfigWeb_, IConnectHttpClient IConnectHttpClient_)
        {
            return await new Logic.Logic_Consultas().mConsultaCliente(ConfigWeb_, IConnectHttpClient_);
            
        }


        }



    }
}
