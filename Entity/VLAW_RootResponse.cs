using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{

    public class VLAW_DetalleResponse
    {

        public string fecha_opera
        {
            get { return m_fecha_opera; }
            set { m_fecha_opera = value; }
        }
        private string m_fecha_opera;

        public string fecha_valor
        {
            get { return m_fecha_valor; }
            set { m_fecha_valor = value; }
        }
        private string m_fecha_valor;

        public string concepto
        {
            get { return m_concepto; }
            set { m_concepto = value; }
        }
        private string m_concepto;

        public string cargo_abono
        {
            get { return m_cargo_abono; }
            set { m_cargo_abono = value; }
        }
        private string m_cargo_abono;

        public double importe
        {
            get { return m_importe; }
            set { m_importe = value; }
        }
        private double m_importe;

        public string concepto2
        {
            get { return m_concepto2; }
            set { m_concepto2 = value; }
        }
        private string m_concepto2;

        public int n_movimiento
        {
            get { return m_n_movimiento; }
            set { m_n_movimiento = value; }
        }
        private int m_n_movimiento;

        public double importe_itf
        {
            get { return m_importe_itf; }
            set { m_importe_itf = value; }
        }
        private double m_importe_itf;

    }


    public class VLAW_ListadoDetalle
    {
        public List<VLAW_DetalleResponse> detalle
        {
            get { return m_detalle; }
            set { m_detalle = value; }
        }
        private List<VLAW_DetalleResponse> m_detalle;
    }


    public class VLAW_IntegrationResponse
    {
        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;


        public VLAW_ListadoDetalle listadoDetalle
        {
            get { return m_listadoDetalle; }
            set { m_listadoDetalle = value; }
        }
        private VLAW_ListadoDetalle m_listadoDetalle;

        public double saldo_contable
        {
            get { return m_saldo_contable; }
            set { m_saldo_contable = value; }
        }
        private double m_saldo_contable;

        public double saldo_disponible
        {
            get { return m_saldo_disponible; }
            set { m_saldo_disponible = value; }
        }
        private double m_saldo_disponible;

        public string divisa
        {
            get { return m_divisa; }
            set { m_divisa = value; }
        }
        private string m_divisa;

        public string of_gestora
        {
            get { return m_of_gestora; }
            set { m_of_gestora = value; }
        }
        private string m_of_gestora;

        public string titularidad
        {
            get { return m_titularidad; }
            set { m_titularidad = value; }
        }
        private string m_titularidad;

        public string indicador_paginaci
        {
            get { return m_indicador_paginaci; }
            set { m_indicador_paginaci = value; }
        }
        private string m_indicador_paginaci;

        public string argumento_busqueda
        {
            get { return m_argumento_busqueda; }
            set { m_argumento_busqueda = value; }
        }
        private string m_argumento_busqueda;

        public string cod_retorno
        {
            get { return m_cod_retorno; }
            set { m_cod_retorno = value; }
        }
        private string m_cod_retorno;

        public string cod_error_dev
        {
            get { return m_cod_error_dev; }
            set { m_cod_error_dev = value; }
        }
        private string m_cod_error_dev;

        public string var1_error
        {
            get { return m_var1_error; }
            set { m_var1_error = value; }
        }
        private string m_var1_error;

        public string var2_error
        {
            get { return m_var2_error; }
            set { m_var2_error = value; }
        }
        private string m_var2_error;

    }


    public class VLAW_XMLNSCResponse
    {
        public VLAW_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLAW_IntegrationResponse m_integrationResponse;

    }


    public class VLAW_RootResponse
    {
        public VLAW_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLAW_XMLNSCResponse m_XMLNSC;

    }


}
