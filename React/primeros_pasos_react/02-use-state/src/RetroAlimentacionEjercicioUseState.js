import React, { useState } from 'react'

export const RetroAlimentacionEjercicioUseState = () => {


    let botonAntes= document.getElementById("botonBefore");
    let botonDespues= document.getElementById("botonAfter");

    const date = (new Date().getFullYear());

    const [year=date, setYear] = useState(date);

    const afterYear=(e)=>{
        
    

        setYear(year+1);}
    const beforeYear=(e)=>{
          
        setYear(year-1);}

    const errorChange=()=>{
        setYear(date);
        alert("Dato Mal implementado... intenta nuevamente");
        document.getElementById('inputYear').value=""
        
    }
    const changeYear=(e, change)=>{( document.getElementById('inputYear').value=='') ? (setYear(date)) :
 !isNaN(document.getElementById('inputYear').value)? setYear(change): errorChange();
    }

    

    

  return (

   
    <div>
        



<button id='miBoton'  style={{borderRadius:'10px', background:'#white',color:'red'}} onClick={e=>beforeYear(e)}>Año anterior</button>
 &nbsp;
<strong style={{borderRadius:'10px', background:'#white',color:'red'}} >{year}</strong>
  &nbsp;
<button id='miBoton' style={{borderRadius:'10px', background:'#white',color:'red'}} onClick={e=>afterYear(e)}>Año Siguiente</button>
<h3>Modificar Manualmente</h3>



<input style={{marginBottom:'30px'}} id='inputYear' onChange={e=>changeYear(e, parseInt(e.target.value))} placeholder='Agregar Año'></input>




<hr/>
    </div>

    
  )

  
}
