
import React, { useEffect, useState } from 'react';
import { Editar } from './Editar';



export const Listado = ({listadoState, setListadoState}) => {

    //usar el boton editar

    const [editSate, setEditState] = useState(0);

   // const [listadoState, setListadoState] = useState([]);

    //REGLA DE ORO LOS HOOKS SIEMPRE DEBEN DE ESTAR ARRIBA DE LAS FUNCIONES RECOMENDADO POR REACT
    useEffect (() => {
        console.log("Cargando componentes listado:");
        console.log(listadoState);
        conseguirListadoPeliculas();

    },[]);


    const conseguirListadoPeliculas = () =>{
  
        let peliculas = JSON.parse(localStorage.getItem("peliculas"));
 
        setListadoState(peliculas);
         

        return peliculas;
       
    }




    //funcion para eliminar pelicula

    const borrarPelicula=(id)=>{
        //conseguir el estado del storage
        let listado = conseguirListadoPeliculas();

        //filtrar el storage

        let nuevo_listado = listado.filter(pelicula =>  pelicula.id!== parseInt(id));

        

        //actualizar el estado del estado
        setListadoState(nuevo_listado);


        //actualizar el storage
        localStorage.setItem("peliculas",JSON.stringify(nuevo_listado));

       
    }


    //funcion para cambiar el estado a edit
    const editarPelicula =(id)=>{

        setEditState(id);
    }

  

  return (

        <>

            {listadoState && listadoState.length > 0 ? listadoState.map(pelicula=>{

            return(

                
                    
         <article key={pelicula.id} className="peli-item">
           

                <h3 className="title">{pelicula.titulo}</h3>
                <p className="description">{pelicula.descripcion}</p>
                <button className="edit" onClick={()=>editarPelicula(pelicula.id)}>Editar</button>
                <button className="delete" onClick={()=>borrarPelicula(pelicula.id)}>Borrar</button>
           
            {  editSate === pelicula.id &&
            (< Editar/>)}

            
            </article>

           
            ) 
            
        }): <>
    
        <h1 >No hay Peliculas</h1>
        </>
            
    }


        
        </>
   )
}
