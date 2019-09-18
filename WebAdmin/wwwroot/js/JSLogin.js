
$body = $("body");

$(document).ready(function () {

    $("#btnLogin").click(function () {
        var stxtUsuario = $("#txtUsuario").val();
        var stxtPassword = $("#txtPassword").val();

        if (stxtUsuario.length <= 0 || stxtPassword.length <= 0 ) {
            mAlertMsg('Ingrese Usuario y Password!', 2);
            return;
        }

        mLogin(stxtUsuario, stxtPassword);

    });

});


function mLogin(sUsuario, sPassword) {
    debugger;

    $.ajax(
        {
            type: "POST", //HTTP POST Method
            url: Url_WebAdmin + "Login/mLogin", // Controller/View
            data: { //Passing data
                sUsuario: sUsuario,
                sPassword: sPassword
            },
            dataType: 'json',
            beforeSend: function () {
                // setting a timeout
                $body.addClass("loading"); 
            },
            complete: function (data) {
                //alert(data.status);// S1000
                //  alert("COMPLETE");// S1000
                $body.removeClass("loading");
            },
            success: function (data) {
                debugger;
                var ObjRep = JSON.parse(data);

                if (ObjRep.bEstado == true) {

                    var url = $("#RedirectTo").val();
                    location.href = url;

                }
                else {

                    var sError = ObjRep.sRpta;
                    var iCodigo = ObjRep.iCodigo;

                    
                   // alert("Usuario o Password incorrectos.");

                  //  alert("Error. iCodigo: " + iCodigo + " detail:" + sError);

                    mAlertMsg("Error. iCodigo: " + iCodigo + " detail:" + sError, 1);
                }
            }
            , error: function (xhr, textStatus, errorThrown) {
                var ft = "";

              //  mAlertMsg("Error. iCodigo: " + iCodigo + " detail:" + sError, 1);

                mAlertMsg('Error xhr.status: ' + xhr.status, 2);
            }

        });
}

