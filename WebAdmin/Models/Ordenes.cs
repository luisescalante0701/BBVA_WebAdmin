using Common;
using Entity;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAdmin.Models
{
    public class Ordenes
    {
        public async Task<Model> mGetCriterio(ConfigWeb ConfigWeb_, IConnectHttpClient IConnectHttpClient_)
        {
            return await new Logic.Logic_Ordenes().mGetCriterio(ConfigWeb_, IConnectHttpClient_);
        }

        public async Task<Model> mGetTipoNegociacion(ConfigWeb ConfigWeb_, IConnectHttpClient IConnectHttpClient_, int iCodigoOpcion)
        {
            return await new Logic.Logic_Ordenes().mGetTipoNegociacion(ConfigWeb_, IConnectHttpClient_, iCodigoOpcion);
        }
        public async Task<Model> mGetTipoOrden(ConfigWeb ConfigWeb_, IConnectHttpClient IConnectHttpClient_, int iCodigoOpcion)
        {
            return await new Logic.Logic_Ordenes().mGetTipoOrden(ConfigWeb_, IConnectHttpClient_, iCodigoOpcion);
        }
        public async Task<Model> mGetOrden(ConfigWeb ConfigWeb_, IConnectHttpClient IConnectHttpClient_, int iCodigoOpcion)
        {
            return await new Logic.Logic_Ordenes().mGetOrden(ConfigWeb_, IConnectHttpClient_, iCodigoOpcion);
        }
        public async Task<Model> mGetTipoComision(ConfigWeb ConfigWeb_, IConnectHttpClient IConnectHttpClient_)
        {
            return await new Logic.Logic_Ordenes().mGetTipoComision(ConfigWeb_, IConnectHttpClient_);
        }


        public async Task<Model> mGetTipoPrecio(ConfigWeb ConfigWeb_, IConnectHttpClient IConnectHttpClient_)
        {
            return await new Logic.Logic_Ordenes().mGetTipoPrecio(ConfigWeb_, IConnectHttpClient_);
        }

        public async Task<Model> mGetMoneda(ConfigWeb ConfigWeb_, IConnectHttpClient IConnectHttpClient_)
        {
            return await new Logic.Logic_Ordenes().mGetMoneda(ConfigWeb_, IConnectHttpClient_);
        }



        public Model mSearchInfo(ConfigWeb ConfigWeb_,string sTypeSearch,string sValSearch, LoginUser modLoin)
        {
            return new Logic.Logic_Ordenes().mSearchInfo(ConfigWeb_, sTypeSearch, sValSearch,modLoin);
        }

        public Model mGuardarCompraVenta(ConfigWeb ConfigWeb_,
            string sTipoOrden, string sTipoNegociacion, string sNemonico, string sISN,
            string sNumeroTitulos, string sValorPrecio, string sDiasVigencia, string sMoneda,
            string sTipoCambio, string sOtra, string sCuentaAbono, bool bRetencion, bool bFirma,
            string sObservaciones, string sRepresentante, string sCuentaValor, string sOptionRadio,
            string sOrden, string sTipoComision, string sComision,
            LoginUser modLoin)
        {
            return new Logic.Logic_Ordenes().mGuardarCompraVenta(ConfigWeb_,
             sTipoOrden, sTipoNegociacion, sNemonico, sISN,
             sNumeroTitulos, sValorPrecio, sDiasVigencia, sMoneda,
             sTipoCambio, sOtra, sCuentaAbono, bRetencion, bFirma,
             sObservaciones, sRepresentante, sCuentaValor, sOptionRadio,
             sOrden, sTipoComision, sComision,
             modLoin);
        }


    }
}
