using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{

   public class Constantes
    {
        //:::::::::::::::::::::::::::::
        //:::::::::::::::::::::::::::::
        //Error's
        public const int iCode_Error_Controller = 10001009;
        public const int iCode_Error_Modelo = 10001010;
        public const int iCode_Error_Logic = 10001011;
        public const int iCode_Error_Dato = 10001012;

        //:::::::::::::::::::::::::::::
        //:::::::::::::::::::::::::::::



        public const string USUARIO_SESION = "USUARIO_SESION";
        public const string SESSION_TNET = "SESSION_TNET";
        public static char CARACTER_SEPARADOR = '|'; // Caracter Separador de Filas
        public static char CARACTER_SEPARADOR_COLUMNAS = ';';
        public static char CARACTER_SEPARADOR_FILAS = ']';
        public static char CARACTER_SEPARADOR_FILAS2 = '[';
        public static string MENSAJE_CADENA_DEVUELTA_VACIA = "No se encontarón datos";
        public static string MENSAJE_TODOS = "Todos";
        public static string MENSAJE_NINGUNO = "Ninguno";
        public static string MENSAJE_SELECCIONE = "Seleccione";
        public static string CODIGO_NINGUNO = "-1";
        public static string CODIGO_TODOS = "-2";
        public static string CODIGO_SELECCIONE = "-3";
        public static string DATA_DETALLE_ORDEN = "DATA_DETALLE_ORDEN";
        public static string DATA_DETALLE_PREPOLIZA = "DATA_DETALLE_PREPOLIZA";
        public static string SIMULADOR_REPORTE = "SIMULADOR_REPORTE";

        public static string CARACTER_ASTERISCO = "*";

        public static string Activo = "A";
        public static bool GELIActivo = true;

        public static string TX_SI = "S";
        public static string TX_NO = "N";
    }

}
