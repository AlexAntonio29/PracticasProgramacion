import React from 'react'
import {Link, Outlet} from 'react-router-dom'
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
      <h3>Aqui va la Navegacion</h3>
      <Outlet/>
<hr/>
        <footer>
          <p>Pie de pagina</p>
          <button id='b_home' className='button_active'> <Link style={{textDecoration:"none", color:"white"}} to="/redirigir"> Home </Link></button>
   
        </footer>
    

    </div>
  )
}
