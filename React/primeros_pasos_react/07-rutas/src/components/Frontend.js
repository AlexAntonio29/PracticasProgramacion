import React from 'react'
import {Outlet } from 'react-router-dom'
import { Navegacion } from './Navegacion'

export const Frontend = () => {
  return (
 
    //cargar componentes a traves de rutas
    <div>

       <header>
        <h1>Titulo de la pagina</h1>
       </header>
    <hr/>
      <Navegacion/>
      <hr/>
      <Outlet/>
<hr/>
        <footer>
          <p>Pie de pagina</p>
        </footer>
    

    </div>
  )
}
