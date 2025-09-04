import React, { useEffect, useState } from 'react'
import { useParams } from 'react-router-dom'
import { trabajos } from './data/trabajos';
import { ErrorPagina } from '../components/ErrorPagina'




export const Proyecto = () => {

    const parm=useParams();

    const [proyecto,setProyecto]=useState({});

    useEffect(()=>{
        
        let proyecto = trabajos.filter(trabajo=>trabajo.name===parm.id);
        
        setProyecto(proyecto[0]);
   
        
    },[]);

   
  return !proyecto ?.id?(

    <div>
       <ErrorPagina/>

    </div>)
    :(<div className='work-item'>
    
    <div className='mask' style={{height:"500px"}}>
        {< img src={require(`./images/${proyecto.id}.PNG`)}/>}
    </div>
    <h1>{proyecto.name}</h1>
    <span>Categoría:{proyecto.categoria}</span>
     <h3>{proyecto.tecnologia}</h3>
     <h2 style={{border:"none"}}>Tema:{proyecto.tema}</h2>
     <span>{proyecto.descripcion}</span>
    </div>)
  
}
