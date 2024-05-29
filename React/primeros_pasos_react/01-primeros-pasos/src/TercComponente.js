import React from 'react'

export const TercComponente = (props) => {
  return (
    <div>
        <h1>Tercer Componente</h1>
        <hr/>
        <ul>

            <li>{props.nombre}</li>
            <li>{props.apellidos}</li>
            <li>{props.ficha.edad}</li>
            <li>{props.ficha.altura}</li>
            <li>{props.ficha.tipo_sangre }</li>
        </ul>


    </div>
  )
}
