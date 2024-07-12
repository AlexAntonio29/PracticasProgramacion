import React from 'react'

export const TercComponente = (props) => {//props es el parametro que se envio a TecComponente que es la ficha con 5 datos
  return (
    <div>
        <h1>Tercer Componente</h1>
        <hr/>
        <ul>
          {/*Impresion de los datos como si de POO se tratara*/}
            <li>{props.nombre}</li>
            <li>{props.apellidos}</li>
            <li>{props.ficha.edad}</li>
            <li>{props.ficha.altura}</li>
            <li>{props.ficha.tipo_sangre }</li>
        </ul>


    </div>
  )
}
