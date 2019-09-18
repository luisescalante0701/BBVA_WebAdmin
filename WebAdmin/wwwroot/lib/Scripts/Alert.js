

function mAlertMsg(msj, tipo) {

    if (tipo == 0) { //OK
        swal(
			'Good!',
			msj,
			'success'
		)
    }
    else
        if (tipo == 1) {//ADVERTENCIA
            swal(
                'Warning!',
                msj,
                'warning'
            )
        }
        else
            if (tipo == 2) {//ERROR
                swal(
                    'Ups!',
                    msj,
                    'error'
                )
            }
}