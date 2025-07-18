import React from 'react'
import {NavLink} from 'react-router-dom'


export const Navegacion = () => {
  return (
    <div>
         <nav>
        <ul>
           {/*  El NavLink podemos utilizarlo como enlace para agregarlo 
                En cualquier objeto de la web, a sea un hipervinculo <a><a/> o asi
           */}
            <li> <NavLink to={"/inicio"}> Inicio </NavLink> </li>
            <li> <NavLink to={"/contacto"}> Contacto</NavLink> </li>
            <li> <NavLink to={"/articulo"}> Articulo </NavLink> </li>
        </ul>
       </nav>
    </div>
  )
}
