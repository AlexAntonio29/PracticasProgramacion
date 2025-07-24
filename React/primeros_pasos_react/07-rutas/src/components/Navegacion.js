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
            <li> <NavLink 
            className={
              ({isActive})=>{
                return isActive?"nav_activado": "not_nav_activado"//llamar a la funcion isActive que tiene el objeto
              }
            }
            to={"/inicio"}> Inicio </NavLink> </li>
            <li> <NavLink 
              className={
              (datos)=>
                  datos.isActive?"nav_activado": "not_nav_activado"//obteniendolo por variable
                 
              
            }
            to={"/contacto"}> Contacto</NavLink> </li>
            <li> <NavLink 
               className={
              ({isActive})=>isActive?"nav_activado": "not_nav_activado"/*
                obteniendo la funcion isActive por medio mas simplificado
              */
              
            }
            to={"/articulo"}> Articulo </NavLink> </li>
        </ul>
       </nav>
    </div>
  )
}
