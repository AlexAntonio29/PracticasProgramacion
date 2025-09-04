import React from 'react'

export const Contacto = () => {

const enviar=(e)=>{
  e.preventDefault();

  const nombre= e.target.nombre.value;
  const apellidos=e.target.apellidos.value;
  const email=e.target.email.value;
  const descripcion=e.target.descripcion.value;

  console.log(`${nombre} ${apellidos} ${email} ${descripcion}`);
}

  return (
    <div className='page'>
      <h1>Contacto :</h1>
      <h2>Mandame un Email a traves de este medio.</h2>

      <form className='contact' onSubmit={e=>enviar(e)}>

        <input type='text' placeholder='Nombre' name='nombre'></input>
        <input type='text' placeholder='Apellidos' name='apellidos'></input>
        <input type='text' placeholder='email' name='email'></input>
        <textarea placeholder='motivo de contacto' name='descripcion' />
        <input type='submit' name='enviar' value="Enviar"/>

      </form>

    </div>
  )
}
