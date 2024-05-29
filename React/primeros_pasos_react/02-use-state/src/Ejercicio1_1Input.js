import React from 'react'
import propType from 'react'

export const Ejercicio1_1Input = ({year, setYear}) => {


    const cambiarFecha = (e, fechaFija)=>{

        setYear(fechaFija);

    }


  return (
    <div>

 <h3>Ingreso de año manual  </h3>

 <input  type="text" onChange={e => cambiarFecha(e, e.target.value)} placeholder='Introduce el año..'/>



    </div>
  )
}


Ejercicio1_1Input.propType={

    year: propType.number,
    setYear: propType.number
}