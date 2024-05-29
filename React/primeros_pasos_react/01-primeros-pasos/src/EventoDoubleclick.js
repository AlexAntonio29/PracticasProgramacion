import React from 'react'

export const EventoDoubleclick = () => {

    const DobleClick=(e)=>{//usar una constante convertido en funcion Es una constante funcion

            alert("HAS PRESIONADO DOBLE VEZ");//solo llamo al alert
    }


  return (
    <div>

    <button onDoubleClick={e=>DobleClick(e)}>DoubleClick</button>

    </div>
  )
}
