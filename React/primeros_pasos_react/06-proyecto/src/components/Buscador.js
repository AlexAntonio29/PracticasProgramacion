import React, { useState } from 'react'

export const Buscador = ({listadoState, setListadoState}) => {
//hook useState
  const [buscadorState, setBuscadorState] = useState('');
  const [mensajeBuscador, setMensajeBuscador] = useState('');


//asignar valor al state y hacer que esta interactue con el frontend
  const buscarResultado=(e)=>{
  let valor=e.target.value;
  setBuscadorState(valor);

  //filtrar valores
  let resultado= listadoState.filter(encontrado=>{
    return encontrado.titulo.toLowerCase().includes(buscadorState.toLocaleLowerCase());
  });
  setMensajeBuscador("");
  //si no hay resultado
  if(buscadorState.length<=1|| resultado<=0){
  resultado=JSON.parse(localStorage.getItem("peliculas"));
  //agregar mensaje
  setMensajeBuscador("No se ha encontrado la pelicula");
  }
    
  

  //si hay resultado guardo los resultados en el estado usestate setListado

  setListadoState(resultado);
  
}
  
  return (
   <>
   <div className="search">
                <h3 className="title">Buscador: {buscadorState}</h3>
                <span style={{color:"red"}}>{mensajeBuscador}</span>
                <form>
                    <input  type="text" 
                            name='buscador'
                            id='buscador'
                            onChange={e=>buscarResultado(e)}
                    />


                    <button>Buscar</button>
                </form>
            </div>
   </>
  )
}
