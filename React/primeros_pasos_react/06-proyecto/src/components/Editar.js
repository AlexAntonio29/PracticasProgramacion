import React from 'react'

export const Editar = ({pelicula, conseguirListadoPeliculas, setListadoState, setEditState}) => {

    const titulo_componente="Editar Titulo";

//conseguir listado peliculas




    const guardarEdicion =(e, id)=>{
      //generar la prevencion de actualizar por defecto
      e.preventDefault();

      //agregar target para poder obtener valores del e
      const target= e.target;

      //separar valores del target
      let titulo= target.titulo.value;
      let descripcion=target.descripcion.value;
      //obtener peliculas del array del localStorage
      let peliculas = conseguirListadoPeliculas();

      //uso una funcion del array para buscar un objeto dentro del array si cumple una funcion
      let index= peliculas.findIndex(pelicula=>pelicula.id===id);

      let pelicula_editada = {
        id,
        titulo,
        descripcion
      }

      peliculas[index]=pelicula_editada;

      console.log(peliculas[index]);

      //guardar el array en el localStorage

      localStorage.setItem("peliculas",JSON.stringify(peliculas));

      //guardar en el estado para que se actualice rápido
      setListadoState(peliculas);
      setEditState(0);

      

      
    }

  return (
    <div className='edit_form'>

        <h3 className='title'>{titulo_componente}</h3>
        <form onSubmit={e=>guardarEdicion(e , pelicula.id)}>

            <input 
            type="text"
            placeholder="Titulo"
            id='titulo'
            className='titulo_editado'
            name='titulo'
            defaultValue={pelicula.titulo}
            
            />

            <textarea
            placeholder='descripcion'
            id='descripcion'
            name='descripcion'
            className='descripcion_editado'
            defaultValue={pelicula.descripcion}
            ></textarea>
            
            <input type='submit' value="Editar"/>


        </form>


    </div>
  )
}
