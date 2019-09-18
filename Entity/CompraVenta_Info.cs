using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Entity
{
   public class CompraVenta_Info
    {
        public DataTable CuentasCliente { get; set; }
        public CompraVenta_DatosPersonales CompraVenta_DatosPersonales { get; set; }
        public DataTable CargarValores { get; set; }
    }
}
