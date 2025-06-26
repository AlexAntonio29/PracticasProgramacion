import React, { useEffect } from 'react'

export const AvisoComponent = () => {

    const aviso = e =>{

     alert("Presionado el aviso");
    }


    useEffect(()=>{
   alert("SE MONTADO EL COMPONENTE");

        return()=>{
                alert("COMPONTENTE DESMONTADO");//esto es cuando se desmonta el componente
        }
    },[])//esto se llama cuando se monta el componente
  return (
    <div>
        
        <h1>Has llegado a 20 cambios del contador</h1>
        <button onClick={aviso}>Generar aviso</button>
    </div>
  )
}
