using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{


    #region Detalles

    public class VLIF_DetalleAdicionalResponse
    {
        public string cod_ubigeo
        {
            get { return m_cod_ubigeo; }
            set { m_cod_ubigeo = value; }
        }
        private string m_cod_ubigeo;

        public string cod_cliente
        {
            get { return m_cod_cliente; }
            set { m_cod_cliente = value; }
        }
        private string m_cod_cliente;

        public string departamento
        {
            get { return m_departamento; }
            set { m_departamento = value; }
        }
        private string m_departamento;

        public string provincia
        {
            get { return m_provincia; }
            set { m_provincia = value; }
        }
        private string m_provincia;

        public string distrito
        {
            get { return m_distrito; }
            set { m_distrito = value; }
        }
        private string m_distrito;

        public string ofi_dev
        {
            get { return m_ofi_dev; }
            set { m_ofi_dev = value; }
        }
        private string m_ofi_dev;

        public string cod_moneda
        {
            get { return m_cod_moneda; }
            set { m_cod_moneda = value; }
        }
        private string m_cod_moneda;

        public string descripcion_moneda
        {
            get { return m_descripcion_moneda; }
            set { m_descripcion_moneda = value; }
        }
        private string m_descripcion_moneda;

        public string ind_impresion
        {
            get { return m_ind_impresion; }
            set { m_ind_impresion = value; }
        }
        private string m_ind_impresion;


    }


    public class VLIF_DetalleResCarteraResponse
    {
        public string monto_soles_var
        {
            get { return m_monto_soles_var; }
            set { m_monto_soles_var = value; }
        }
        private string m_monto_soles_var;

        public string porcentaje_soles_var
        {
            get { return m_porcentaje_soles_var; }
            set { m_porcentaje_soles_var = value; }
        }
        private string m_porcentaje_soles_var;

        public string monto_dolares_var
        {
            get { return m_monto_dolares_var; }
            set { m_monto_dolares_var = value; }
        }
        private string m_monto_dolares_var;

        public string porcentaje_dolares_var
        {
            get { return m_porcentaje_dolares_var; }
            set { m_porcentaje_dolares_var = value; }
        }
        private string m_porcentaje_dolares_var;

        public string monto_soles_fija
        {
            get { return m_monto_soles_fija; }
            set { m_monto_soles_fija = value; }
        }
        private string m_monto_soles_fija;

        public string porcentaje_soles_fija
        {
            get { return m_porcentaje_soles_fija; }
            set { m_porcentaje_soles_fija = value; }
        }
        private string m_porcentaje_soles_fija;

        public string monto_dolares_fija
        {
            get { return m_monto_dolares_fija; }
            set { m_monto_dolares_fija = value; }
        }
        private string m_monto_dolares_fija;

        public string porcentaje_dolares_fija
        {
            get { return m_porcentaje_dolares_fija; }
            set { m_porcentaje_dolares_fija = value; }
        }
        private string m_porcentaje_dolares_fija;
    }


    public class VLIF_DetalleRVSolesResponse
    {
        public string denominacion
        {
            get { return m_denominacion; }
            set { m_denominacion = value; }
        }
        private string m_denominacion;

        public string valor_posicion
        {
            get { return m_valor_posicion; }
            set { m_valor_posicion = value; }
        }
        private string m_valor_posicion;

        public string valor_disponible
        {
            get { return m_valor_disponible; }
            set { m_valor_disponible = value; }
        }
        private string m_valor_disponible;

        public string valor_no_disponible
        {
            get { return m_valor_no_disponible; }
            set { m_valor_no_disponible = value; }
        }
        private string m_valor_no_disponible;

        public string precio_promedio
        {
            get { return m_precio_promedio; }
            set { m_precio_promedio = value; }
        }
        private string m_precio_promedio;

        public string precio_mercado
        {
            get { return m_precio_mercado; }
            set { m_precio_mercado = value; }
        }
        private string m_precio_mercado;

        public string monto_invertido
        {
            get { return m_monto_invertido; }
            set { m_monto_invertido = value; }
        }
        private string m_monto_invertido;

        public string valor_mercado
        {
            get { return m_valor_mercado; }
            set { m_valor_mercado = value; }
        }
        private string m_valor_mercado;

        public string monto_perdida
        {
            get { return m_monto_perdida; }
            set { m_monto_perdida = value; }
        }
        private string m_monto_perdida;

    }

    /*
    public class VLIF_DetalleRVDolaresResponse
    {
        public string fecha_final_VL04
        {
            get
            { return m_fecha_final_VL0; }
            set
            { m_fecha_final_VL0 = value; }
        }
        private string m_fecha_final_VL0;
        public string cta_valor_VL04
        {
            get {return m_cta_valor_VL04; }
            set { m_cta_valor_VL04 = value; }
        }
        private string m_cta_valor_VL04;
        public string formato_VL04
        {
            get {return m_formato_VL04; }
            set { m_formato_VL04 = value; }
        }
        private string m_formato_VL04;
        public string tipo_renta_VL04
        {
            get { return m_tipo_renta_VL04; }
            set { m_tipo_renta_VL04 = value; }
        }
        private string m_tipo_renta_VL04;
        public string tipo_detalle_VL04
        {
            get { return m_tipo_detalle_VL04; }
            set { m_tipo_detalle_VL04 = value; }
        }
        private string m_tipo_detalle_VL04;
        public string denominacion
        {
            get { return m_denominacion; }
            set { m_denominacion = value; }
        }
        private string m_denominacion;
        public string valor_posicion
        {
            get { return m_valor_posicion; }
            set { m_valor_posicion = value; }
        }
        private string m_valor_posicion;
        public string valor_disponible
        {
            get { return m_valor_disponible; }
            set { m_valor_disponible = value; }
        }
        private string m_valor_disponible;
        public string valor_no_disponible
        {
            get { return m_valor_no_disponible; }
            set { m_valor_no_disponible = value; }
        }
        private string m_valor_no_disponible;
        public string precio_promedio
        {
            get { return m_precio_promedio; }
            set { m_precio_promedio = value; }
        }
        private string m_precio_promedio;
        public string precio_mercado
        {
            get { return m_precio_mercado; }
            set { m_precio_mercado = value; }
        }
        private string m_precio_mercado;
        public string monto_invertido
        {
            get { return m_monto_invertido; }
            set { m_monto_invertido = value; }
        }
        private string m_monto_invertido;
        public string valor_mercado
        {
            get { return m_valor_mercado; }
            set { m_valor_mercado = value; }
        }
        private string m_valor_mercado;
        public string monto_perdida
        {
            get { return m_monto_perdida; }
            set { m_monto_perdida = value; }
        }
        private string m_monto_perdida;
        public string total_invertido
        {
            get { return m_total_invertido; }
            set { m_total_invertido = value; }
        }
        private string m_total_invertido;
        public string total_mercado
        {
            get { return m_total_mercado; }
            set { m_total_mercado = value; }
        }
        private string m_total_mercado;
        public string total_benef_perdida
        {
            get { return m_total_benef_perdida; }
            set { m_total_benef_perdida = value; }
        }
        private string m_total_benef_perdida;
    }

    public class VLIF_DetalleRFSolesResponse
    {
        public string fecha_final_VL05
        {
            get { return m_fecha_final_VL05; }
            set { m_fecha_final_VL05 = value; }
        }
        private string m_fecha_final_VL05;
        public string cta_valor_VL05
        {
            get { return m_cta_valor_VL05; }
            set { m_cta_valor_VL05 = value; }
        }
        private string m_cta_valor_VL05;
        public string formato_VL05
        {
            get { return m_formato_VL05; }
            set { m_formato_VL05 = value; }
        }
        private string m_formato_VL05;
        public string tipo_renta_VL05
        {
            get { return m_tipo_renta_VL05; }
            set { m_tipo_renta_VL05 = value; }
        }
        private string m_tipo_renta_VL05;
        public string tipo_detalle_VL05
        {
            get { return m_tipo_detalle_VL05; }
            set { m_tipo_detalle_VL05 = value; }
        }
        private string m_tipo_detalle_VL05;
        public string denominacion
        {
            get { return m_denominacion; }
            set { m_denominacion = value; }
        }
        private string m_denominacion;
        public string valor_posicion
        {
            get { return m_valor_posicion; }
            set { m_valor_posicion = value; }
        }
        private string m_valor_posicion;
        public string valor_disponible
        {
            get { return m_valor_disponible; }
            set { m_valor_disponible = value; }
        }
        private string m_valor_disponible;
        public string valor_no_disponible
        {
            get { return m_valor_no_disponible; }
            set { m_valor_no_disponible = value; }
        }
        private string m_valor_no_disponible;
        public string valor_nominal
        {
            get { return m_valor_nominal; }
            set { m_valor_nominal = value; }
        }
        private string m_valor_nominal;
        public string precio
        {
            get { return m_precio; }
            set { m_precio = value; }
        }
        private string m_precio;
        public string fecha_venc
        {
            get { return m_fecha_venc; }
            set { m_fecha_venc = value; }
        }
        private string m_fecha_venc;
        public string monto_nominal
        {
            get { return m_monto_nominal; }
            set { m_monto_nominal = value; }
        }
        private string m_monto_nominal;
        public string tasa_cupon
        {
            get { return m_tasa_cupon; }
            set { m_tasa_cupon = value; }
        }
        private string m_tasa_cupon;
        public string total_monto
        {
            get { return m_total_monto; }
            set { m_total_monto = value; }
        }
        private string m_total_monto;
    }

    public class VLIF_DetalleRFDolaresResponse
    {
        public string fecha_final_VL06
        {
            get { return m_fecha_final_VL06; }
            set { m_fecha_final_VL06 = value; }
        }
        private string m_fecha_final_VL06;
        public string cta_valor_VL06
        {
            get { return m_cta_valor_VL06; }
            set { m_cta_valor_VL06 = value; }
        }
        private string m_cta_valor_VL06;
        public string formato_VL06
        {
            get { return m_formato_VL06; }
            set { m_formato_VL06 = value; }
        }
        private string m_formato_VL06;
        public string tipo_renta_VL06
        {
            get { return m_tipo_renta_VL06; }
            set { m_tipo_renta_VL06 = value; }
        }
        private string m_tipo_renta_VL06;
        public string tipo_detalle_VL06
        {
            get { return m_tipo_detalle_VL06; }
            set { m_tipo_detalle_VL06 = value; }
        }
        private string m_tipo_detalle_VL06;
        public string denominacion
        {
            get { return m_denominacion; }
            set { m_denominacion = value; }
        }
        private string m_denominacion;
        public string valor_posicion
        {
            get { return m_valor_posicion; }
            set { m_valor_posicion = value; }
        }
        private string m_valor_posicion;
        public string valor_disponible
        {
            get { return m_valor_disponible; }
            set { m_valor_disponible = value; }
        }
        private string m_valor_disponible;
        public string valor_no_disponible
        {
            get { return m_valor_no_disponible; }
            set { m_valor_no_disponible = value; }
        }
        private string m_valor_no_disponible;
        public string valor_nominal
        {
            get { return m_valor_nominal; }
            set { m_valor_nominal = value; }
        }
        private string m_valor_nominal;
        public string precio
        {
            get { return m_precio; }
            set { m_precio = value; }
        }
        private string m_precio;
        public string fecha_venc
        {
            get { return m_fecha_venc; }
            set { m_fecha_venc = value; }
        }
        private string m_fecha_venc;
        public string monto_nominal
        {
            get { return m_monto_nominal; }
            set { m_monto_nominal = value; }
        }
        private string m_monto_nominal;
        public string tasa_cupon
        {
            get { return m_tasa_cupon; }
            set { m_tasa_cupon = value; }
        }
        private string m_tasa_cupon;
        public string total_monto
        {
            get { return m_total_monto; }
            set { m_total_monto = value; }
        }
        private string m_total_monto;
    }

    public class VLIF_DetalleMovValorResponse
    {
        public string fecha_final_VL07
        {
            get { return m_fecha_final_VL07; }
            set { m_fecha_final_VL07 = value; }
        }
        private string m_fecha_final_VL07;
        public string cta_valor_VL07
        {
            get { return m_cta_valor_VL07; }
            set { m_cta_valor_VL07 = value; }
        }
        private string m_cta_valor_VL07;
        public string formato_VL07
        {
            get { return m_formato_VL07; }
            set { m_formato_VL07 = value; }
        }
        private string m_formato_VL07;
        public string tipo_renta_VL07
        {
            get { return m_tipo_renta_VL07; }
            set { m_tipo_renta_VL07 = value; }
        }
        private string m_tipo_renta_VL07;
        public string tipo_detalle_VL07
        {
            get { return m_tipo_detalle_VL07; }
            set { m_tipo_detalle_VL07 = value; }
        }
        private string m_tipo_detalle_VL07;
        public string fecha
        {
            get { return m_fecha; }
            set { m_fecha = value; }
        }
        private string m_fecha;
        public string fecha_liquidacion
        {
            get { return m_fecha_liquidacion; }
            set { m_fecha_liquidacion = value; }
        }
        private string m_fecha_liquidacion;
        public string tipo_operacion
        {
            get { return m_tipo_operacion; }
            set { m_tipo_operacion = value; }
        }
        private string m_tipo_operacion;
        public string glosa
        {
            get { return m_glosa; }
            set { m_glosa = value; }
        }
        private string m_glosa;
        public string num_poliza
        {
            get { return m_num_poliza; }
            set { m_num_poliza = value; }
        }
        private string m_num_poliza;
        public string valor
        {
            get { return m_valor; }
            set { m_valor = value; }
        }
        private string m_valor;
        public string moneda
        {
            get { return m_moneda; }
            set { m_moneda = value; }
        }
        private string m_moneda;
        public string cantidad
        {
            get { return m_cantidad; }
            set { m_cantidad = value; }
        }
        private string m_cantidad;
        public string precio
        {
            get { return m_precio; }
            set { m_precio = value; }
        }
        private string m_precio;
        public string total_neto
        {
            get { return m_total_neto; }
            set { m_total_neto = value; }
        }
        private string m_total_neto;
    }

    public class VLIF_DetalleMovEfectSolesResponse
    {
        public string fecha_final_VL08
        {
            get { return m_fecha_final_VL08; }
            set { m_fecha_final_VL08 = value; }
        }
        private string m_fecha_final_VL08;
        public string cta_valor_VL08
        {
            get { return m_cta_valor_VL08; }
            set { m_cta_valor_VL08 = value; }
        }
        private string m_cta_valor_VL08;
        public string formato_VL08
        {
            get { return m_formato_VL08; }
            set { m_formato_VL08 = value; }
        }
        private string m_formato_VL08;
        public string tipo_renta_VL08
        {
            get { return m_tipo_renta_VL08; }
            set { m_tipo_renta_VL08 = value; }
        }
        private string m_tipo_renta_VL08;
        public string tipo_detalle_VL08
        {
            get { return m_tipo_detalle_VL08; }
            set { m_tipo_detalle_VL08 = value; }
        }
        private string m_tipo_detalle_VL08;
        public string saldo_inicial
        {
            get { return m_saldo_inicial; }
            set { m_saldo_inicial = value; }
        }
        private string m_saldo_inicial;
        public string fecha
        {
            get { return m_fecha; }
            set { m_fecha = value; }
        }
        private string m_fecha;
        public string fecha_liquidacion
        {
            get { return m_fecha_liquidacion; }
            set { m_fecha_liquidacion = value; }
        }
        private string m_fecha_liquidacion;
        public string tipo
        {
            get { return m_tipo; }
            set { m_tipo = value; }
        }
        private string m_tipo;
        public string num_documento
        {
            get { return m_num_documento; }
            set { m_num_documento = value; }
        }
        private string m_num_documento;
        public string valor_nemonico
        {
            get { return m_valor_nemonico; }
            set { m_valor_nemonico = value; }
        }
        private string m_valor_nemonico;
        public string cod_moneda
        {
            get { return m_cod_moneda; }
            set { m_cod_moneda = value; }
        }
        private string m_cod_moneda;
        public string cantidad
        {
            get { return m_cantidad; }
            set { m_cantidad = value; }
        }
        private string m_cantidad;
        public string precio
        {
            get { return m_precio; }
            set { m_precio = value; }
        }
        private string m_precio;
        public string total_neto
        {
            get { return m_total_neto; }
            set { m_total_neto = value; }
        }
        private string m_total_neto;
        public string saldo
        {
            get { return m_saldo; }
            set { m_saldo = value; }
        }
        private string m_saldo;
        public string saldo_final
        {
            get { return m_saldo_final; }
            set { m_saldo_final = value; }
        }
        private string m_saldo_final;
    }

    public class VLIF_DetalleMovEfecDolaresResponse
    {
        public string cta_valor_VL09
        {
            get { return m_cta_valor_VL09; }
            set { m_cta_valor_VL09 = value; }
        }
        private string m_cta_valor_VL09;
        public string formato_VL09
        {
            get { return m_formato_VL09; }
            set { m_formato_VL09 = value; }
        }
        private string m_formato_VL09;
        public string tipo_renta_VL09
        {
            get { return m_tipo_renta_VL09; }
            set { m_tipo_renta_VL09 = value; }
        }
        private string m_tipo_renta_VL09;
        public string tipo_detalle_VL09
        {
            get { return m_tipo_detalle_VL09; }
            set { m_tipo_detalle_VL09 = value; }
        }
        private string m_tipo_detalle_VL09;
        public string saldo_inicial
        {
            get { return m_saldo_inicial; }
            set { m_saldo_inicial = value; }
        }
        private string m_saldo_inicial;
        public string fecha
        {
            get { return m_fecha; }
            set { m_fecha = value; }
        }
        private string m_fecha;
        public string fecha_liquidacion
        {
            get { return m_fecha_liquidacion; }
            set { m_fecha_liquidacion = value; }
        }
        private string m_fecha_liquidacion;
        public string tipo
        {
            get { return m_tipo; }
            set { m_tipo = value; }
        }
        private string m_tipo;
        public string num_documento
        {
            get { return m_num_documento; }
            set { m_num_documento = value; }
        }
        private string m_num_documento;
        public string valor_nemonico
        {
            get { return m_valor_nemonico; }
            set { m_valor_nemonico = value; }
        }
        private string m_valor_nemonico;
        public string cod_moneda
        {
            get { return m_cod_moneda; }
            set { m_cod_moneda = value; }
        }
        private string m_cod_moneda;
        public string cantidad
        {
            get { return m_cantidad; }
            set { m_cantidad = value; }
        }
        private string m_cantidad;
        public string precio
        {
            get { return m_precio; }
            set { m_precio = value; }
        }
        private string m_precio;
        public string total_neto
        {
            get { return m_total_neto; }
            set { m_total_neto = value; }
        }
        private string m_total_neto;
        public string saldo
        {
            get { return m_saldo; }
            set { m_saldo = value; }
        }
        private string m_saldo;
        public string saldo_final
        {
            get { return m_saldo_final; }
            set { m_saldo_final = value; }
        }
        private string m_saldo_final;
    }
    */

    #endregion


    #region Listados

    public class VLIF_ListadoDetalleAdicional
    {
        public List<VLIF_DetalleAdicionalResponse> adicionales
        {
            get { return m_adicionales; }
            set { m_adicionales = value; }
        }
        private List<VLIF_DetalleAdicionalResponse> m_adicionales;

        public string fecha_final_VL01
        {
            get { return m_fecha_final_VL01; }
            set { m_fecha_final_VL01 = value; }
        }
        private string m_fecha_final_VL01;

        public string cta_cargo_VL01
        {
            get { return m_cta_cargo_VL01; }
            set { m_cta_cargo_VL01 = value; }
        }
        private string m_cta_cargo_VL01;

        public string formato_VL01
        {
            get { return m_formato_VL01; }
            set { m_formato_VL01 = value; }
        }
        private string m_formato_VL01;

        public string tipo_renta_VL01
        {
            get { return m_tipo_renta_VL01; }
            set { m_tipo_renta_VL01 = value; }

        }
        private string m_tipo_renta_VL01;

        public string tipo_detalle_VL01
        {
            get { return m_tipo_detalle_VL01; }
            set { m_tipo_detalle_VL01 = value; }
        }
        private string m_tipo_detalle_VL01;

        public string pagina_VL01
        {
            get { return m_pagina_VL01; }
            set { m_pagina_VL01 = value; }

        }
        private string m_pagina_VL01;

        public string pagina_desde_VL01
        {
            get { return m_pagina_desde_VL01; }
            set { m_pagina_desde_VL01 = value; }
        }
        private string m_pagina_desde_VL01;

        public string periodo_desde_VL01
        {
            get { return m_periodo_desde_VL01; }
            set { m_periodo_desde_VL01 = value; }
        }
        private string m_periodo_desde_VL01;

        public string periodo_hasta_VL01
        {
            get { return m_periodo_hasta_VL01; }
            set { m_periodo_hasta_VL01 = value; }
        }
        private string m_periodo_hasta_VL01;

        public string nom_titular_VL01
        {
            get { return m_nom_titular_VL01; }
            set { m_nom_titular_VL01 = value; }
        }
        private string m_nom_titular_VL01;

        public string dir_titular_VL01
        {
            get { return m_dir_titular_VL01; }
            set { m_dir_titular_VL01 = value; }
        }
        private string m_dir_titular_VL01;

        public string cod_cavali_VL01
        {
            get { return m_cod_cavali_VL01; }
            set { m_cod_cavali_VL01 = value; }
        }
        private string m_cod_cavali_VL01;

        public string cta_valor_VL01
        {
            get { return m_cta_valor_VL01; }
            set { m_cta_valor_VL01 = value; }
        }
        private string m_cta_valor_VL01;

        public string tipo_cambio_VL01
        {
            get { return m_tipo_cambio_VL01; }
            set { m_tipo_cambio_VL01 = value; }
        }
        private string m_tipo_cambio_VL01;
    }


    public class VLIF_ListadoDetalleResumenCartera
    {
        public List<VLIF_DetalleResCarteraResponse> resumenCartera
        {
            get { return m_resumenCartera; }
            set { m_resumenCartera = value; }
        }
        private List<VLIF_DetalleResCarteraResponse> m_resumenCartera;

        public string fecha_final_VL02
        {
            get { return m_fecha_final_VL02; }
            set { m_fecha_final_VL02 = value; }
        }
        private string m_fecha_final_VL02;

        public string cta_cargo_VL02
        {
            get { return m_cta_cargo_VL02; }
            set { m_cta_cargo_VL02 = value; }
        }
        private string m_cta_cargo_VL02;

        public string formato_VL02
        {
            get { return m_formato_VL02; }
            set { m_formato_VL02 = value; }
        }
        private string m_formato_VL02;

        public string tipo_renta_VL02
        {
            get { return m_tipo_renta_VL02; }
            set { m_tipo_renta_VL02 = value; }
        }
        private string m_tipo_renta_VL02;

        public string tipo_detalle_VL02
        {
            get { return m_tipo_detalle_VL02; }
            set { m_tipo_detalle_VL02 = value; }
        }
        private string m_tipo_detalle_VL02;
    }


    public class VLIF_ListadoDetalleRvSoles
    {
        public List<VLIF_DetalleRVSolesResponse> rentaVariableSoles
        {
            get { return m_rentaVariableSoles; }
            set { m_rentaVariableSoles = value; }
        }
        private List<VLIF_DetalleRVSolesResponse> m_rentaVariableSoles;

        public string fecha_final_VL03
        {
            get { return m_fecha_final_VL03; }
            set { m_fecha_final_VL03 = value; }
        }
        private string m_fecha_final_VL03;

        public string cta_cargo_VL03
        {
            get { return m_cta_cargo_VL03; }
            set { m_cta_cargo_VL03 = value; }
        }
        private string m_cta_cargo_VL03;

        public string formato_VL03
        {
            get { return m_formato_VL03; }
            set { m_formato_VL03 = value; }
        }
        private string m_formato_VL03;

        public string tipo_renta_VL03
        {
            get { return m_tipo_renta_VL03; }
            set { m_tipo_renta_VL03 = value; }
        }
        private string m_tipo_renta_VL03;

        public string tipo_detalle_VL03
        {
            get { return m_tipo_detalle_VL03; }
            set { m_tipo_detalle_VL03 = value; }
        }
        private string m_tipo_detalle_VL03;

        public string total_invertido
        {
            get { return m_total_invertido; }
            set { m_total_invertido = value; }
        }
        private string m_total_invertido;

        public string total_mercado
        {
            get { return m_total_mercado; }
            set { m_total_mercado = value; }
        }
        private string m_total_mercado;

        public string total_benef_perdida
        {
            get { return m_total_benef_perdida; }
            set { m_total_benef_perdida = value; }
        }
        private string m_total_benef_perdida;
    }

    /*
    public class VLIF_ListadoDetalleRvDolares
    {
        public List<VLIF_DetalleRVDolaresResponse> rentaVariableDolares
        {
            get { return m_rentaVariableDolares; }
            set { m_rentaVariableDolares = value; }
        }
        private List<VLIF_DetalleRVDolaresResponse> m_rentaVariableDolares;
    }

    public class VLIF_ListadoDetalleRfSoles
    {
        public List<VLIF_DetalleRFSolesResponse> rentaFijaSoles
        {
            get { return m_rentaFijaSoles; }
            set { m_rentaFijaSoles = value; }
        }
        private List<VLIF_DetalleRFSolesResponse> m_rentaFijaSoles;
    }

    public class VLIF_ListadoDetalleRfDolares
    {
        public List<VLIF_DetalleRFDolaresResponse> rentaFijaDolares
        {
            get { return m_rentaFijaDolares; }
            set { m_rentaFijaDolares = value; }
        }
        private List<VLIF_DetalleRFDolaresResponse> m_rentaFijaDolares;
    }

    public class VLIF_ListadoDetalleMovimientoValores
    {
        public List<VLIF_DetalleMovValorResponse> movimientosValores
        {
            get { return m_movimientosValores; }
            set { m_movimientosValores = value; }
        }
        private List<VLIF_DetalleMovValorResponse> m_movimientosValores;
    }

    public class VLIF_ListadoDetalleMovEfectivoSoles
    {
        public List<VLIF_DetalleMovEfectSolesResponse> movimientosEfectivoSoles
        {
            get { return m_movimientosEfectivoSoles; }
            set { m_movimientosEfectivoSoles = value; }
        }
        private List<VLIF_DetalleMovEfectSolesResponse> m_movimientosEfectivoSoles;
    }

    public class VLIF_ListadoDetalleMovEfecDolares
    {
        public List<VLIF_DetalleMovEfecDolaresResponse> movimientosEfectivoDolares
        {
            get { return m_movimientosEfectivoDolares; }
            set { m_movimientosEfectivoDolares = value; }
        }
        private List<VLIF_DetalleMovEfecDolaresResponse> m_movimientosEfectivoDolares;
    }
    */
    #endregion


    #region IntegrationResponse

    public class VLIF_IntegrationResponse
    {
        public ResponseHeader responseHeader
        {
            get { return m_responseHeader; }
            set { m_responseHeader = value; }
        }
        private ResponseHeader m_responseHeader;

        public VLIF_ListadoDetalleAdicional listadoAdicionales
        {
            get { return m_listadoAdicionales; }
            set { m_listadoAdicionales = value; }
        }
        private VLIF_ListadoDetalleAdicional m_listadoAdicionales;

        public VLIF_ListadoDetalleResumenCartera listadoResCartera
        {
            get { return m_listadoResCartera; }
            set { m_listadoResCartera = value; }
        }
        private VLIF_ListadoDetalleResumenCartera m_listadoResCartera;

        public VLIF_ListadoDetalleRvSoles listadoRentaVaribleSoles
        {
            get { return m_listadoRentaVaribleSoles; }
            set { m_listadoRentaVaribleSoles = value; }
        }
        private VLIF_ListadoDetalleRvSoles m_listadoRentaVaribleSoles;

        /*

        public VLIF_ListadoDetalleRvDolares listadoRentaVarible
        {
            get { return m_listadoRentaVarible; }
            set { m_listadoRentaVarible = value; }
        }
        private VLIF_ListadoDetalleRvDolares m_listadoRentaVarible;

        public VLIF_ListadoDetalleRfSoles listadoRentaFijaSoles
        {
            get { return m_listadoRentaFijaSoles; }
            set { m_listadoRentaFijaSoles = value; }
        }
        private VLIF_ListadoDetalleRfSoles m_listadoRentaFijaSoles;

        public VLIF_ListadoDetalleRfDolares listadoRentaFijaDolares
        {
            get { return m_listadoRentaFijaDolares; }
            set { m_listadoRentaFijaDolares = value; }
        }
        private VLIF_ListadoDetalleRfDolares m_listadoRentaFijaDolares;

        public VLIF_ListadoDetalleMovimientoValores listadoDetMovValores
        {
            get { return m_listadoDetMovValores; }
            set { m_listadoDetMovValores = value; }
        }
        private VLIF_ListadoDetalleMovimientoValores m_listadoDetMovValores;

        public VLIF_ListadoDetalleMovEfectivoSoles listadoDetMovEfectivoSol
        {
            get { return m_listadoDetMovEfectivoSol; }
            set { m_listadoDetMovEfectivoSol = value; }
        }
        private VLIF_ListadoDetalleMovEfectivoSoles m_listadoDetMovEfectivoSol;

        public VLIF_ListadoDetalleMovEfecDolares listadoDetMovEfectivoDol
        {
            get { return m_listadoDetMovEfectivoDol; }
            set { m_listadoDetMovEfectivoDol = value; }
        }
        private VLIF_ListadoDetalleMovEfecDolares m_listadoDetMovEfectivoDol;
        */
    }

    #endregion

    public class VLIF_XMLNSCResponse
    {
        public VLIF_IntegrationResponse integrationResponse
        {
            get { return m_integrationResponse; }
            set { m_integrationResponse = value; }
        }
        private VLIF_IntegrationResponse m_integrationResponse;
    }

    public class VLIF_RootResponse
    {
        public VLIF_XMLNSCResponse XMLNSC
        {
            get { return m_XMLNSC; }
            set { m_XMLNSC = value; }
        }
        private VLIF_XMLNSCResponse m_XMLNSC;

    }


}
