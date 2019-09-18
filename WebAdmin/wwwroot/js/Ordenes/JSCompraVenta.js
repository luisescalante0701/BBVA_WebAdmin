
$body = $("body");

var Table_tbCab_CuentaValor = null;
var Table_tbCab_CargarValores = null;


$(document).ready(function () {
    debugger;

   // $('#tbCab_CuentaValor').DataTable();
    //$('#tbCab_CargarValores').DataTable();
    

    Table_tbCab_CuentaValor = $('#tbCab_CuentaValor').DataTable({
        columns: [
            { data: 'CtaValor' },
            { data: "Rut" },
            { data: "CuentaEconomicaCargo" },
            { data: "CuentaEconomicaAbono" },
            { data: "ComisionRueda" },
            { data: "Mancomunado" }
        ]
    });
    Table_tbCab_CargarValores = $('#tbCab_CargarValores').DataTable({
        columns: [
            { data: 'CuentaValor' },
            { data: "SaldoContable" },
            { data: "SaldoDisponible" },
            { data: "Nemonico" },
            { data: "Moneda" },
            { data: "PrecioPromedio" },
            { data: "PrecioActual" },
            { data: "ValorizacionActual" },
            { data: "Utilidad" },
            { data: "Custodio" }
        ]
    });


    mGetCriterio();
    mGetTipoNegociacion(6);
    mGetTipoOrden(6);
    mGetOrden(6);
    mGetTipoComision();
    mGetTipoPrecio();
    //mGetMoneda();

   // $("#cmbTipoPrecio").val("M");

    $('#tbCab_CuentaValor #tbDet_CuentaValor').on('click', 'tr', function () {
        debugger;
        var sNemonico = this.cells[0].innerHTML;

        if ($(this).hasClass('selected')) {
            $(this).removeClass('selected');
        }
        else {
            Table_tbCab_CuentaValor.$('tr.selected').removeClass('selected');
            $(this).addClass('selected');
        }

        if (sNemonico == "No data available in table") {
           
            return;
        }

        $("#divDatoNegociacion").css("display", "block");

    });

    $('#tbCab_CargarValores #tbDet_CargarValores').on('click', 'tr', function () {
        debugger;
        var sNemonico = this.cells[3].innerHTML;

        $("#txtNemonico").val(sNemonico);

        if ($(this).hasClass('selected')) {
            $(this).removeClass('selected');
        }
        else {
            Table_tbCab_CargarValores.$('tr.selected').removeClass('selected');
            $(this).addClass('selected');
        }

    });

    $("#btnSearch").click(function () {
        debugger;

        var e = document.getElementById("cmbCriterio");

        if (e.selectedIndex <= 0) {
            mAlertMsg("Seleccione un Criterio a evaluar.", 1); return;
        }

        var scmbCriterio = e.options[e.selectedIndex].value;

        var stxtSearch = $("#txtSearch").val();

        if (scmbCriterio == "A") {
            if (stxtSearch.trim().length > 80) {
                mAlertMsg("La longitud máxima del valor de busqueda debe ser 80 caracteres.", 1); return;
            }
        }
        else {
            if (stxtSearch.trim().length > 20) {
                mAlertMsg("La longitud máxima del valor de busqueda debe ser 20 caracteres!", 1); return;
            }
        }
      
        mSearchInfo(scmbCriterio, stxtSearch);
    });


    $("#btnGuardar").click(function () {
        debugger;
        
        var brpta = mValidarPreGuardar();

        if (brpta) { }

        //    mGuardar(scmbCriterio, stxtSearch);

    });


});


function mValidarPreGuardar() {

    var sRpta = "";
    var bRpta = true;

    var sCuentaValor = "";
    var sNemonico = $("#txtNemonico").val();
    var sISN = $("#txtISN").val();
    var sDiasVigencia = $("#txtDiasVigencia").val();
    var sComision = $("#txtComision").val();
    var sCuenta = $("#txtCuenta").val();
    

    if (sNemonico.trim() == "" && sISN.trim() == "") {
        sRpta = "Por favor, ingrese el Nemónico o ISIN.";
        bRpta = false;
    }


    var e = document.getElementById("cmbTipoNegociacion");
    if (e.selectedIndex == 0) {
        sRpta = "Por favor, seleccione el Tipo de negociación.";
        bRpta = false;
    }

    e = document.getElementById("cmbTipoOrden");
    if (e.selectedIndex == 0) {
        sRpta = "Por favor, ingrese el Tipo de orden.";
        bRpta = false;
    }

    e = document.getElementById("cmbOrden");
    if (e.selectedIndex == 0) {
        sRpta = "Por favor, ingrese la 'Orden' de ingreso.";

        bRpta = false;
    }

    if (sDiasVigencia.trim() == "") {
        sRpta = "Por favor, ingrese los días de vigencia.";
        bRpta = false;
    }

    e = document.getElementById("cmbTipoComision");
    if (e.selectedIndex == 0) {
        sRpta = "Por favor, seleccione el Tipo de comisión.";
        bRpta = false;
    }

    if (sComision.trim() == "") {
        sRpta = "Por favor, ingrese el valor de Comisión.";
        bRpta = false;
    }





    e = document.getElementById("cmbCuentaAbonoCargo");
    if (e.selectedIndex == 0) {

        e = document.getElementById("cmbOtra");
        if (e.selectedIndex == 0) {
            sRpta = "Por favor, seleccione Cuenta abono/cargo.";
            bRpta = false;
        }

        var scmbOtra = e.options[e.selectedIndex].value;

        if (scmbOtra == "B") {

            if (sCuenta.trim() == "") {
                sRpta =  "Por favor, la Cuenta bancaria ingresada debe tener 20 dígitos.";
                bRpta = false;
            }
            if (sCuenta.trim().length != 20) {              
                sRpta = "Por favor, la Cuenta bancaria ingresada debe tener 20 dígitos.";
                bRpta = false;
            }
        }

        bRpta = false;

    }


    var radioValue = $("input[name='optradio']:checked").val();
    if (radioValue) {
        sRpta = "Seleccionar el medio de comunicación";
        bRpta = false;
    }


    if (bRpta == false)
    mAlertMsg(sRpta, 1);

    return bRpta;
}


function mGetCriterio() {
    debugger;

    $("#cmbCriterio").html("");//reset data combobox


    $.ajax(
        {
            type: "POST", //HTTP POST Method
           // timeout: 5000,
            url: Url_WebAdmin + "Ordenes/mGetCriterio", // Controller/View
            data: { //Passing data

            },
            dataType: 'json',
            beforeSend: function () {
                $body.addClass("loading");
            },
            complete: function (data) {
                $body.removeClass("loading");
            },
            success: function (data) {

                var ObjRep = JSON.parse(data);

                if (ObjRep == null || ObjRep == undefined) {
                    mAlertMsg("La conversion de Datos no ha sido la correcta!", 2);
                    return;
                }

                if (ObjRep.bEstado) {

                    //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                    var TableDataTable = ObjRep.obj;

                    if (TableDataTable == null) {
                        mAlertMsg("No se encuentran datos!", 1); return;
                    }

                        var iTableDataTableCount = ObjRep.obj.length;

                        if (iTableDataTableCount > 0) {

                            cmbControl("cmbCriterio", "-1", "-seleccione-");
                            for (var i in TableDataTable) {

                                var Codigo = TableDataTable[i].Codigo;
                                var Nombre = TableDataTable[i].Nombre;

                                cmbControl("cmbCriterio", Codigo, Nombre);
                            }
                        }
                        else {
                            mAlertMsg("No se encuentran datos!", 1);
                        }
                    //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                }
                else {

                    var sError = ObjRep.sRpta;
                    var iCodigo = ObjRep.iCodigo;

                    mAlertMsg("Error. detail:" + sError, 1);
                }
            }
            , error: function (xhr, textStatus, errorThrown) {
                mAlertMsg('Error xhr.status: ' + xhr.status, 2);
            }

        });

}

function mGetTipoNegociacion(iCodigoOpcion) {
    debugger;

    $("#cmbTipoNegociacion").html("");//reset data combobox


    $.ajax(
        {
            type: "POST", //HTTP POST Method
            // timeout: 5000,
            url: Url_WebAdmin + "Ordenes/mGetTipoNegociacion", // Controller/View
            data: { //Passing data
                iCodigoOpcion: iCodigoOpcion
            },
            dataType: 'json',
            beforeSend: function () {
                $body.addClass("loading");
            },
            complete: function (data) {
                $body.removeClass("loading");
            },
            success: function (data) {

                var ObjRep = JSON.parse(data);

                if (ObjRep == null || ObjRep == undefined) {
                    mAlertMsg("La conversion de Datos no ha sido la correcta!", 2);
                    return;
                }

                if (ObjRep.bEstado) {

                    //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                    var TableDataTable = ObjRep.obj;

                    if (TableDataTable == null) {
                        mAlertMsg("No se encuentran datos!", 1); return;
                    }

                    var iTableDataTableCount = ObjRep.obj.length;

                    if (iTableDataTableCount > 0) {

                        cmbControl("cmbTipoNegociacion", "-1", "-seleccione-");
                        for (var i in TableDataTable) {

                            var Codigo = TableDataTable[i].Codigo;
                            var Nombre = TableDataTable[i].Nombre;

                            cmbControl("cmbTipoNegociacion", Codigo, Nombre);
                        }

                        $("#cmbTipoNegociacion").val("R");
                    }
                    else {
                        mAlertMsg("No se encuentran datos!", 1);
                    }
                    //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                }
                else {

                    var sError = ObjRep.sRpta;
                    var iCodigo = ObjRep.iCodigo;

                    mAlertMsg("Error. detail:" + sError, 1);
                }
            }
            , error: function (xhr, textStatus, errorThrown) {
                mAlertMsg('Error xhr.status: ' + xhr.status, 2);
            }

        });

}

function mGetTipoOrden(iCodigoOpcion) {
    debugger;

    $("#cmbTipoOrden").html("");//reset data combobox


    $.ajax(
        {
            type: "POST", //HTTP POST Method
            // timeout: 5000,
            url: Url_WebAdmin + "Ordenes/mGetTipoOrden", // Controller/View
            data: { //Passing data
                iCodigoOpcion: iCodigoOpcion
            },
            dataType: 'json',
            beforeSend: function () {
                $body.addClass("loading");
            },
            complete: function (data) {
                $body.removeClass("loading");
            },
            success: function (data) {

                var ObjRep = JSON.parse(data);

                if (ObjRep == null || ObjRep == undefined) {
                    mAlertMsg("La conversion de Datos no ha sido la correcta!", 2);
                    return;
                }

                if (ObjRep.bEstado) {

                    //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                    var TableDataTable = ObjRep.obj;

                    if (TableDataTable == null) {
                        mAlertMsg("No se encuentran datos!", 1); return;
                    }

                    var iTableDataTableCount = ObjRep.obj.length;

                    if (iTableDataTableCount > 0) {

                        cmbControl("cmbTipoOrden", "-1", "-seleccione-");
                        for (var i in TableDataTable) {

                            var Codigo = TableDataTable[i].Codigo;
                            var Nombre = TableDataTable[i].Nombre;

                            cmbControl("cmbTipoOrden", Codigo, Nombre);
                        }

                        $("#cmbTipoOrden").val("E");
                    }
                    else {
                        mAlertMsg("No se encuentran datos!", 1);
                    }
                    //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                }
                else {

                    var sError = ObjRep.sRpta;
                    var iCodigo = ObjRep.iCodigo;

                    mAlertMsg("Error. detail:" + sError, 1);
                }
            }
            , error: function (xhr, textStatus, errorThrown) {
                mAlertMsg('Error xhr.status: ' + xhr.status, 2);
            }

        });

}

function mGetOrden(iCodigoOpcion) {
    debugger;

    $("#cmbOrden").html("");//reset data combobox


    $.ajax(
        {
            type: "POST", //HTTP POST Method
            // timeout: 5000,
            url: Url_WebAdmin + "Ordenes/mGetOrden", // Controller/View
            data: { //Passing data
                iCodigoOpcion: iCodigoOpcion
            },
            dataType: 'json',
            beforeSend: function () {
                $body.addClass("loading");
            },
            complete: function (data) {
                $body.removeClass("loading");
            },
            success: function (data) {

                var ObjRep = JSON.parse(data);

                if (ObjRep == null || ObjRep == undefined) {
                    mAlertMsg("La conversion de Datos no ha sido la correcta!", 2);
                    return;
                }

                if (ObjRep.bEstado) {

                    //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                    var TableDataTable = ObjRep.obj;

                    if (TableDataTable == null) {
                        mAlertMsg("No se encuentran datos!", 1); return;
                    }

                    var iTableDataTableCount = ObjRep.obj.length;

                    if (iTableDataTableCount > 0) {

                        cmbControl("cmbOrden", "-1", "-seleccione-");
                        for (var i in TableDataTable) {

                            var Codigo = TableDataTable[i].Codigo;
                            var Nombre = TableDataTable[i].Nombre;

                            cmbControl("cmbOrden", Codigo, Nombre);
                        }
                    }
                    else {
                        mAlertMsg("No se encuentran datos!", 1);
                    }
                    //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                }
                else {

                    var sError = ObjRep.sRpta;
                    var iCodigo = ObjRep.iCodigo;

                    mAlertMsg("Error. detail:" + sError, 1);
                }
            }
            , error: function (xhr, textStatus, errorThrown) {
                mAlertMsg('Error xhr.status: ' + xhr.status, 2);
            }

        });

}

function mGetTipoComision() {
    debugger;

    $("#cmbTipoComision").html("");//reset data combobox


    $.ajax(
        {
            type: "POST", //HTTP POST Method
            // timeout: 5000,
            url: Url_WebAdmin + "Ordenes/mGetTipoComision", // Controller/View
            data: { //Passing data

            },
            dataType: 'json',
            beforeSend: function () {
                $body.addClass("loading");
            },
            complete: function (data) {
                $body.removeClass("loading");
            },
            success: function (data) {

                var ObjRep = JSON.parse(data);

                if (ObjRep == null || ObjRep == undefined) {
                    mAlertMsg("La conversion de Datos no ha sido la correcta!", 2);
                    return;
                }

                if (ObjRep.bEstado) {

                    //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                    var TableDataTable = ObjRep.obj;

                    if (TableDataTable == null) {
                        mAlertMsg("No se encuentran datos!", 1); return;
                    }

                    var iTableDataTableCount = ObjRep.obj.length;

                    if (iTableDataTableCount > 0) {

                        cmbControl("cmbTipoComision", "-1", "-seleccione-");
                        for (var i in TableDataTable) {

                            var Codigo = TableDataTable[i].Codigo;
                            var Nombre = TableDataTable[i].Nombre;

                            cmbControl("cmbTipoComision", Codigo, Nombre);
                        }
                    }
                    else {
                        mAlertMsg("No se encuentran datos!", 1);
                    }
                    //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                }
                else {

                    var sError = ObjRep.sRpta;
                    var iCodigo = ObjRep.iCodigo;

                    mAlertMsg("Error. detail:" + sError, 1);
                }
            }
            , error: function (xhr, textStatus, errorThrown) {
                mAlertMsg('Error xhr.status: ' + xhr.status, 2);
            }

        });

}

function mGetTipoPrecio() {
    debugger;

    $("#cmbTipoPrecio").html("");//reset data combobox


    $.ajax(
        {
            type: "POST", //HTTP POST Method
            // timeout: 5000,
            url: Url_WebAdmin + "Ordenes/mGetTipoPrecio", // Controller/View
            data: { //Passing data

            },
            dataType: 'json',
            beforeSend: function () {
                $body.addClass("loading");
            },
            complete: function (data) {
                $body.removeClass("loading");
            },
            success: function (data) {

                var ObjRep = JSON.parse(data);

                if (ObjRep == null || ObjRep == undefined) {
                    mAlertMsg("La conversion de Datos no ha sido la correcta!", 2);
                    return;
                }

                if (ObjRep.bEstado) {

                    //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                    var TableDataTable = ObjRep.obj;

                    if (TableDataTable == null) {
                        mAlertMsg("No se encuentran datos!", 1); return;
                    }

                    var iTableDataTableCount = ObjRep.obj.length;

                    if (iTableDataTableCount > 0) {

                        cmbControl("cmbTipoPrecio", "-1", "-seleccione-");
                        for (var i in TableDataTable) {

                            var Codigo = TableDataTable[i].Codigo;
                            var Nombre = TableDataTable[i].Nombre;

                            cmbControl("cmbTipoPrecio", Codigo, Nombre);
                        }

                        $("#cmbTipoPrecio").val("M");
                    }
                    else {
                        mAlertMsg("No se encuentran datos!", 1);
                    }
                    //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                }
                else {

                    var sError = ObjRep.sRpta;
                    var iCodigo = ObjRep.iCodigo;

                    mAlertMsg("Error. detail:" + sError, 1);
                }
            }
            , error: function (xhr, textStatus, errorThrown) {
                mAlertMsg('Error xhr.status: ' + xhr.status, 2);
            }

        });

}

function mGetMoneda() {
    debugger;

    $("#cmbMoneda").html("");//reset data combobox


    $.ajax(
        {
            type: "POST", //HTTP POST Method
            // timeout: 5000,
            url: Url_WebAdmin + "Ordenes/mGetMoneda", // Controller/View
            data: { //Passing data

            },
            dataType: 'json',
            beforeSend: function () {
                $body.addClass("loading");
            },
            complete: function (data) {
                $body.removeClass("loading");
            },
            success: function (data) {

                var ObjRep = JSON.parse(data);

                if (ObjRep == null || ObjRep == undefined) {
                    mAlertMsg("La conversion de Datos no ha sido la correcta!", 2);
                    return;
                }

                if (ObjRep.bEstado) {

                    //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                    var TableDataTable = ObjRep.obj;

                    if (TableDataTable == null) {
                        mAlertMsg("No se encuentran datos!", 1); return;
                    }

                    var iTableDataTableCount = ObjRep.obj.length;

                    if (iTableDataTableCount > 0) {

                        cmbControl("cmbMoneda", "-1", "-seleccione-");
                        for (var i in TableDataTable) {

                            var Codigo = TableDataTable[i].Codigo;
                            var Nombre = TableDataTable[i].Nombre;

                            cmbControl("cmbMoneda", Codigo, Nombre);
                        }
                    }
                    else {
                        mAlertMsg("No se encuentran datos!", 1);
                    }
                    //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                }
                else {

                    var sError = ObjRep.sRpta;
                    var iCodigo = ObjRep.iCodigo;

                    mAlertMsg("Error. detail:" + sError, 1);
                }
            }
            , error: function (xhr, textStatus, errorThrown) {
                mAlertMsg('Error xhr.status: ' + xhr.status, 2);
            }

        });

}





function mSearchInfo(scmbCriterio, stxtSearch) {
    debugger;


    $("#tbDet_CuentaValor").html("");//reset data combobox
    $("#tbDet_CargarValores").html("");//reset data combobox

    //var table = $('#tbCab_CuentaValor').DataTable();
    //var table2 = $('#tbCab_CargarValores').DataTable();

    Table_tbCab_CuentaValor.clear();
    Table_tbCab_CargarValores.clear();

   // Table_tbCab_CuentaValor = Table_tbCab_CuentaValor.row().remove();
   // Table_tbCab_CargarValores = Table_tbCab_CargarValores.rows().remove();

    $.ajax(
        {
            type: "POST", //HTTP POST Method
            url: Url_WebAdmin + "Ordenes/mSearchInfo", // Controller/View
            data: { //Passing data
                sTypeSearch: scmbCriterio, sValSearch: stxtSearch
            },
            dataType: 'json',
            beforeSend: function () {
                $body.addClass("loading");
            },
            complete: function (data) {
                $body.removeClass("loading");
            },
            success: function (data) {
                debugger;
                var ObjRep = JSON.parse(data);

                if (ObjRep == null || ObjRep == undefined) {
                    mAlertMsg("La conversion de Datos no ha sido la correcta!", 2);
                    return;
                }

                if (ObjRep.bEstado) {
                    debugger;

                    //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

                    var ObjRepInfo = JSON.parse(ObjRep.obj);

                    if (ObjRepInfo == null) {
                        mAlertMsg("No se encuentran datos!", 1); return;
                    }

                    debugger;
                    $("#lblNombreRazonSocial").text(ObjRepInfo.CompraVenta_DatosPersonales.Nombre);
                    $("#lblDNI").text(ObjRepInfo.CompraVenta_DatosPersonales.NumeroDocumento);
                    $("#lblDIreccion").text(ObjRepInfo.CompraVenta_DatosPersonales.Direccion);
                     $("#lblTelefonos").text(ObjRepInfo.CompraVenta_DatosPersonales.Telefonos);
                    $("#lblEmail").text(ObjRepInfo.CompraVenta_DatosPersonales.Email);

                    var iCuentasCliente = ObjRepInfo.CuentasCliente.length;
                    var iCargarValores = ObjRepInfo.CargarValores.length;

                    var CuentasCliente = ObjRepInfo.CuentasCliente;
                    var CargarValores = ObjRepInfo.CargarValores;

                    if (iCuentasCliente > 0) {
                        for (var k in CuentasCliente) {

                            var result = [{
                                CtaValor: CuentasCliente[k].CtaValor,
                                Rut: CuentasCliente[k].Rut,
                                CuentaEconomicaCargo: CuentasCliente[k].CuentaEconomicaCargo,
                                CuentaEconomicaAbono: CuentasCliente[k].CuentaEconomicaAbono,
                                ComisionRueda: CuentasCliente[k].ComisionRueda,
                                Mancomunado: CuentasCliente[k].Mancomunado
                            }];

                            Table_tbCab_CuentaValor.rows.add(result).draw();
                        }
                    }


                    if (iCargarValores > 0) {

                        for (var k in CargarValores) {

                            var result = [{
                                CuentaValor: CargarValores[k].CuentaValor,
                                SaldoContable: CargarValores[k].SaldoContable,
                                SaldoDisponible: CargarValores[k].SaldoDisponible,
                                Nemonico: CargarValores[k].Nemonico,
                                Moneda: CargarValores[k].Moneda,
                                PrecioPromedio: CargarValores[k].PrecioPromedio,
                                PrecioActual: CargarValores[k].PrecioActual,
                                ValorizacionActual: CargarValores[k].ValorizacionActual,
                                Utilidad: CargarValores[k].Utilidad,
                                Custodio: CargarValores[k].Custodio
                            }];

                            Table_tbCab_CargarValores.rows.add(result).draw();

                        }
                    }



                    var total = 0;
                    $('#tbCab_CargarValores').DataTable().rows().data().each(function (el, index) {
                        //debugger;
                        //Asumiendo que es la columna 5 de cada fila la que quieres agregar a la sumatoria
                        total += parseFloat( el.ValorizacionActual);
                    });
                    console.log("tbCab_CargarValores: " + total.toLocaleString() );

                    //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                }
                else {

                    var sError = ObjRep.sRpta;
                    var iCodigo = ObjRep.iCodigo;

                    mAlertMsg("Error. detail:" + sError, 1);
                }
            }
            , error: function (xhr, textStatus, errorThrown) {
                mAlertMsg('Error xhr.status: ' + xhr.status, 2);
            }

        });

}


function mGuardar(scmbCriterio, stxtSearch) {
    debugger;


    $("#tbDet_CuentaValor").html("");//reset data combobox
    $("#tbDet_CargarValores").html("");//reset data combobox

    //var table = $('#tbCab_CuentaValor').DataTable();
    //var table2 = $('#tbCab_CargarValores').DataTable();

    Table_tbCab_CuentaValor.clear();
    Table_tbCab_CargarValores.clear();

    // Table_tbCab_CuentaValor = Table_tbCab_CuentaValor.row().remove();
    // Table_tbCab_CargarValores = Table_tbCab_CargarValores.rows().remove();

    $.ajax(
        {
            type: "POST", //HTTP POST Method
            url: Url_WebAdmin + "Ordenes/mSearchInfo", // Controller/View
            data: { //Passing data
                sTypeSearch: scmbCriterio, sValSearch: stxtSearch
            },
            dataType: 'json',
            beforeSend: function () {
                $body.addClass("loading");
            },
            complete: function (data) {
                $body.removeClass("loading");
            },
            success: function (data) {
                debugger;
                var ObjRep = JSON.parse(data);

                if (ObjRep == null || ObjRep == undefined) {
                    mAlertMsg("La conversion de Datos no ha sido la correcta!", 2);
                    return;
                }

                if (ObjRep.bEstado) {
                    debugger;

                    //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

                    var ObjRepInfo = JSON.parse(ObjRep.obj);

                    if (ObjRepInfo == null) {
                        mAlertMsg("No se encuentran datos!", 1); return;
                    }

                    debugger;
                    $("#lblNombreRazonSocial").text(ObjRepInfo.CompraVenta_DatosPersonales.Nombre);
                    $("#lblDNI").text(ObjRepInfo.CompraVenta_DatosPersonales.NumeroDocumento);
                    $("#lblDIreccion").text(ObjRepInfo.CompraVenta_DatosPersonales.Direccion);
                    $("#lblTelefonos").text(ObjRepInfo.CompraVenta_DatosPersonales.Telefonos);
                    $("#lblEmail").text(ObjRepInfo.CompraVenta_DatosPersonales.Email);

                    var iCuentasCliente = ObjRepInfo.CuentasCliente.length;
                    var iCargarValores = ObjRepInfo.CargarValores.length;

                    var CuentasCliente = ObjRepInfo.CuentasCliente;
                    var CargarValores = ObjRepInfo.CargarValores;

                    if (iCuentasCliente > 0) {
                        for (var k in CuentasCliente) {

                            var result = [{
                                CtaValor: CuentasCliente[k].CtaValor,
                                Rut: CuentasCliente[k].Rut,
                                CuentaEconomicaCargo: CuentasCliente[k].CuentaEconomicaCargo,
                                CuentaEconomicaAbono: CuentasCliente[k].CuentaEconomicaAbono,
                                ComisionRueda: CuentasCliente[k].ComisionRueda,
                                Mancomunado: CuentasCliente[k].Mancomunado
                            }];

                            Table_tbCab_CuentaValor.rows.add(result).draw();
                        }
                    }


                    if (iCargarValores > 0) {

                        for (var k in CargarValores) {

                            var result = [{
                                CuentaValor: CargarValores[k].CuentaValor,
                                SaldoContable: CargarValores[k].SaldoContable,
                                SaldoDisponible: CargarValores[k].SaldoDisponible,
                                Nemonico: CargarValores[k].Nemonico,
                                Moneda: CargarValores[k].Moneda,
                                PrecioPromedio: CargarValores[k].PrecioPromedio,
                                PrecioActual: CargarValores[k].PrecioActual,
                                ValorizacionActual: CargarValores[k].ValorizacionActual,
                                Utilidad: CargarValores[k].Utilidad,
                                Custodio: CargarValores[k].Custodio
                            }];

                            Table_tbCab_CargarValores.rows.add(result).draw();

                        }
                    }



                    var total = 0;
                    $('#tbCab_CargarValores').DataTable().rows().data().each(function (el, index) {
                        //debugger;
                        //Asumiendo que es la columna 5 de cada fila la que quieres agregar a la sumatoria
                        total += parseFloat(el.ValorizacionActual);
                    });
                    console.log("tbCab_CargarValores: " + total.toLocaleString());

                    //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                }
                else {

                    var sError = ObjRep.sRpta;
                    var iCodigo = ObjRep.iCodigo;

                    mAlertMsg("Error. detail:" + sError, 1);
                }
            }
            , error: function (xhr, textStatus, errorThrown) {
                mAlertMsg('Error xhr.status: ' + xhr.status, 2);
            }

        });

}







function cmbControl(cmbId, Value, Text) {
    var cmb = document.getElementById(cmbId);
    var option = document.createElement("option");
    option.text = Text;
    option.value = Value;
    cmb.appendChild(option);
}

