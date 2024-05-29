import React from 'react'

export const EventoOnclick = () => {



    const click = (e)=>{

        alert("Has presionado el boton " );
    }


  return (
    <div>

    <button onClick={ e=> click(e)}>Presioname</button>


    </div>
  )
}
