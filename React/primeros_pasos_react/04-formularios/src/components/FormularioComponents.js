import React, { useState } from 'react'

export const FormularioComponents = () => {
     

    const [usuario, setUsuario]= useState([]);

    const conseguirDatosFormulario=e=>{

        e.preventDefault();
        let datos= e.target;
         let usuario ={
                nombre:datos.nombre.value,
                apellido:datos.apellido.value,
                genero:datos.genero.value,
                biografia:datos.biografia.value
        }

            if(!(usuario.nombre!==""&& usuario.apellido!==""&&usuario.genero!==""&&usuario.biografia!==""))
                    alert("Datos no rellenados...");
                else{
                    console.log(usuario);
                    setUsuario(usuario);
                }

        
    }


    const conseguirDatosIndividuales = e =>{

        setUsuario( datosAnteriores =>({
            ...datosAnteriores,
            [e.target.name]: e.target.value
        })


        )

    }
  return (
    <div >


        <div className='formulario'>
        <h1>Formularios con React</h1>

    <form  onSubmit={conseguirDatosFormulario}>
        <input onChange={conseguirDatosIndividuales} name='nombre' type='text' placeholder='Nombre'/>
         <input onChange={conseguirDatosIndividuales} name='apellido' type='text' placeholder='Apellido'/>
         <select onChange={conseguirDatosIndividuales} name='genero'>
                <option value="hombre">Hombre</option>
                <option value="mujer">Mujer</option>


         </select>

         <textarea onChange={conseguirDatosIndividuales} name='biografia' placeholder='Biografía'></textarea>

         <input name='enviar' type='submit' value="Enviar"/>


    </form>

    </div>

    {
        usuario.biografia && (
            <div className='datos-recopilados'>
                <h2>Datos Recopilados</h2>
                    <strong>El usuario {usuario.nombre} con apellido {usuario.apellido} esta activo. </strong>
                    
                    <strong>genero: {usuario.genero} con la biografia:</strong>
                   
                    <strong>{usuario.biografia}</strong>
           
            </div>
        )
    }
   



    </div>
  )
}
