using Common;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Logic_Consultas
    {
        int iCode_Error_Logic = Constantes.iCode_Error_Logic;//-- CODIGO ERROR GENERAL PARA IDENTIFICAR EL ERROR CAPA LOGICA

        string sTAG = "Logic_Consultas";


        string urlToPost = "";
        string resString = null;

        public async Task<Model> mGetConsultaCliente(ConfigWeb ConfigWeb_, IConnectHttpClient IConnectHttpClient_)
        {
            Model modeloRpta = new Model();

            try
            {
                string sUrlWebApi = ConfigWeb_.Url_WebApi;   
                string sMetodo = "api/bolsa/mConsultaCliente";

                object data = await IConnectHttpClient_.ConnectHttpClientAsync(sUrlWebApi, sMetodo, "");

                modeloRpta = (Model)data;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = this.iCode_Error_Logic;
                modeloRpta.sRpta = new Utility().mErrorParse(this.sTAG, ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            return modeloRpta;
        }

        public class DataConsultas

        {
            private static string connectionString = "";
            public static string SeleccionarCorreo(int intCodigoCorreo)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                   
                    SqlCommand cmd = new SqlCommand("dbo.SAB_Correo_Seleccionar", conn);

                   
                    cmd.CommandType = CommandType.StoredProcedure;

                   
                    cmd.Parameters.Add(new SqlParameter("@i_CodigoCorreo", intCodigoCorreo));

                    
                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            return rdr[0].ToString();
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }

            public static string ListarOrden(int iCodigoOpcion)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 1.  create a command object identifying the stored procedure
                    SqlCommand cmd = new SqlCommand("dbo.SAB_Orden_Listar", conn);

                    // 2. set the command object so it knows to execute a stored procedure
                    cmd.CommandType = CommandType.StoredProcedure;

                    // 3. add parameter to command, which will be passed to the stored procedure
                    cmd.Parameters.Add(new SqlParameter("@i_CodigoOpcion", iCodigoOpcion));

                    // execute the command
                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            return rdr[0].ToString();
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
    }
}