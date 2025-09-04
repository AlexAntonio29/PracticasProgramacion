import React, { useRef, useState } from 'react'
import {servicios} from "./data/dataServicios"

export const Servicio = () => {

  const [activate, setActivate] = useState("");

  const [activateSub,setActivateSub] = useState("");

  const designDescription = useRef();



  const activarDatos=(e)=>{
    setActivateSub("");

    if(e!==activate)
        setActivate(e);
      else setActivate("");
   

  }

  
  const activarDatosSub=(e)=>{
        //  designDescription.current.classList.add("designDescriptionShow");
let {current:descripcion}=designDescription;
        let altura=descripcion.offsetHeight;
    if(e!==activateSub)
        {setActivateSub(e); 
          console.log("->");
          if(altura===251)  {descripcion.classList.add("designDescriptionShow"); console.log(`SE AGREGA BORDE ->${altura}`);}

          }  
 else 
        {setActivateSub("");
          descripcion.classList.add("designDescriptionHidden");
          console.log("SE ELIMINA BORDE");
        }
         //designDescription.current.classList.add("designDescriptionHidden");
        
        console.log(altura);  
        
  }


 

  return (



    <div className='page'>
      <h1  >Servicios</h1>
        <section  className='services'>

      {
        servicios.map(servicio=>{
          return(
          
        <article key={servicio.id} className='service'>
          <div className={'subMenu'} onClick={ ()=>activarDatos(servicio.id)} style={{cursor:"pointer"}} >
             <p>{servicio.name}</p>
              
             </div>

          <div style={{display:"flex"}}> 
          <div className={`mask ${activate===servicio.id?'show':'hidden'}`}>
            <img className={`img ${activate===servicio.id?'show':'hidden'}`} 
            onClick={ ()=>activarDatos(servicio.id)} style={{cursor:"pointer"}}  
            src={require(`./images/services/${servicio.id}.png`)}/>

          </div>
         
          
            {activate===servicio.id && <div id='subMenuTotal' ref={designDescription} className={`subMenuTotal ${activate?'show':'hidden'}`}>
              { (servicio.servicio).map(subServicio =>{
              return(
                <ul key={subServicio.id}>
                  <li onClick={()=>activarDatosSub(subServicio.id)}>{subServicio.name}</li>
                   {activateSub === subServicio.id &&<p>{subServicio.descripcion}</p>}
                </ul>
              )
            })}
            </div>
            }
          </div>
         

        </article>
     
          )
        })
      }
       </section>




    </div>
  )
}
