import React from 'react'
import { Outlet } from 'react-router-dom'

export const Frontend = () => {
  return (
    <div>
        {/*HEAD*/}
        <h3>Cabeza</h3>
        {/*NAVEGATION*/}
        <h3>Navegacion</h3>
        {/*BODY*/}
        <h3>Cuerpo</h3>
        <Outlet/>

        <h3>Pie de Página</h3>
        {/*FOOTER*/}
    

    </div>
  )
}
