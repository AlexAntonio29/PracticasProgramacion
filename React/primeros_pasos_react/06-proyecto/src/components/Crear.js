import React, { useState } from 'react'
import { GuardarEnStorage } from '../helpers/GuardarEnStorage';

export const Crear = ({setListadoState}) => {

const tituloComponente="Añadir Película";

const  [peliculaState, setPeliculaState] =useState({
  
    titulo:"",
    descripcion:""
});

const {id,titulo, descripcion} = peliculaState


const conseguirDatos=e=>{
    //prevenir que se recargue la pantalla por defecto
    e.preventDefault();

    //Conseguir Datos Formulario

    const target = e.target;
    const titulo = target.titulo.value;
    const descripcion= target.descripcion.value;
    
   

    //Crear objeto de la película
     
    const pelicula={
        id: new Date().getTime(),
        titulo,
        descripcion
    };


    //guardar en el state
    setPeliculaState(pelicula);
    console.log(setPeliculaState);

    //Actualizar el estado del listado principal

   
    setListadoState(elementos => elementos!==null ?[...elementos, pelicula] : [pelicula]);

 
    

    //Guardar en el almacenamiento local
    GuardarEnStorage("peliculas",pelicula);

    
    
}



  return (
     <div className="add">
                <h3 className="title"> {tituloComponente}</h3>

                {(titulo && descripcion && id) && (
                    <strong style={{color:"red"}}>La pelicula {titulo} ha sido creada</strong>
                )}
                <form onSubmit={conseguirDatos}>
                    <input 
                        type="text" 
                        id='titulo'
                        name='titulo'
                        placeholder="Titulo"/>

                    <textarea 
                        placeholder="Descripción"
                        id='descripcion'
                        name='descripcion'
                    ></textarea>
                    <input type="submit" value="Guardar"/>
                </form>
            </div>
  )
}



