import React from 'react'
import './Formulario.css';

export const FormularioPrivados = () => {
  return (
    <div className='designFormulario'>
        
        <input placeholder='Correo Electronico' className='input' type='text'/>
        <input placeholder='Contraseña' className='input' type='text'/>
        <button className='design_button'>Continuar</button>

    </div>
  )
}
