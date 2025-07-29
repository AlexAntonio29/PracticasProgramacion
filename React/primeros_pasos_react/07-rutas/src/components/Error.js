import React from 'react'
import { Link } from 'react-router-dom'

export const Error = () => {
  return (
    <div>
    
                <h1>Error al dirigir pagina 404</h1>

                <strong>
                    La pagina que intentas acceder no existe 
                </strong>
               
               <Link to="/inicio"> volver al inicio</Link>
    </div>
  )
}
