import React from 'react'
import { useNavigate, useParams } from 'react-router-dom'

export const Persona = () => {
//utiliza el useParams para traer parametros que llamas desde el RouterPrincipal desde nuevas rutas
    let {nombre, apellido }=useParams();
    const navegar= useNavigate();


    const enviar=(e)=>{
      e.preventDefault();
      let name=e.target.nombre.value;
      let apellido=e.target.apellido.value;
      let url=`/persona/${name}/${apellido}`;
      console.log(url);
      if(name.length<=0&&apellido.length<=0) navegar("/inicio");
      else navegar(url);
    }

  return (
    <div>
      {!nombre && !apellido &&(<h1>No hay Persona agregada</h1>)}
      {nombre && apellido &&(<h1> Persona: {nombre} {apellido}</h1>)}
     
    
    <form onSubmit={enviar}>

      <input name='nombre' type='text' placeholder='Introduce Nombre..'/>
      <input name='apellido' type='text' placeholder='Introduce Apellido..'/>
      <input name='enviar' type='submit' value="Enviar"/>
      
    </form>
    </div>

    
  )
}
