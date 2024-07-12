import React from 'react'
import './Formulario.css';

import { ButtonAction1 } from './ButtonAction1';

export const FormularioUsuario = () => {
  return (
    <div className='designFormulario'>


        <input placeholder='Introduzca su usuario...' className='input' type='text'/>
        < ButtonAction1/>         
       

    </div>

    
  )
}
