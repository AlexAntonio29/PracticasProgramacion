import React from 'react'
import { NavLink } from 'react-router-dom'

export const HeaderNav = () => {

const activar_nav=(e)=> e?"nav_activado":"not_nav_activado"

  return (
    <header className='header'>

      <div className='logo'>

        
          <span>A</span>
          <h3>lexis ntonio ngel</h3>
       
        
      </div>
      <nav>
        <ul>
          <li><NavLink className={({isActive})=>activar_nav(isActive)} to="/inicio">Inicio</NavLink></li>
          <li><NavLink className={({isActive})=>activar_nav(isActive)} to="/curriculum">Curriculum</NavLink></li>
          <li><NavLink className={({isActive})=>activar_nav(isActive)} to="/portafolio">Portafolio</NavLink></li>
          <li><NavLink className={({isActive})=>activar_nav(isActive)} to="/servicio">Servicio</NavLink></li>
          <li><NavLink className={({isActive})=>activar_nav(isActive)} to="/contacto">Contacto</NavLink></li>
        </ul>
      </nav>
    </header>
  )
}
