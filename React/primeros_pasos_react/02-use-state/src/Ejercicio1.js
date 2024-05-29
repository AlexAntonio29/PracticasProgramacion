import React, { useState } from 'react'
import { Ejercicio1_1Input } from './Ejercicio1_1Input';


export const Ejercicio1 = (cosas) => {

let year= (new Date().getFullYear());
let [change=year, setChange]= useState(year);



const after = (e)=>{

    setChange(change-1);
    
}

const next = (e)=>{

    setChange(change+1);
}

let ErrorChange =()=> {
  alert("No es un numero")
 document.getElementById("inputYear").value="";
 setChange(year);
}
let changetext = (e, textoFijo)=>{  !isNaN(document.getElementById("inputYear").value) ? setChange(textoFijo) : ErrorChange() ;

}
  return (
    <div>


        <button onClick={e=>after(e)}>Anterior</button>
        &nbsp;
           <strong>{change}</strong>
        &nbsp;
        <button onClick={e=>next(e)}>Siguiente</button>


        <h3>Modificar Fecha Manual</h3>

        <input type='text' onChange={ e=> changetext(e, parseInt(e.target.value))} placeholder='introduce año'  id='inputYear'/>

    </div>



  )
}


