import React from 'react'
import { Link } from 'react-router-dom'
import { ListadoTrabajos, Popular } from './ListadoTrabajos'
import { trabajos } from './data/trabajos'

export const Inicio = () => {



 
  return (
    <div className='inicio'>

      

      

          <h1>

           <span style={{fontWeight:"Bolder", fontSize:"35px"}}>Hola </span> 
         soy Alexis Antonio de México,desarrollador de software Web, aplicaciones de escritorio
          y Movil con Android a traves del lenguaje Java, Ofrezco mis servicios en todo tipo de proyectos de menor o mayor escala.

          </h1>

          <h2>Tu proyecto que estas deseando puede volverse realidad y cobrar suma relevancia en internet y alcanzar a mas publico
            gracias a las apps moviles. <Link className='button' to="/contacto">contáctame</Link>
          </h2>

          <section>
            <h2>Algunos de mis proyectos:</h2>
            <p>Estos son algunos de mis trabajos de desarrollador:</p>
           <ListadoTrabajos limite={trabajos.length}/>
          
           

            <div className='works'></div>
          </section>
      </div>
      
      
  )
}
