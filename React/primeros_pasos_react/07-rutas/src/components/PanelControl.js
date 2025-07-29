import React from 'react'
import { NavLink, Outlet } from 'react-router-dom'

export const PanelControl = () => {

    const design=(e)=> e?"nav_activado":"not_nav_activado"
                
  return (
    <div>
        <h1>Panel de Control</h1> <strong>submenu:</strong>

        <ul>
             <li><NavLink className={({isActive})=>design(isActive)} to="/panel/inicio">Inicio</NavLink> </li>
             <li><NavLink className={({isActive})=>design(isActive)} to="/panel/crear-articulo">Crear Articulo</NavLink></li>
             <li><NavLink className={({isActive})=>design(isActive)}to="/panel/gestionar-usuario">Gestionar usuario</NavLink></li>
             <li><NavLink className={({isActive})=>design(isActive)}to="/panel/acerca-de">Acerca De</NavLink></li>
        </ul>

        <Outlet/>

    </div>
  )
}
