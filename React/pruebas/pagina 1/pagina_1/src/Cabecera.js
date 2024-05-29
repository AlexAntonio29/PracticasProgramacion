import React from 'react'

export const Cabecera = () => {


    const presionar = (e) =>{
      alert("Has presionado del boton");
    }
  return (
    <div>

      <h3>PAGINA PRINCIPAL</h3>
      

  


<button onClick={ presionar}>Presiona</button>
    </div>

    
  )
}
