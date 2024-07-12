

import React, { useState } from 'react'
import './Formulario.css';
import { CSSTransition } from 'react-transition-group';





export const FormularioUsuario = (props) => {

  const [message, setMesagge]=useState('');


    let actionMessage=(e)=>{
        props(message);

    }
 

  return (
   
    <div className='design_box'>




        <input  onChange={(e)=>setMesagge(e.target.value)}   placeholder='Introduzca su usuario...' className='input' type='text'/>
       
       
          
          
        

    </div>
   

    
  )
}
